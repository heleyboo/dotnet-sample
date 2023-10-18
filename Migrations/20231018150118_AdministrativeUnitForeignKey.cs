using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class AdministrativeUnitForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_regions_AdministrativeRegionId",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_units_AdministrativeUnitId",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_districts_DistrictCode",
                table: "wards");

            migrationBuilder.RenameColumn(
                name: "DistrictCode",
                table: "wards",
                newName: "district_code");

            migrationBuilder.RenameIndex(
                name: "IX_wards_DistrictCode",
                table: "wards",
                newName: "IX_wards_district_code");

            migrationBuilder.RenameColumn(
                name: "AdministrativeUnitId",
                table: "provinces",
                newName: "administrative_unit_id");

            migrationBuilder.RenameColumn(
                name: "AdministrativeRegionId",
                table: "provinces",
                newName: "administrative_region_id");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_AdministrativeUnitId",
                table: "provinces",
                newName: "IX_provinces_administrative_unit_id");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_AdministrativeRegionId",
                table: "provinces",
                newName: "IX_provinces_administrative_region_id");

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_regions_administrative_region_id",
                table: "provinces",
                column: "administrative_region_id",
                principalTable: "administrative_regions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_units_administrative_unit_id",
                table: "provinces",
                column: "administrative_unit_id",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wards_districts_district_code",
                table: "wards",
                column: "district_code",
                principalTable: "districts",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_regions_administrative_region_id",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_units_administrative_unit_id",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_districts_district_code",
                table: "wards");

            migrationBuilder.RenameColumn(
                name: "district_code",
                table: "wards",
                newName: "DistrictCode");

            migrationBuilder.RenameIndex(
                name: "IX_wards_district_code",
                table: "wards",
                newName: "IX_wards_DistrictCode");

            migrationBuilder.RenameColumn(
                name: "administrative_unit_id",
                table: "provinces",
                newName: "AdministrativeUnitId");

            migrationBuilder.RenameColumn(
                name: "administrative_region_id",
                table: "provinces",
                newName: "AdministrativeRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_administrative_unit_id",
                table: "provinces",
                newName: "IX_provinces_AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_administrative_region_id",
                table: "provinces",
                newName: "IX_provinces_AdministrativeRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_regions_AdministrativeRegionId",
                table: "provinces",
                column: "AdministrativeRegionId",
                principalTable: "administrative_regions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_units_AdministrativeUnitId",
                table: "provinces",
                column: "AdministrativeUnitId",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wards_districts_DistrictCode",
                table: "wards",
                column: "DistrictCode",
                principalTable: "districts",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
