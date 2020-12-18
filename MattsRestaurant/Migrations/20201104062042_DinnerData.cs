﻿using Microsoft.EntityFrameworkCore.Migrations;  namespace MattsRestaurant.Migrations {     public partial class DinnerData : Migration     {         protected override void Up(MigrationBuilder migrationBuilder)         {             migrationBuilder.InsertData(                 table: "dinners",                 columns: new[] { "DinnerId", "Allergens", "CuisineType", "Description", "DinnerCategory", "DinnerOfTheDay", "ImageUrl", "Name", "Price" },                 values: new object[] { 1, "Gluten, Eggs, Lactose, Soybeans", 0, "Type of pizza with ham, mushroom and tomatos", "FastFood", false, "", "Pizza Capriciosa", 19.199999999999999 });              migrationBuilder.InsertData(                 table: "dinners",                 columns: new[] { "DinnerId", "Allergens", "CuisineType", "Description", "DinnerCategory", "DinnerOfTheDay", "ImageUrl", "Name", "Price" },                 values: new object[] { 2, "Gluten, Lactose", 4, "A long piece of wood or metal used for holding pieces of food, typically meat, together during cooking", "Barbeque foods", false, "", "Skewers", 10.0 });              migrationBuilder.InsertData(                 table: "dinners",                 columns: new[] { "DinnerId", "Allergens", "CuisineType", "Description", "DinnerCategory", "DinnerOfTheDay", "ImageUrl", "Name", "Price" },                 values: new object[] { 3, "Gluten, Lactose, Soyabeans, Eggs", 1, @"Sticky dough with stuffing inside.Types: Russia, With meat, sweets, with blueberries, with spinach", "Cake Dinner", true, "", "Dumplings", 9.0 });         }          protected override void Down(MigrationBuilder migrationBuilder)         {             migrationBuilder.DeleteData(                 table: "dinners",                 keyColumn: "DinnerId",                 keyValue: 1);              migrationBuilder.DeleteData(                 table: "dinners",                 keyColumn: "DinnerId",                 keyValue: 2);              migrationBuilder.DeleteData(                 table: "dinners",                 keyColumn: "DinnerId",                 keyValue: 3);         }     } } 