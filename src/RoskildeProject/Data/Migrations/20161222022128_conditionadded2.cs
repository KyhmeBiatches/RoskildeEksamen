using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoskildeProject.Data.Migrations
{
    public partial class conditionadded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMethods_items_itemid",
                table: "deliveryMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMethods_items_Itemid",
                table: "deliveryMethods",
                column: "itemid",
                principalTable: "items",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "itemid",
                table: "deliveryMethods",
                newName: "Itemid");

            migrationBuilder.RenameIndex(
                name: "IX_deliveryMethods_itemid",
                table: "deliveryMethods",
                newName: "IX_deliveryMethods_Itemid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_deliveryMethods_items_Itemid",
                table: "deliveryMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_deliveryMethods_items_itemid",
                table: "deliveryMethods",
                column: "Itemid",
                principalTable: "items",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "Itemid",
                table: "deliveryMethods",
                newName: "itemid");

            migrationBuilder.RenameIndex(
                name: "IX_deliveryMethods_Itemid",
                table: "deliveryMethods",
                newName: "IX_deliveryMethods_itemid");
        }
    }
}
