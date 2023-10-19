using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "administrative_units",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "administrative_regions",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "administrative_units",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "administrative_regions",
                newName: "Id");
        }
    }
}
