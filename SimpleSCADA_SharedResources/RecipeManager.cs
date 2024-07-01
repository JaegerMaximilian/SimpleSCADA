using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Org.BouncyCastle.Bcpg;
using SimpleSCADA_SharedResources;


namespace SimpleSCADA_SharedResources
{

    public class RecipeManager : DbContext
    {
        #region Members
        public DbSet<Recipe>? Recipes { get; set; }
        public DbSet<Station>? Stations { get; set; }
        public DbSet<Utility>? Utilities { get; set; }
        public DbSet <StationWithChosenUtility>? RecipesStations { get; set; }
        #endregion

        #region Constructor
        public RecipeManager()
        {
            
        }
        #endregion

        #region Settings DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = $"Data Source=" + AbsoluteDbPath.PathGeneration();
            optionsBuilder.UseSqlite(conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbCreationContext.setAllModelConnections(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Methods Recipes
        public Recipe GetRecipe(int id)
        {
            try
            {
                return Recipes.SingleOrDefault<Recipe>(x => x.Id == id);
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to fetch Recipe from Database!",
                    ErrorType.DATABASE,ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
                return null;
            }
        }

        public List<Recipe> GetRecipes()
        {
            try
            {
                return Recipes
                    .Include(e => e.Stations)
                        .ThenInclude(i => i.ChosenUtility)
                        .ThenInclude(i => i.Stations)
                    .ToList();

            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                Error error = new Error("Unable to fetch Recipes from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
                return null;
            }
        }

        public void AddRecipe(Recipe recipe)
        {
            try
            {
                bool isNameEqual = false;

                foreach (var checkRecipe in Recipes)
                {
                    if (checkRecipe.Name == recipe.Name) isNameEqual = true; break;
                }

                if (Recipes.Contains(recipe) == false && isNameEqual == false)
                {
                    Recipes.Add(recipe);
                    SaveChanges();
                }
                else
                {
                    Error error = new Error("Recipe already exists!",
                        ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                        DateTime.Now);
                    ErrorManager.AddError(error);
                }
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to save Recipe to Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }
        public void RemoveRecipe(int recipeId)
        {
            try
            {
                Recipe recipe = Recipes.SingleOrDefault(x => x.Id == recipeId);
                Recipes.Remove(recipe);
                SaveChanges();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to remove Recipe from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }
        public void EditRecipe(Recipe editedRecipe)
        {
            try
            {
                Recipe recipeToEdit = GetRecipe(editedRecipe.Id);
                if (recipeToEdit != null)
                {
                    recipeToEdit.Name=editedRecipe.Name;
                    recipeToEdit.Stations=editedRecipe.Stations;
                    //nur zur Info wenn man Objekt auf Objekt schreibt funktioniert des iwi ned weiß aber ned warum
                    //recipeToEdit = editedRecipe;
                }
                
                SaveChanges();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to edit Recipe from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
            }
        }


        #endregion
        
        #region Stations

        public void WriteStationsToJSON()
        {
            //Create Stations
            List<Station> stations = new List<Station>();
            //Station 1
            List<Utility> utilities1 = new List<Utility>();
            utilities1.Add(new Utility("Fügen", 120));
            utilities1.Add(new Utility("Schweißen", 55));
            utilities1.Add(new Utility("Trennen", 20));
            utilities1.Add(new Utility("Schleifen", 170));
            utilities1.Add(new Utility("Kontrolle", 32));

            stations.Add(new Station("Station_1", utilities1));
            SaveChanges();
            // Write to File

            string json = JsonConvert.SerializeObject(stations, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            File.WriteAllText("C:\\Users\\lukas\\OneDrive\\Desktop\\Stations.json", json);
        }

        public void LoadStationsFromJSON()
        {
            // Get Stations from JSON
            string json = File.ReadAllText("C:\\Users\\lukas\\OneDrive\\Desktop\\Stations.json"); // Add Path
            List<Station> stationsFromJson = JsonConvert.DeserializeObject<List<Station>>(json);
            List<Station> stationsFromDb = Stations.ToList();

            Station existingStation;
            Utility existingUtility;
            Utility nameEqualUtility;

            foreach (Station jsonStation in stationsFromJson)
            {
                existingStation = null;

                // Check if Station is Already in Database
                foreach (Station dbStation in stationsFromDb)
                {
                    if (jsonStation.Name == dbStation.Name)
                    {
                        existingStation = dbStation;
                    }
                }

                // Check Utilities in Station
                if (existingStation != null)
                {
                    foreach (Utility jsonUtility in jsonStation.Utilities)
                    {
                        existingUtility = null;
                        nameEqualUtility = null;

                        foreach (Utility dbUtility in existingStation.Utilities)
                        {
                            // Check if Utility is in Database
                            if (dbUtility.Name == jsonUtility.Name &&
                                dbUtility.SecondsToWait == jsonUtility.SecondsToWait)
                            {
                                existingUtility = dbUtility;
                            }
                            // Check if Utility Name is in Database
                            else if (dbUtility.Name == jsonUtility.Name)
                            {
                                nameEqualUtility = dbUtility;
                            }
                        }

                        // Add Utility to Station in Database
                        if (existingUtility == null &&
                            nameEqualUtility == null)
                        {
                            Station stationToAddUtility = Stations.SingleOrDefault(existingStation);
                            stationToAddUtility.Utilities.Add(jsonUtility);
                            SaveChanges();
                        }
                        // Change Duration of Utility
                        else if (nameEqualUtility != null)
                        {
                            Station stationToChangeDuration = Stations.SingleOrDefault(existingStation);
                            Utility utilityToChangeDuration = stationToChangeDuration.Utilities.SingleOrDefault(nameEqualUtility);
                            utilityToChangeDuration.SecondsToWait = jsonUtility.SecondsToWait;
                            SaveChanges();
                        }

                    }
                }
                // Add Station to Database
                else
                {
                    Stations.Add(jsonStation);
                    SaveChanges();
                }
            }
        }

        public Station GetStation(int id)
        {
            return Stations.SingleOrDefault<Station>(x => x.Id == id);
        }

        public List<Station> GetStations()
        {
            return Stations
                    .Include(e => e.Utilities)
                    .ToList();
        }

        //public void EditRecipe(Recipe editedRecipe)
        //{
        //    Recipe recipe = Recipes.Find(editedRecipe.Id);

        //    if (recipe == null)
        //    {
        //        // ERROR MANAGEMENT
        //    }
        //    else
        //    {
        //        recipe = editedRecipe;
        //        SaveChanges();
        //    }
        //}

        public void DeleteRecipe(Recipe recipe)
        {
            Recipe recipeToDelete = Recipes.Find(recipe);
            if (recipe == null)
            {
                // ERROR MANAGEMENT
            }
            else
            {
                Recipes.Remove(recipeToDelete);
                SaveChanges();
            }
        }

        #endregion

        #region Utilities
        public Utility GetUtility(int id)
        {
            return Utilities.SingleOrDefault<Utility>(x => x.Id == id);
        }
        #endregion
    }
}