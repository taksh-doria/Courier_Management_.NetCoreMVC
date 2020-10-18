﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Courier_Management_System.Migrations.City
{
    [DbContext(typeof(CityContext))]
    [Migration("20201018161136_CityMigration")]
    partial class CityMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Courier_Management_System.Models.City", b =>
                {
                    b.Property<string>("city_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("branch_address")
                        .HasColumnType("TEXT");

                    b.Property<short>("city_pincode")
                        .HasColumnType("INTEGER");

                    b.HasKey("city_name");

                    b.ToTable("City");
                });
#pragma warning restore 612, 618
        }
    }
}
