using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class AdministrativeUnitForeignKeyNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId",
                table: "districts");

            migrationBuilder.RenameColumn(
                name: "AdministrativeUnitId",
                table: "districts",
                newName: "administrative_unit_id");

            migrationBuilder.RenameIndex(
                name: "IX_districts_AdministrativeUnitId",
                table: "districts",
                newName: "IX_districts_administrative_unit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_districts_administrative_units_administrative_unit_id",
                table: "districts",
                column: "administrative_unit_id",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_districts_administrative_units_administrative_unit_id",
                table: "districts");

            migrationBuilder.RenameColumn(
                name: "administrative_unit_id",
                table: "districts",
                newName: "AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_districts_administrative_unit_id",
                table: "districts",
                newName: "IX_districts_AdministrativeUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId",
                table: "districts",
                column: "AdministrativeUnitId",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
