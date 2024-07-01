using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Utilities;
using System.Threading;

namespace SimpleSCADA_SharedResources
{
    public class LogManager : DbContext
    {
        #region Properties
        private DbSet<Log>? Logs { get; set; }
        #endregion

        #region Constructor
        public LogManager()
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
        public List<Log> FilterLog(DateTime fromDateTime, DateTime tilDateTime)
        { 
            List<Log> logs = Logs.OrderByDescending(x => x.Starttime).ToList();
            List<Log> filteredLogs = logs.FindAll(i => i.Starttime >= fromDateTime
                                                     && i.Starttime <= tilDateTime);
            return filteredLogs.OrderByDescending(x => x.Starttime).ToList();
        }

        public void AddLog(Log log)
        {
            Logs.Add(log);
            SaveChanges();
        }

        public List<Log> GetAllLogs()
        {
            return Logs
                .Include(e => e.ProductionCycle)
                .Include(e => e.Error)
                .ToList();

        }

        public static Log CreateLog(string description)
        {
            PlantManager plantmanager = new PlantManager();

            Plant plant = plantmanager.GetPlant();
            ProductionCycle activeProductionCycle = plant.ActiveProductionCycle;

            
            if (activeProductionCycle != null)
            {
                return new Log(activeProductionCycle.Id,description, DateTime.Now, plant.ActualPlantState);
            } else
            {
                return new Log(description, DateTime.Now, plant.ActualPlantState);
            }
            
        }
        #endregion
    }
}
