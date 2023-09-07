using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagementProject.Migrations
{
    public partial class AddColumnImgeInModelBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "books");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "books");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImagePath",
                table: "books",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
