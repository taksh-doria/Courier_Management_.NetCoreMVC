﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Courier_Management_System.Migrations.Details
{
    [DbContext(typeof(DetailsContext))]
    partial class DetailsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Courier_Management_System.Models.Consignment_Details", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Consignee_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<float>("amount")
                        .HasColumnType("REAL");

                    b.Property<long>("consignment_no")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("destination_city")
                        .HasColumnType("TEXT");

                    b.Property<string>("package_content")
                        .HasColumnType("TEXT");

                    b.Property<string>("package_type")
                        .HasColumnType("TEXT");

                    b.Property<float>("pkg_weight_in_grams")
                        .HasColumnType("REAL");

                    b.Property<string>("user")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Consignment_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
