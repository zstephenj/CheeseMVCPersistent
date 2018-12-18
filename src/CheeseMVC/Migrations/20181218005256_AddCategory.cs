using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Cheeses",
                newName: "CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "CheeseCategoryID",
                table: "Cheeses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheeses_Categories_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cheeses_Categories_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropColumn(
                name: "CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Cheeses",
                newName: "Type");
        }
    }
}
