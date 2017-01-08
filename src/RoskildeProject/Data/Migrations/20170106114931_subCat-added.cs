using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoskildeProject.Data.Migrations
{
    public partial class subCatadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "subCategoryid",
                table: "items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_items_subCategoryid",
                table: "items",
                column: "subCategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_items_subCategories_subCategoryid",
                table: "items",
                column: "subCategoryid",
                principalTable: "subCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_subCategories_subCategoryid",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_subCategoryid",
                table: "items");

            migrationBuilder.DropColumn(
                name: "subCategoryid",
                table: "items");
        }
    }
}
