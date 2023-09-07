using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagementProject.Migrations
{
    public partial class AddColumnDescrptioninModelBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrption",
                table: "books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrption",
                table: "books");
        }
    }
}
