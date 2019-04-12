﻿// <auto-generated />
using CocktailCookbook.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CocktailCookbook.Api.Migrations
{
    [DbContext(typeof(DrinksContext))]
    [Migration("20190412175740_testingdrinks1")]
    partial class testingdrinks1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CocktailCookbook.Models.Drinks", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("image");

                    b.Property<string>("name");

                    b.Property<string>("recipe");

                    b.Property<string>("type");

                    b.HasKey("id");

                    b.ToTable("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
