using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Img",
                value: "/img/category_img/barker_cat_anniv.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Ручна робота", "/img/category_img/barker_cat_handc.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img" },
                values: new object[] { "Потовщена підошва", "/img/category_img/barker_cat_country.jpg" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Img", "Name" },
                values: new object[,]
                {
                    { 4, "Сучасний дизайн", "/img/category_img/barker_cat_creative.jpg", "Creative" },
                    { 5, "Гнучкі та легкі", "/img/category_img/barker_cat_flex.jpg", "Barkerflex" },
                    { 6, "Класика поза часом", "/img/category_img/barker_cat_prof.jpg", "Professional" },
                    { 7, "Винятковий комфорт", "/img/category_img/mocc-category_2.jpg", "Moccasin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Img",
                value: "/img/barker_anniv_header16_1.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Img" },
                values: new object[] { "2", "/img/barker_anniv_header16_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Img" },
                values: new object[] { "3", "/img/barker_anniv_header16_1.jpg" });
        }
    }
}
