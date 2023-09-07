using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagementProject.Migrations
{
    public partial class EditInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "customersBooks");

            migrationBuilder.DropColumn(
                name: "evaluation",
                table: "books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "customersBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "evaluation",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
