﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VerstaApi.Data;

#nullable disable

namespace VerstaApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240121184933_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VerstaApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressFrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("CargoWeight")
                        .HasColumnType("numeric");

                    b.Property<string>("CityFrom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CityTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("PickupDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
