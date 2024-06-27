using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class vendorcodestring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryModelId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryModelId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "VendorCode",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "VendorCode",
                value: "431527");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "VendorCode",
                value: "322026");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "VendorCode",
                value: "411917");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "VendorCode",
                value: "411918");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "VendorCode",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryModelId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryModelId", "VendorCode" },
                values: new object[] { null, 431527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryModelId", "VendorCode" },
                values: new object[] { null, 322026 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryModelId", "VendorCode" },
                values: new object[] { null, 411917 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryModelId", "VendorCode" },
                values: new object[] { null, 411918 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryModelId",
                table: "Products",
                column: "CategoryModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryModelId",
                table: "Products",
                column: "CategoryModelId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
