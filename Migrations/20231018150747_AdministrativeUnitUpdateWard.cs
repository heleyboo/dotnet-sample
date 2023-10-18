using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class AdministrativeUnitUpdateWard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wards_administrative_units_AdministrativeUnitId",
                table: "wards");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "wards",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "wards",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "wards",
                newName: "name_en");

            migrationBuilder.RenameColumn(
                name: "FullNameEn",
                table: "wards",
                newName: "full_name_en");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "wards",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "wards",
                newName: "code_name");

            migrationBuilder.RenameColumn(
                name: "AdministrativeUnitId",
                table: "wards",
                newName: "administrative_unit_id");

            migrationBuilder.RenameIndex(
                name: "IX_wards_AdministrativeUnitId",
                table: "wards",
                newName: "IX_wards_administrative_unit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_wards_administrative_units_administrative_unit_id",
                table: "wards",
                column: "administrative_unit_id",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wards_administrative_units_administrative_unit_id",
                table: "wards");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "wards",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "wards",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "name_en",
                table: "wards",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "full_name_en",
                table: "wards",
                newName: "FullNameEn");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "wards",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "code_name",
                table: "wards",
                newName: "CodeName");

            migrationBuilder.RenameColumn(
                name: "administrative_unit_id",
                table: "wards",
                newName: "AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_wards_administrative_unit_id",
                table: "wards",
                newName: "IX_wards_AdministrativeUnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_wards_administrative_units_AdministrativeUnitId",
                table: "wards",
                column: "AdministrativeUnitId",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
