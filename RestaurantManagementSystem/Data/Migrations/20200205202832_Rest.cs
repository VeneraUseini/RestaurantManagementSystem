using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RestaurantManagementSystem.Data.Migrations
{
    public partial class Rest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurants_CategoryId",
                table: "MenuItem");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "MenuItem",
                newName: "RestaurantId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_CategoryId",
                table: "MenuItem",
                newName: "IX_MenuItem_RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantId",
                table: "MenuItem",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurants_RestaurantId",
                table: "MenuItem");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "MenuItem",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItem_RestaurantId",
                table: "MenuItem",
                newName: "IX_MenuItem_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurants_CategoryId",
                table: "MenuItem",
                column: "CategoryId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
