using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace SimpleSCADA_SharedResources
{
    public class DbCreationContext : DbContext
    {
        #region Members
        private DbSet<Recipe>? Recipes { get; set; }
        private DbSet<Station>? Stations { get; set; }
        private DbSet<Utility>? Utilities { get; set; }
        private DbSet<Log>? Logs { get; set; }
        private DbSet<ProductionCycle>? ProductionCycles { get; set; }
        private DbSet<Error>? Errors { get; set; }
        private DbSet<OEE>? OEEs { get; set; }
        private DbSet<User>? Users { get; set; }
        private DbSet<SensorData>? SensorDatas { get; set; }
        private DbSet<StationWithChosenUtility> RecipesStations { get; set; }
        private DbSet<Plant>? Plants { get; set; }



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

            modelBuilder.Entity<Recipe>().HasKey(b => b.Id);
            modelBuilder.Entity<Station>().HasKey(b => b.Id);
            modelBuilder.Entity<Utility>().HasKey(b => b.Id);
            modelBuilder.Entity<Log>().HasKey(b => b.Id);
            modelBuilder.Entity<ProductionCycle>().HasKey(b => b.Id); 
            modelBuilder.Entity<Error>().HasKey(b => b.Id);
            modelBuilder.Entity<User>().HasKey(b => b.Id);
            modelBuilder.Entity<SensorData>().HasKey(b => b.sensorName);
            modelBuilder.Entity<StationWithChosenUtility>().HasKey(b => b.Id);
            modelBuilder.Entity<Plant>().HasKey(b => b.Id);





            modelBuilder.Entity<Station>()
                .HasMany(e => e.Utilities)
                .WithMany(e => e.Stations);



            modelBuilder.Entity<ProductionCycle>()
                .HasOne(e => e.Recipe)
                .WithMany(e => e.ProductionCycles)
                .HasForeignKey(e => e.RecipeId);
                

            modelBuilder.Entity<Log>()
                .HasOne(e => e.ProductionCycle)
                .WithMany(e => e.Logs)
                .HasForeignKey(e => e.ProductionCycleId)
                .IsRequired(false);


            modelBuilder.Entity<Log>()
                .HasOne(e => e.Error)
                .WithOne(e => e.Log)
                .HasForeignKey<Error>(e => e.LogId)
                .IsRequired(false);


            modelBuilder.Entity<StationWithChosenUtility>()
                .HasOne(e => e.Station)
                .WithMany(e => e.ChosenUtilities)
                .HasForeignKey(e => e.StationId);

            modelBuilder.Entity<StationWithChosenUtility>()
                .HasOne(e => e.ChosenUtility)
                .WithMany(e => e.ChosenUtilites)
                .HasForeignKey(e => e.ChosenUtilityId);

            modelBuilder.Entity<StationWithChosenUtility>()
            .HasOne(e => e.Recipe)
            .WithMany(e => e.Stations)
            .HasForeignKey(rs => rs.RecipeId);

            modelBuilder.Entity<StationWithChosenUtility>()
           .HasOne(e => e.Station)
           .WithMany(e => e.ChosenUtilities)
           .HasForeignKey(e => e.StationId);

            modelBuilder.Entity<Plant>()
           .HasOne(e => e.ActiveProductionCycle)
           .WithOne(e => e.Plant)
           .HasForeignKey<Plant>(e => e.ActiveProductionCycleId);


            base.OnModelCreating(modelBuilder);
        }
        #endregion


        public static void setAllModelConnections(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasKey(b => b.Id);
            modelBuilder.Entity<Station>().HasKey(b => b.Id);
            modelBuilder.Entity<Utility>().HasKey(b => b.Id);
            modelBuilder.Entity<Log>().HasKey(b => b.Id);
            modelBuilder.Entity<ProductionCycle>().HasKey(b => b.Id);
            modelBuilder.Entity<Error>().HasKey(b => b.Id);
            modelBuilder.Entity<User>().HasKey(b => b.Id);
            modelBuilder.Entity<SensorData>().HasKey(b => b.sensorName);
            modelBuilder.Entity<StationWithChosenUtility>().HasKey(b => b.Id);
            modelBuilder.Entity<Plant>().HasKey(b => b.Id);




            modelBuilder.Entity<Recipe>().ToTable("Recipes");
            modelBuilder.Entity<Station>().ToTable("Stations");
            modelBuilder.Entity<Utility>().ToTable("Utilities");
            modelBuilder.Entity<Log>().ToTable("Logs");
            modelBuilder.Entity<ProductionCycle>().ToTable("ProductionCycles");
            modelBuilder.Entity<Error>().ToTable("Errors");
            modelBuilder.Entity<OEE>().ToTable("OEEs");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<SensorData>().ToTable("SensorDatas");
            modelBuilder.Entity<StationWithChosenUtility>().ToTable("RecipesStations");
            modelBuilder.Entity<Plant>().ToTable("Plants");





            modelBuilder.Entity<Station>()
                .HasMany(e => e.Utilities)
                .WithMany(e => e.Stations);



            modelBuilder.Entity<ProductionCycle>()
                .HasOne(e => e.Recipe)
                .WithMany(e => e.ProductionCycles)
                .HasForeignKey(e => e.RecipeId);


            modelBuilder.Entity<Log>()
                .HasOne(e => e.ProductionCycle)
                .WithMany(e => e.Logs)
                .HasForeignKey(e => e.ProductionCycleId)
                .IsRequired(false);

            modelBuilder.Entity<Log>()
                .HasOne(e => e.Error)
                .WithOne(e => e.Log)
                .HasForeignKey<Error>(e => e.LogId)
                .IsRequired(false);

            modelBuilder.Entity<StationWithChosenUtility>()
                .HasOne(e => e.Station)
                .WithMany(e => e.ChosenUtilities)
                .HasForeignKey(e => e.StationId);

            modelBuilder.Entity<StationWithChosenUtility>()
                .HasOne(e => e.ChosenUtility)
                .WithMany(e => e.ChosenUtilites)
                .HasForeignKey(e => e.ChosenUtilityId);

            modelBuilder.Entity<StationWithChosenUtility>()
            .HasOne(e => e.Recipe)
            .WithMany(e => e.Stations)
            .HasForeignKey(rs => rs.RecipeId);

            modelBuilder.Entity<StationWithChosenUtility>()
           .HasOne(e => e.Station)
           .WithMany(e => e.ChosenUtilities)
           .HasForeignKey(e => e.StationId);

            modelBuilder.Entity<Plant>()
           .HasOne(e => e.ActiveProductionCycle)
           .WithOne(e => e.Plant)
           .HasForeignKey<Plant>(e => e.ActiveProductionCycleId);
        }

    }
}
