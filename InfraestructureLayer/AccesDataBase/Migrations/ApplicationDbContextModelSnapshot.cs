﻿// <auto-generated />
using System;
using AccesDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AccesDataBase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RecepcionMercancia.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ProductoID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductoID"));

                    b.Property<string>("CodigoProducto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("CodigoProducto");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Descripcion");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("FechaActualizacion");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("FechaCreacion");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("NombreProducto");

                    b.Property<string>("UnidadMedida")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("UnidadMedida");

                    b.HasKey("ProductoID");

                    b.ToTable("Producto", "RecepcionMercancia");
                });
#pragma warning restore 612, 618
        }
    }
}