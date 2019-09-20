﻿// <auto-generated />
using System;
using Challenge_3_Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Challenge_3_Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Challenge_3_Web.Models.RowData", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AcoSMV");

                    b.Property<int>("Activity");

                    b.Property<int>("GroupNumber");

                    b.Property<double>("GyroSMV");

                    b.Property<double>("LinAcoSMV");

                    b.Property<int>("Pred");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<double>("xAco");

                    b.Property<double>("xGyro");

                    b.Property<double>("xLinAco");

                    b.Property<double>("xMag");

                    b.Property<double>("yAco");

                    b.Property<double>("yGyro");

                    b.Property<double>("yLinAco");

                    b.Property<double>("yMag");

                    b.Property<double>("zAco");

                    b.Property<double>("zGyro");

                    b.Property<double>("zLinAco");

                    b.Property<double>("zMag");

                    b.HasKey("Id");

                    b.ToTable("RowData");
                });

            modelBuilder.Entity("Challenge_3_Web.Models.Window", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Activity");

                    b.Property<double>("MaxAcoSMV");

                    b.Property<double>("MaxGyroSMV");

                    b.Property<double>("MaxLinAcoSMV");

                    b.Property<double>("MeanAcoSMV");

                    b.Property<double>("MeanGyroSMV");

                    b.Property<double>("MeanLinAcoSMV");

                    b.Property<double>("MinAcoSMV");

                    b.Property<double>("MinGyroSMV");

                    b.Property<double>("MinLinAcoSMV");

                    b.Property<double>("ModeAcoSMV");

                    b.Property<double>("ModeGyroSMV");

                    b.Property<double>("ModeLinAcoSMV");

                    b.Property<double>("StdAcoSMV");

                    b.Property<double>("StdGyroSMV");

                    b.Property<double>("StdLinAcoSMV");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("Windows");
                });
#pragma warning restore 612, 618
        }
    }
}
