using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SimpleSCADA_SharedResources;

namespace SimpleSCADA_SharedResources
{
    public class ErrorManager : DbContext
    {
        #region Properties
        private DbSet<Error> Errors { get; set; } 
        #endregion

        #region Constructor

        public ErrorManager()
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

        #region Methods
        // BL: Noch wos gehören de gefiltert!
        public List<Error> FilterErrors()
        {
            return Errors.ToList<Error>(); //dummy
        }
        
        public static void AddError(Error error)
        {

            ErrorManager errormanager = new ErrorManager();

            error.Log = LogManager.CreateLog("Error in " + error.ErrorType.ToString());

            errormanager.Errors.Add(error);
            errormanager.SaveChanges();
           
        }

        public List<Error> GetAllErrors()
        {

            return Errors
                .Include(e => e.Log)
                .ToList();
          
        }


        #endregion
    }
}
