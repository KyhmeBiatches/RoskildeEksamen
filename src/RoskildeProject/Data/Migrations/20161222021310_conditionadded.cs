using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RoskildeProject.Data.Migrations
{
    public partial class conditionadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conditions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conditions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "deliveryMethods",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    itemid = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deliveryMethods", x => x.id);
                    table.ForeignKey(
                        name: "FK_deliveryMethods_items_itemid",
                        column: x => x.itemid,
                        principalTable: "items",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "conditionid",
                table: "items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_items_conditionid",
                table: "items",
                column: "conditionid");

            migrationBuilder.CreateIndex(
                name: "IX_deliveryMethods_itemid",
                table: "deliveryMethods",
                column: "itemid");

            migrationBuilder.AddForeignKey(
                name: "FK_items_conditions_conditionid",
                table: "items",
                column: "conditionid",
                principalTable: "conditions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_conditions_conditionid",
                table: "items");

            migrationBuilder.DropIndex(
                name: "IX_items_conditionid",
                table: "items");

            migrationBuilder.DropColumn(
                name: "conditionid",
                table: "items");

            migrationBuilder.DropTable(
                name: "conditions");

            migrationBuilder.DropTable(
                name: "deliveryMethods");
        }
    }
}
