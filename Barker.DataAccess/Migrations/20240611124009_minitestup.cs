using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barker.Migrations
{
    /// <inheritdoc />
    public partial class minitestup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 1);
        }
    }
}
