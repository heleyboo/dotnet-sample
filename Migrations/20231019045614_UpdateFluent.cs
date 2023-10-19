using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFluent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId1",
                table: "districts");

            migrationBuilder.DropForeignKey(
                name: "FK_districts_provinces_ProvinceCode1",
                table: "districts");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_regions_AdministrativeRegionId1",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_units_AdministrativeUnitId1",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_administrative_units_AdministrativeUnitId1",
                table: "wards");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_districts_DistrictCode1",
                table: "wards");

            migrationBuilder.DropIndex(
                name: "IX_wards_AdministrativeUnitId1",
                table: "wards");

            migrationBuilder.DropIndex(
                name: "IX_wards_DistrictCode1",
                table: "wards");

            migrationBuilder.DropIndex(
                name: "IX_provinces_AdministrativeRegionId1",
                table: "provinces");

            migrationBuilder.DropIndex(
                name: "IX_provinces_AdministrativeUnitId1",
                table: "provinces");

            migrationBuilder.DropIndex(
                name: "IX_districts_AdministrativeUnitId1",
                table: "districts");

            migrationBuilder.DropIndex(
                name: "IX_districts_ProvinceCode1",
                table: "districts");

            migrationBuilder.DropColumn(
                name: "AdministrativeUnitId1",
                table: "wards");

            migrationBuilder.DropColumn(
                name: "DistrictCode1",
                table: "wards");

            migrationBuilder.DropColumn(
                name: "AdministrativeRegionId1",
                table: "provinces");

            migrationBuilder.DropColumn(
                name: "AdministrativeUnitId1",
                table: "provinces");

            migrationBuilder.DropColumn(
                name: "AdministrativeUnitId1",
                table: "districts");

            migrationBuilder.DropColumn(
                name: "ProvinceCode1",
                table: "districts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdministrativeUnitId1",
                table: "wards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DistrictCode1",
                table: "wards",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AdministrativeRegionId1",
                table: "provinces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdministrativeUnitId1",
                table: "provinces",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdministrativeUnitId1",
                table: "districts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceCode1",
                table: "districts",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_wards_AdministrativeUnitId1",
                table: "wards",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_wards_DistrictCode1",
                table: "wards",
                column: "DistrictCode1");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_AdministrativeRegionId1",
                table: "provinces",
                column: "AdministrativeRegionId1");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_AdministrativeUnitId1",
                table: "provinces",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_districts_AdministrativeUnitId1",
                table: "districts",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_districts_ProvinceCode1",
                table: "districts",
                column: "ProvinceCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId1",
                table: "districts",
                column: "AdministrativeUnitId1",
                principalTable: "administrative_units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_districts_provinces_ProvinceCode1",
                table: "districts",
                column: "ProvinceCode1",
                principalTable: "provinces",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_regions_AdministrativeRegionId1",
                table: "provinces",
                column: "AdministrativeRegionId1",
                principalTable: "administrative_regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_provinces_administrative_units_AdministrativeUnitId1",
                table: "provinces",
                column: "AdministrativeUnitId1",
                principalTable: "administrative_units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wards_administrative_units_AdministrativeUnitId1",
                table: "wards",
                column: "AdministrativeUnitId1",
                principalTable: "administrative_units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wards_districts_DistrictCode1",
                table: "wards",
                column: "DistrictCode1",
                principalTable: "districts",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
