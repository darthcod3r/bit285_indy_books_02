﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndyBooks.Migrations
{
    public partial class writerbio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Writers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Writers");
        }
    }
}
