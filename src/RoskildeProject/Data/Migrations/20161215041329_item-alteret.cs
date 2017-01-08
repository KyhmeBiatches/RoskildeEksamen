using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoskildeProject.Data.Migrations
{
    public partial class itemalteret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "items");

            migrationBuilder.AddColumn<string>(
                name: "titel",
                table: "items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "titel",
                table: "items");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "items",
                nullable: true);
        }
    }
}
