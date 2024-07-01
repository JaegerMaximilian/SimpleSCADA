using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleSCADA_SharedResources;
using Microsoft.EntityFrameworkCore;


namespace SimpleSCADA_SharedResources
{
    public class OEEManager : DbContext
    {
        #region Properties
        public DbSet<OEE>? OEEs { get; set; }
        public LogManager LogManager { get; private set; } // LogManager für Zugriff zur Datenbank auf DbSet "Logs"
        #endregion

        #region Constructor
        /*public OEEManager(List<OEE> oees, LogManager logManager)
        {
            OEEs = oees;
            LogManager = logManager;
        }
        */
        public OEEManager() { }
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

        public int CalculateOEE()
        {
            double sum = 0d;
            var oeeList = GetOEEfromWeek();
            oeeList.ForEach(item =>
            {
                sum += item.Leistungseffizienz; 
            });
            double avg = sum / oeeList.Count;
            return Convert.ToInt32(avg);
        }

        public OEE GetLatestOEE()
        {
            OEE lastestOee = OEEs.OrderByDescending(o => o.Date).FirstOrDefault();
          
            
            return lastestOee;
        }

        public List<OEE> GetOEEfromWeek()
        {
            try
            {
                return OEEs.OrderByDescending(o => o.Date).Take<OEE>(7).ToList<OEE>();
            }
            catch (Exception e)
            {
                Error error = new Error("Unable to fetch OEE from Database!",
                    ErrorType.DATABASE, ErrorSeverity.CRITICAL,
                    DateTime.Now);
                ErrorManager.AddError(error);
                return null;
            }


        }
        #endregion
    }
}
