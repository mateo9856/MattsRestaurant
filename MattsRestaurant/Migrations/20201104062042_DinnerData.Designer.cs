﻿// <auto-generated />
using MattsRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MattsRestaurant.Migrations
{
    [DbContext(typeof(DinnerDbContext))]
    [Migration("20201104062042_DinnerData")]
    partial class DinnerData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MattsRestaurant.Models.Dinner", b =>
                {
                    b.Property<int>("DinnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CuisineType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DinnerCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DinnerOfTheDay")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("DinnerId");

                    b.ToTable("dinners");

                    b.HasData(
                        new
                        {
                            DinnerId = 1,
                            Allergens = "Gluten, Eggs, Lactose, Soybeans",
                            CuisineType = 0,
                            Description = "Type of pizza with ham, mushroom and tomatos",
                            DinnerCategory = "FastFood",
                            DinnerOfTheDay = false,
                            ImageUrl = "",
                            Name = "Pizza Capriciosa",
                            Price = 19.199999999999999
                        },
                        new
                        {
                            DinnerId = 2,
                            Allergens = "Gluten, Lactose",
                            CuisineType = 4,
                            Description = "A long piece of wood or metal used for holding pieces of food, typically meat, together during cooking",
                            DinnerCategory = "Barbeque foods",
                            DinnerOfTheDay = false,
                            ImageUrl = "",
                            Name = "Skewers",
                            Price = 10.0
                        },
                        new
                        {
                            DinnerId = 3,
                            Allergens = "Gluten, Lactose, Soyabeans, Eggs",
                            CuisineType = 1,
                            Description = @"Sticky dough with stuffing inside.
Types: Russia, With meat, sweets, with blueberries, with spinach",
                            DinnerCategory = "Cake Dinner",
                            DinnerOfTheDay = true,
                            ImageUrl = "",
                            Name = "Dumplings",
                            Price = 9.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
