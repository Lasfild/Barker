using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class _3productsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "CategoryId", "Color", "Description", "Img", "Name", "Price" },
                values: new object[] { false, 2, "ROSEWOOD", "Колекція Handcrafted - це вершина майстерності англійських майстрів фабрики Barker. Історичний текст, вигравіюваний на шкіряній підошві - це дуже вишукано! Відрізний носок з перфорацією та довгий вінгтіп посилює враження.", "[\"/img/product_Img/AntiqueRosewood/Lerwick-431527_AntiqueRosewood_1080x.png\",\"/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x.png\",\"/img/product_img/AntiqueRosewood/Lerwick_431527_AntiqueRosewood_top_1024x6002x.png\",\"/img/product_img/AntiqueRosewood/Rochester_380417_7mm_Leather_464Last_1024x6002x.png\"]", "Lerwick Antique Rosewood", 21400m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Availability", "CategoryId", "Color", "Country", "Description", "Fullness", "Img", "Name", "Price", "Shoe", "Size", "Sole", "SoleMethod", "Style", "TopMaterial", "VendorCode" },
                values: new object[,]
                {
                    { 2, true, 1, "ROSEWOOD", "Англія", "Бездоганні оксфорди із одного цільного шматка шкіри, ручна робота, Goodyear welted, дизайн та виробництво - Англія. Ювілейна колекція. В наявності і в чорному кольорі.", "FX", "[\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf.png\",\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_side.png\",\"/img/product_Img/AlderneyRosewood/alderney_322026_rosewoodcalf_top.png\",\"/img/product_Img/AlderneyRosewood/alderney_3220_handcrafted_7mm_leather_396_last.png\"]", "Alderney-Rosewood", 21400m, 396, "[9,10,12]", "шкіра", "рантовий", "оксфорд", "Натуральна шкіра", 322026 },
                    { 3, true, 2, "BLACK", "Англія", "Класичні оксфорди з перфорацією на носку. Комбінація гладкої та зернистої телячої шкіри. Будуть стильним доповненням вашого формального костюма.", "G", "[\"/img/product_Img/FloreBlack/flore_blackcalfgrain_angle_1.png\",\"/img/product_img/FloreBlack/flore_blackcalfgrain_side.png\",\"/img/product_img/FloreBlack/flore_blackcalf_top.png\",\"/img/product_img/FloreBlack/warrington_392737_last464_script-sole_3_2.png\"]", "Flore Black", 17000m, 464, "[9,10,11]", "Шкіра", "Рантовий", "Оксфорд", "Натуральна шкіра", 411917 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Availability", "CategoryId", "Color", "Description", "Img", "Name" },
                values: new object[] { true, 1, "чорний", "Класичні оксфорди з натуральної шкіри, ручної роботи.", "[\"/img/product_Img/Lerwick-431527_AntiqueRosewood_1080x.png\",\"/img/product_img/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x.png\",\"/img/product_img/Lerwick_431527_AntiqueRosewood_top_1024x6002x.png\",\"/img/product_img/Rochester_380417_7mm_Leather_464Last_1024x6002x.png\"]", "LERWICK ANTIQUE ROSEWOOD" });
        }
    }
}
