using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "administrative_regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    name_en = table.Column<string>(type: "varchar", nullable: false),
                    code_name = table.Column<string>(type: "varchar", nullable: false),
                    code_name_en = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrative_regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "administrative_units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    full_name = table.Column<string>(type: "varchar", nullable: false),
                    full_name_en = table.Column<string>(type: "varchar", nullable: false),
                    short_name = table.Column<string>(type: "varchar", nullable: false),
                    short_name_en = table.Column<string>(type: "varchar", nullable: false),
                    code_name = table.Column<string>(type: "varchar", nullable: false),
                    code_name_en = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_administrative_units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provinces",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar", nullable: false),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    name_en = table.Column<string>(type: "varchar", nullable: false),
                    full_name = table.Column<string>(type: "varchar", nullable: false),
                    full_name_en = table.Column<string>(type: "varchar", nullable: false),
                    code_name = table.Column<string>(type: "varchar", nullable: false),
                    administrative_unit_id = table.Column<int>(type: "integer", nullable: false),
                    AdministrativeUnitId1 = table.Column<int>(type: "integer", nullable: false),
                    administrative_region_id = table.Column<int>(type: "integer", nullable: false),
                    AdministrativeRegionId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provinces", x => x.code);
                    table.ForeignKey(
                        name: "FK_provinces_administrative_regions_AdministrativeRegionId1",
                        column: x => x.AdministrativeRegionId1,
                        principalTable: "administrative_regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provinces_administrative_regions_administrative_region_id",
                        column: x => x.administrative_region_id,
                        principalTable: "administrative_regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provinces_administrative_units_AdministrativeUnitId1",
                        column: x => x.AdministrativeUnitId1,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provinces_administrative_units_administrative_unit_id",
                        column: x => x.administrative_unit_id,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "districts",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar", nullable: false),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    name_en = table.Column<string>(type: "varchar", nullable: false),
                    full_name = table.Column<string>(type: "varchar", nullable: false),
                    full_name_en = table.Column<string>(type: "varchar", nullable: false),
                    code_name = table.Column<string>(type: "varchar", nullable: false),
                    administrative_unit_id = table.Column<int>(type: "integer", nullable: false),
                    AdministrativeUnitId1 = table.Column<int>(type: "integer", nullable: false),
                    province_code = table.Column<string>(type: "varchar", nullable: false),
                    ProvinceCode1 = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_districts", x => x.code);
                    table.ForeignKey(
                        name: "FK_districts_administrative_units_AdministrativeUnitId1",
                        column: x => x.AdministrativeUnitId1,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_districts_administrative_units_administrative_unit_id",
                        column: x => x.administrative_unit_id,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_districts_provinces_ProvinceCode1",
                        column: x => x.ProvinceCode1,
                        principalTable: "provinces",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_districts_provinces_province_code",
                        column: x => x.province_code,
                        principalTable: "provinces",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wards",
                columns: table => new
                {
                    code = table.Column<string>(type: "varchar", nullable: false),
                    name = table.Column<string>(type: "varchar", nullable: false),
                    name_en = table.Column<string>(type: "varchar", nullable: false),
                    full_name = table.Column<string>(type: "varchar", nullable: false),
                    full_name_en = table.Column<string>(type: "varchar", nullable: false),
                    code_name = table.Column<string>(type: "varchar", nullable: false),
                    administrative_unit_id = table.Column<int>(type: "integer", nullable: false),
                    AdministrativeUnitId1 = table.Column<int>(type: "integer", nullable: false),
                    district_code = table.Column<string>(type: "varchar", nullable: false),
                    DistrictCode1 = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wards", x => x.code);
                    table.ForeignKey(
                        name: "FK_wards_administrative_units_AdministrativeUnitId1",
                        column: x => x.AdministrativeUnitId1,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wards_administrative_units_administrative_unit_id",
                        column: x => x.administrative_unit_id,
                        principalTable: "administrative_units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wards_districts_DistrictCode1",
                        column: x => x.DistrictCode1,
                        principalTable: "districts",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wards_districts_district_code",
                        column: x => x.district_code,
                        principalTable: "districts",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_districts_administrative_unit_id",
                table: "districts",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_districts_AdministrativeUnitId1",
                table: "districts",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_districts_province_code",
                table: "districts",
                column: "province_code");

            migrationBuilder.CreateIndex(
                name: "IX_districts_ProvinceCode1",
                table: "districts",
                column: "ProvinceCode1");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_administrative_region_id",
                table: "provinces",
                column: "administrative_region_id");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_administrative_unit_id",
                table: "provinces",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_AdministrativeRegionId1",
                table: "provinces",
                column: "AdministrativeRegionId1");

            migrationBuilder.CreateIndex(
                name: "IX_provinces_AdministrativeUnitId1",
                table: "provinces",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_wards_administrative_unit_id",
                table: "wards",
                column: "administrative_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_wards_AdministrativeUnitId1",
                table: "wards",
                column: "AdministrativeUnitId1");

            migrationBuilder.CreateIndex(
                name: "IX_wards_district_code",
                table: "wards",
                column: "district_code");

            migrationBuilder.CreateIndex(
                name: "IX_wards_DistrictCode1",
                table: "wards",
                column: "DistrictCode1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wards");

            migrationBuilder.DropTable(
                name: "districts");

            migrationBuilder.DropTable(
                name: "provinces");

            migrationBuilder.DropTable(
                name: "administrative_regions");

            migrationBuilder.DropTable(
                name: "administrative_units");
        }
    }
}
