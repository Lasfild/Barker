using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class productadded : Migration
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
                    VendorCode = table.Column<int>(type: "int", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shoe = table.Column<int>(type: "int", nullable: false),
                    Fullness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoleMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Availability", "Color", "Country", "Description", "Fullness", "Img", "Name", "Shoe", "Size", "Sole", "SoleMethod", "Style", "TopMaterial", "VendorCode" },
                values: new object[] { 1, true, "чорний", "Англія", "Класичні оксфорди з натуральної шкіри, ручної роботи.", "G", "[\"/img/product_img/Lerwick-431527_AntiqueRosewood_1080x\",\"/img/product_img/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x\",\"/img/product_img/Lerwick_431527_AntiqueRosewood_top_1024x6002x\",\"/img/product_img/Rochester_380417_7mm_Leather_464Last_1024x6002x\"]", "LERWICK ANTIQUE ROSEWOOD", 464, "[6,8.5,9]", "шкіра", "рантовий", "оксфорд", "Натуральна шкіра", 431527 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
