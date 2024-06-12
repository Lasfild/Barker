using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class saleadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Availability",
                table: "Products",
                newName: "IsOnSale");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsAvailable", "IsOnSale" },
                values: new object[] { true, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsOnSale",
                table: "Products",
                newName: "Availability");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Availability",
                value: true);
        }
    }
}
