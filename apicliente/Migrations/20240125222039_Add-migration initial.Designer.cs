﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apicliente.Context;

#nullable disable

namespace apicliente.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240125222039_Add-migration initial")]
    partial class Addmigrationinitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("apicliente.Models.Clientes", b =>
                {
                    b.Property<string>("Rut")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Rut");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
