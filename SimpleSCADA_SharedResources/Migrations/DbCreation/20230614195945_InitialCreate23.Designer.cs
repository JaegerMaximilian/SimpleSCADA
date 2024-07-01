﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleSCADA_SharedResources;

#nullable disable

namespace SimpleSCADA_SharedResources.Migrations.DbCreation
{
    [DbContext(typeof(DbCreationContext))]
    [Migration("20230614195945_InitialCreate23")]
    partial class InitialCreate23
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("SimpleSCADA_SharedResources.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ErrorType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LogId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Severity")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeOfOccurence")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeWhenFixed")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LogId")
                        .IsUnique();

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlantState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductionCycleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Starttime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductionCycleId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.OEE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Availability")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("Leistungseffizienz")
                        .HasColumnType("REAL");

                    b.Property<double>("QualityRate")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("OEEs");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActiveProductionCycleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActualPlantState")
                        .HasColumnType("INTEGER");

                    b.Property<int>("requestedPlantState")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ActiveProductionCycleId")
                        .IsUnique();

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.ProductionCycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("EstimatedTime")
                        .HasColumnType("REAL");

                    b.Property<int>("FinishedProducts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfProducts")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("ProductionCycles");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.SensorData", b =>
                {
                    b.Property<string>("sensorName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("sensorState")
                        .HasColumnType("INTEGER");

                    b.HasKey("sensorName");

                    b.ToTable("SensorDatas");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.StationWithChosenUtility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChosenUtilityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChosenUtilityId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("StationId");

                    b.ToTable("RecipesStations");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Prename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Utility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SecondsToWait")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Utilities");
                });

            modelBuilder.Entity("StationUtility", b =>
                {
                    b.Property<int>("StationsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UtilitiesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StationsId", "UtilitiesId");

                    b.HasIndex("UtilitiesId");

                    b.ToTable("StationUtility");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Error", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.Log", "Log")
                        .WithOne("Error")
                        .HasForeignKey("SimpleSCADA_SharedResources.Error", "LogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Log");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Log", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.ProductionCycle", "ProductionCycle")
                        .WithMany("Logs")
                        .HasForeignKey("ProductionCycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductionCycle");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Plant", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.ProductionCycle", "ActiveProductionCycle")
                        .WithOne("Plant")
                        .HasForeignKey("SimpleSCADA_SharedResources.Plant", "ActiveProductionCycleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActiveProductionCycle");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.ProductionCycle", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.Recipe", "Recipe")
                        .WithMany("ProductionCycles")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.StationWithChosenUtility", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.Utility", "ChosenUtility")
                        .WithMany("ChosenUtilites")
                        .HasForeignKey("ChosenUtilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleSCADA_SharedResources.Recipe", "Recipe")
                        .WithMany("Stations")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleSCADA_SharedResources.Station", "Station")
                        .WithMany("ChosenUtilities")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChosenUtility");

                    b.Navigation("Recipe");

                    b.Navigation("Station");
                });

            modelBuilder.Entity("StationUtility", b =>
                {
                    b.HasOne("SimpleSCADA_SharedResources.Station", null)
                        .WithMany()
                        .HasForeignKey("StationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleSCADA_SharedResources.Utility", null)
                        .WithMany()
                        .HasForeignKey("UtilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Log", b =>
                {
                    b.Navigation("Error");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.ProductionCycle", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Recipe", b =>
                {
                    b.Navigation("ProductionCycles");

                    b.Navigation("Stations");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Station", b =>
                {
                    b.Navigation("ChosenUtilities");
                });

            modelBuilder.Entity("SimpleSCADA_SharedResources.Utility", b =>
                {
                    b.Navigation("ChosenUtilites");
                });
#pragma warning restore 612, 618
        }
    }
}
