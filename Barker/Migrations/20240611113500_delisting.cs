using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class delisting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "anniversary");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Img",
                value: "/img/product_Img/Lerwick-431527_AntiqueRosewood_1080x");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Anniversary");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Img",
                value: "[\"/img/product_img/Lerwick-431527_AntiqueRosewood_1080x\",\"/img/product_img/Lerwick_431527_AntiqueRosewoodCalf_side_1024x6002x\",\"/img/product_img/Lerwick_431527_AntiqueRosewood_top_1024x6002x\",\"/img/product_img/Rochester_380417_7mm_Leather_464Last_1024x6002x\"]");
        }
    }
}
