using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MattsRestaurant.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 40, nullable: false),
                    LastName = table.Column<string>(maxLength: 40, nullable: false),
                    timeToPlaced = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 120, nullable: false),
                    City = table.Column<string>(maxLength: 40, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 12, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    OrderTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "shoppingCarts",
                columns: table => new
                {
                    cartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DinnerId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    cartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shoppingCarts", x => x.cartItemId);
                    table.ForeignKey(
                        name: "FK_shoppingCarts_dinners_DinnerId",
                        column: x => x.DinnerId,
                        principalTable: "dinners",
                        principalColumn: "DinnerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DinnerId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_dinners_DinnerId",
                        column: x => x.DinnerId,
                        principalTable: "dinners",
                        principalColumn: "DinnerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DinnerId",
                table: "OrderDetails",
                column: "DinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_shoppingCarts_DinnerId",
                table: "shoppingCarts",
                column: "DinnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "shoppingCarts");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
