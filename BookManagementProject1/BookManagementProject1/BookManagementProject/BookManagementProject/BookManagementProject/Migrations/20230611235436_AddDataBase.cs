using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManagementProject.Migrations
{
    public partial class AddDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authers",
                columns: table => new
                {
                    AutherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutherName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authers", x => x.AutherId);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorieName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    evaluation = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false),
                    AutherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_books_authers_AutherId",
                        column: x => x.AutherId,
                        principalTable: "authers",
                        principalColumn: "AutherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "categories",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "customersBooks",
                columns: table => new
                {
                    CustomersBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    NumberOfBook = table.Column<int>(nullable: false),
                    dateTime = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customersBooks", x => x.CustomersBookId);
                    table.ForeignKey(
                        name: "FK_customersBooks_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customersBooks_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_AutherId",
                table: "books",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_books_CategorieId",
                table: "books",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_customersBooks_BookId",
                table: "customersBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_customersBooks_CustomerId",
                table: "customersBooks",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customersBooks");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "authers");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
