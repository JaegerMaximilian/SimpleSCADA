using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_SharedResources
{
    public class PlantManager : DbContext
    {

        

        #region Properties
        private DbSet<Plant> Plants { get; set; } // noch private schalten!!
        private DbSet<SensorData>? SensorDatas { get; set; } // noch private schalten!

        #endregion

        #region Constructor

        public PlantManager()
        {
           // _Transition = new Transitions();
           //for (int i = 0; i < StatusPlants.Count(); i++)
           //{
           //    StatusPlants.SingleOrDefault(x => x.Id == i);
           //}
           
           //FL: Auskommentiert da kommt eine NullReferenceException
           //StatusPlants.Add(new StatusPlantInformation());
        }

        #endregion

        #region Settings DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = $"Data Source=" + AbsoluteDbPath.PathGeneration();
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite(conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbCreationContext.setAllModelConnections(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Methods for Plant

      
       


        /* GetPlant() USECASE:
            * for Kenan to load StationsWithChosenUtility 
            
            * and for mainView to load activeProductionCycle and actualPlantState 
        */
        public  Plant GetPlant()  
        {
            return GetPlantStatic();
        }


        public async Task<Plant> GetPlantAsync()
        {
            return GetPlantStatic();
        }

        /* GetOrderedStationsToDrive() USECASE:
           method for Kenan to only input plant and get correct output of ordered List of current ProdctionCycle.Recipe.Stations
       */
        public List<StationWithChosenUtility> GetOrderedStationsToDrive(Plant plant)
        {
            var active = GetPlant().ActiveProductionCycle;

            if (active != null)
            {
                return PlantManager.SortStations(active.Recipe.Stations.ToList());

            }
            else return new List<StationWithChosenUtility>();
        }


        /* SortStations() USECASE:
                STATIC method to sort stations if neeeded
            */
        public static List<StationWithChosenUtility> SortStations(List<StationWithChosenUtility> stationsToOrder)
        {
            return stationsToOrder.OrderBy(station => station.OrderNumber).ToList();
        }

        /* EditPlant() USECASE:
            * for Kenan to update the Plant.ActiveProductionCycle.FinishedProducts
            * and Plant.ActualPlantState
            * and for mainView to update Plant.RequestedPlantState
        */
        public void EditPlant(Plant editedPlant)
        {
            
            Plant plant = Plants.Find(editedPlant.Id);
            ProductionCycleManager productioncyclemanager = new ProductionCycleManager();
            if (plant.ActiveProductionCycle is null)
            {
                plant.ActiveProductionCycle = productioncyclemanager.GetProductionCycle((int)plant.ActiveProductionCycleId); //achtung, kann null sein
            }

            

            if (plant == null)
            {
                // ERROR HANDLING HERE
            }
            else
            {
                
                // if all Products are Finished, change ActiveProductionCycle to oldest ProductionCycle from ProductionQueue:
                if (plant.ActiveProductionCycle.NumberOfProducts == editedPlant.ActiveProductionCycle.FinishedProducts)
                {
                    plant.ActiveProductionCycle.FinishedProducts = editedPlant.ActiveProductionCycle.FinishedProducts;
                    SaveChanges();
                    ProductionCycleManager context = new ProductionCycleManager();
                    context.SaveChanges();
                    
                    plant.ActiveProductionCycleId = context.GetProductionQueue()[0].Id;
                } // if not all Products are Finished, only change FinishedProducts of ActiveProductionCycle
                else if (plant.ActiveProductionCycle.NumberOfProducts > editedPlant.ActiveProductionCycle.FinishedProducts)
                {
                    
                    plant.ActiveProductionCycle.FinishedProducts = editedPlant.ActiveProductionCycle.FinishedProducts;

                }
                plant.ActualPlantState = editedPlant.ActualPlantState;
                plant.requestedPlantState = editedPlant.requestedPlantState;


                SaveChanges();
            }
           
        }

        private Plant GetPlantPrivate()
        {
            return Plants

                    .Include(e => e.ActiveProductionCycle)
                        .ThenInclude(e => e.Recipe)
                            .ThenInclude(e => e.Stations)
                                .ThenInclude(e => e.ChosenUtility)

                    .Include(e => e.ActiveProductionCycle)
                        .ThenInclude(e => e.Recipe)
                            .ThenInclude(e => e.Stations)
                                .ThenInclude(e => e.Station)
                    .ToList()[0];
        }

        private static Plant GetPlantStatic()
        {
            PlantManager plantmanager = new PlantManager();
            return plantmanager.GetPlantPrivate();
        }


        #endregion

        #region Methods for SensorData
        public void EditSensorData(SensorData changedSensorData)
        {
            foreach (SensorData sensordata in SensorDatas.ToList())
            {
                SensorDatas.Find(sensordata.sensorName).sensorState = false;
                SaveChanges();
            }
            SensorDatas.Find(changedSensorData.sensorName).sensorState = true;
            SaveChanges();

        }

        // GetSensorData() returns only one SensorData-Object bc only one is set to "true" every time
        public SensorData GetSensorData()
        {
            List<SensorData> trueSensorDatas = SensorDatas.Where(sd => sd.sensorState == true).ToList();
            if (trueSensorDatas.Count == 0) return null;
            else return trueSensorDatas[0];
            
        }

        public async Task<List<SensorData>> GetSensorDataAsync()// Task<SensorData>
        {
            List<SensorData> trueSensorDatas = SensorDatas.Where(sd => sd.sensorState == true).ToList();
            if (trueSensorDatas.Count == 0)
            {
                return null;
            }
            else
            {
                return trueSensorDatas;//else return trueSensorDatas[0];
            }
        }
        #endregion
    }
}
