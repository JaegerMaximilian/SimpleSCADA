using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_SharedResources
{
    
   


    public class ProductionCycleManager : DbContext
    {
        #region Properties
        private DbSet<ProductionCycle>? ProductionCycles { get; set; }

        #endregion

        #region Constructor

        public ProductionCycleManager()
        {

        }

        #endregion

        #region Settings DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = $"Data Source=" + AbsoluteDbPath.PathGeneration(); // Replace with ConnectionString for Real SQLServer
            optionsBuilder.UseSqlite(conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            DbCreationContext.setAllModelConnections(modelBuilder);



            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Methods

         public  List<ProductionCycle> GetProductionQueue()
         {
            return ProductionCycles
                   .Include(e => e.Recipe)
                     .ThenInclude(e => e.Stations)
                        .ThenInclude(i=>i.ChosenUtility)

                    .Include(e => e.Recipe)
                     .ThenInclude(e => e.Stations)
                        .ThenInclude(e => e.Station)

                    .Include(e=>e.Plant)
       
                   .ToList()
                   .FindAll(productioncycle => productioncycle.FinishedProducts == 0 && productioncycle.Plant == null); // filter all productioncycles that are not finished and not activeProductionCycle!
         }

    
         public async Task<List<ProductionCycle>> GetProductionQueueAsync()
         {
             return ProductionCycles
                 .Include(e => e.Recipe)
                 .ThenInclude(e => e.Stations)
                 .ThenInclude(i => i.ChosenUtility)

                 .Include(e => e.Recipe)
                 .ThenInclude(e => e.Stations)
                 .ThenInclude(e => e.Station)

                 .Include(e => e.Plant)

                 .ToList()
                 .FindAll(productioncycle => productioncycle.FinishedProducts == 0 && productioncycle.Plant == null); // filter all productioncycles that are not finished and not activeProductionCycle!
         }


        public void AddProductionCycle(ProductionCycle productionCycle)
           {
               try
               {
                   bool isOrderNumberEqual = false;
                   foreach (var checkProductionCycle in ProductionCycles)
                   {
                       if (checkProductionCycle.Id == productionCycle.Id) isOrderNumberEqual = true;
                   }

                   if (ProductionCycles.Contains(productionCycle) == false && isOrderNumberEqual == false)
                   {
                       ProductionCycles.Add(productionCycle);
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
                    Error error = new Error("Unable to save ProductionCycle to Database!",
                        ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                        DateTime.Now);
                    ErrorManager.AddError(error);
               }
           }
            
           public void EditProductionCycle(ProductionCycle editedProductionCycle)
           {
               try
               {
                   ProductionCycle productionCycleToEdit = GetProductionCycle(editedProductionCycle.Id);

                   if (productionCycleToEdit != null)
                   {
                       productionCycleToEdit.Customer = editedProductionCycle.Customer;
                       productionCycleToEdit.NumberOfProducts = editedProductionCycle.NumberOfProducts;
                       productionCycleToEdit.RecipeId = editedProductionCycle.RecipeId;
                   }

                   SaveChanges();
               }
               catch (Exception e)
               {
                    Error error = new Error("Unable to edit ProductionCycle from Database!", 
                        ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                        DateTime.Now);
                    ErrorManager.AddError(error);
               }

            //ProductionCycle productioncycle = ProductionCycles.Find(editedProductionCycle.Id);

            //if (productioncycle == null)
            //{
            //    // ERROR MANAGEMENT
            //}
            //else
            //{
            //    productioncycle = editedProductionCycle;
            //    SaveChanges();
            //}
           }

       
           public void DeleteProductionCycle(ProductionCycle productionCycle)
           {

               try
               {
                   ProductionCycle productionCycleToDelete = ProductionCycles.SingleOrDefault(x => x.Id == productionCycle.Id);
                   ProductionCycles.Remove(productionCycleToDelete);
                   SaveChanges();
               }
               catch (Exception e)
               {
                   Error error = new Error("Unable to remove ProductionCycle from Database!",
                       ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                       DateTime.Now);
                   ErrorManager.AddError(error);
               }

            //ProductionCycle productioncycle = ProductionCycles.Find(productionCycle.Id);

            //if (productioncycle == null)
            //{
            //    // ERROR MANAGEMENT
            //}
            //else
            //{
            //    ProductionCycles.Remove(productioncycle);
            //    SaveChanges();
            //}
           }

           public ProductionCycle GetProductionCycle(int id)
           {
               try
               {
                   return ProductionCycles.SingleOrDefault<ProductionCycle>(x => x.Id == id);
               }
               catch (Exception e)
               {
                   Error error = new Error("Unable to fetch ProductionCycle from Database!",
                       ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                       DateTime.Now);
                   ErrorManager.AddError(error);
                   return null;
               }
           }


        /* GetAllRecipes() USECASE:
            to load All Recipes to choose from when adding a new ProductionCycle
         */
        public List<Recipe> GetAllRecipes()
        {
            var context = new RecipeManager();
            return context.GetRecipes();
        }

        public List<ProductionCycle> GetFinishedProductionCycles() // only for ProductionHistoryView
        {
            return ProductionCycles
                .Where(x => x.NumberOfProducts == x.FinishedProducts)
                .Include(e => e.Recipe)
                .ToList();
        }

        

           #endregion

    }

    
}
