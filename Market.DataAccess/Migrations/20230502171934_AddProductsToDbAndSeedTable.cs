using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Market.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsToDbAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Tittle" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Nancy Hoover", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Dark Skies" },
                    { 3, "Julian Button", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Vanish in the Sunset" },
                    { 4, "Abby Muscles", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Cotton Candy" },
                    { 5, "Ron Parker", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Rock in the Ocean" },
                    { 6, "Laura Phantom", "Praesant vitae solades libero.", "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Leaves and Wonders" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
