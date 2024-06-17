using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class addcategorykey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Country", "Description", "Fullness", "Img", "IsAvailable", "IsOnSale", "Name", "Price", "Shoe", "Size", "Sole", "SoleMethod", "Style", "TopMaterial", "VendorCode" },
                values: new object[] { 4, 2, "BLACK", "Англія", "Класичні оксфорди з перфорацією на носку. Комбінація гладкої та зернистої телячої шкіри. Будуть стильним доповненням вашого формального костюма.", "G", "[\"/img/product_Img/FloreBlack/flore_blackcalfgrain_angle_1.png\",\"/img/product_img/FloreBlack/flore_blackcalfgrain_side.png\",\"/img/product_img/FloreBlack/flore_blackcalf_top.png\",\"/img/product_img/FloreBlack/warrington_392737_last464_script-sole_3_2.png\"]", true, false, "Flore Black1", 18000m, 464, "[9,10,11]", "Шкіра", "Рантовий", "Оксфорд", "Натуральна шкіра", 411918 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
