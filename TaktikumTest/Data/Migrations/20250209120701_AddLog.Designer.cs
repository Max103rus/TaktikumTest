﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaktikumTest.Data;

#nullable disable

namespace TaktikumTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250209120701_AddLog")]
    partial class AddLog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("TaktikumTest.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("TaktikumTest.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RequestMethod")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RequestTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RequestUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResponseStatusCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
