using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class AdministrativeUnitUpdateColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_AdministrativeUnits_AdministrativeUnitId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Provinces_ProvinceCode",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_AdministrativeRegions_AdministrativeRegionId",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_AdministrativeUnits_AdministrativeUnitId",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_AdministrativeUnits_AdministrativeUnitId",
                table: "Wards");

            migrationBuilder.DropForeignKey(
                name: "FK_Wards_Districts_DistrictCode",
                table: "Wards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wards",
                table: "Wards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Districts",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdministrativeUnits",
                table: "AdministrativeUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdministrativeRegions",
                table: "AdministrativeRegions");

            migrationBuilder.RenameTable(
                name: "Wards",
                newName: "wards");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "provinces");

            migrationBuilder.RenameTable(
                name: "Districts",
                newName: "districts");

            migrationBuilder.RenameTable(
                name: "AdministrativeUnits",
                newName: "administrative_units");

            migrationBuilder.RenameTable(
                name: "AdministrativeRegions",
                newName: "administrative_regions");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_DistrictCode",
                table: "wards",
                newName: "IX_wards_DistrictCode");

            migrationBuilder.RenameIndex(
                name: "IX_Wards_AdministrativeUnitId",
                table: "wards",
                newName: "IX_wards_AdministrativeUnitId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "provinces",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "provinces",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "provinces",
                newName: "name_en");

            migrationBuilder.RenameColumn(
                name: "FullNameEn",
                table: "provinces",
                newName: "full_name_en");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "provinces",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "provinces",
                newName: "code_name");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_AdministrativeUnitId",
                table: "provinces",
                newName: "IX_provinces_AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_AdministrativeRegionId",
                table: "provinces",
                newName: "IX_provinces_AdministrativeRegionId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "districts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "districts",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "ProvinceCode",
                table: "districts",
                newName: "province_code");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "districts",
                newName: "name_en");

            migrationBuilder.RenameColumn(
                name: "FullNameEn",
                table: "districts",
                newName: "full_name_en");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "districts",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "districts",
                newName: "code_name");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_AdministrativeUnitId",
                table: "districts",
                newName: "IX_districts_AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_ProvinceCode",
                table: "districts",
                newName: "IX_districts_province_code");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "administrative_units",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ShortNameEn",
                table: "administrative_units",
                newName: "short_name_en");

            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "administrative_units",
                newName: "short_name");

            migrationBuilder.RenameColumn(
                name: "FullNameEn",
                table: "administrative_units",
                newName: "full_name_en");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "administrative_units",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "CodeNameEn",
                table: "administrative_units",
                newName: "code_name_en");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "administrative_units",
                newName: "code_name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "administrative_regions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "administrative_regions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "administrative_regions",
                newName: "name_en");

            migrationBuilder.RenameColumn(
                name: "CodeNameEn",
                table: "administrative_regions",
                newName: "code_name_en");

            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "administrative_regions",
                newName: "code_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wards",
                table: "wards",
                column: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provinces",
                table: "provinces",
                column: "code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_districts",
                table: "districts",
                column: "code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_administrative_units",
                table: "administrative_units",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_administrative_regions",
                table: "administrative_regions",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId",
                table: "districts",
                column: "AdministrativeUnitId",
                principalTable: "administrative_units",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_districts_provinces_province_code",
                table: "districts",
                column: "province_code",
                principalTable: "provinces",
                principalColumn: "code",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_wards_administrative_units_AdministrativeUnitId",
                table: "wards",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_districts_administrative_units_AdministrativeUnitId",
                table: "districts");

            migrationBuilder.DropForeignKey(
                name: "FK_districts_provinces_province_code",
                table: "districts");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_regions_AdministrativeRegionId",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_provinces_administrative_units_AdministrativeUnitId",
                table: "provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_administrative_units_AdministrativeUnitId",
                table: "wards");

            migrationBuilder.DropForeignKey(
                name: "FK_wards_districts_DistrictCode",
                table: "wards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wards",
                table: "wards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provinces",
                table: "provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_districts",
                table: "districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_administrative_units",
                table: "administrative_units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_administrative_regions",
                table: "administrative_regions");

            migrationBuilder.RenameTable(
                name: "wards",
                newName: "Wards");

            migrationBuilder.RenameTable(
                name: "provinces",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "districts",
                newName: "Districts");

            migrationBuilder.RenameTable(
                name: "administrative_units",
                newName: "AdministrativeUnits");

            migrationBuilder.RenameTable(
                name: "administrative_regions",
                newName: "AdministrativeRegions");

            migrationBuilder.RenameIndex(
                name: "IX_wards_DistrictCode",
                table: "Wards",
                newName: "IX_Wards_DistrictCode");

            migrationBuilder.RenameIndex(
                name: "IX_wards_AdministrativeUnitId",
                table: "Wards",
                newName: "IX_Wards_AdministrativeUnitId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Provinces",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Provinces",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "name_en",
                table: "Provinces",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "full_name_en",
                table: "Provinces",
                newName: "FullNameEn");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Provinces",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "code_name",
                table: "Provinces",
                newName: "CodeName");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_AdministrativeUnitId",
                table: "Provinces",
                newName: "IX_Provinces_AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_provinces_AdministrativeRegionId",
                table: "Provinces",
                newName: "IX_Provinces_AdministrativeRegionId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Districts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Districts",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "province_code",
                table: "Districts",
                newName: "ProvinceCode");

            migrationBuilder.RenameColumn(
                name: "name_en",
                table: "Districts",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "full_name_en",
                table: "Districts",
                newName: "FullNameEn");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Districts",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "code_name",
                table: "Districts",
                newName: "CodeName");

            migrationBuilder.RenameIndex(
                name: "IX_districts_AdministrativeUnitId",
                table: "Districts",
                newName: "IX_Districts_AdministrativeUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_districts_province_code",
                table: "Districts",
                newName: "IX_Districts_ProvinceCode");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AdministrativeUnits",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "short_name_en",
                table: "AdministrativeUnits",
                newName: "ShortNameEn");

            migrationBuilder.RenameColumn(
                name: "short_name",
                table: "AdministrativeUnits",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "full_name_en",
                table: "AdministrativeUnits",
                newName: "FullNameEn");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "AdministrativeUnits",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "code_name_en",
                table: "AdministrativeUnits",
                newName: "CodeNameEn");

            migrationBuilder.RenameColumn(
                name: "code_name",
                table: "AdministrativeUnits",
                newName: "CodeName");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AdministrativeRegions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AdministrativeRegions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name_en",
                table: "AdministrativeRegions",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "code_name_en",
                table: "AdministrativeRegions",
                newName: "CodeNameEn");

            migrationBuilder.RenameColumn(
                name: "code_name",
                table: "AdministrativeRegions",
                newName: "CodeName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wards",
                table: "Wards",
                column: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Districts",
                table: "Districts",
                column: "Code");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdministrativeUnits",
                table: "AdministrativeUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdministrativeRegions",
                table: "AdministrativeRegions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_AdministrativeUnits_AdministrativeUnitId",
                table: "Districts",
                column: "AdministrativeUnitId",
                principalTable: "AdministrativeUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Provinces_ProvinceCode",
                table: "Districts",
                column: "ProvinceCode",
                principalTable: "Provinces",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_AdministrativeRegions_AdministrativeRegionId",
                table: "Provinces",
                column: "AdministrativeRegionId",
                principalTable: "AdministrativeRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_AdministrativeUnits_AdministrativeUnitId",
                table: "Provinces",
                column: "AdministrativeUnitId",
                principalTable: "AdministrativeUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_AdministrativeUnits_AdministrativeUnitId",
                table: "Wards",
                column: "AdministrativeUnitId",
                principalTable: "AdministrativeUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wards_Districts_DistrictCode",
                table: "Wards",
                column: "DistrictCode",
                principalTable: "Districts",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
