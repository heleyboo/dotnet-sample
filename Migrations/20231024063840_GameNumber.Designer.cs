﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapi.DbContext;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(AdministrativeDataContext))]
    [Migration("20231024063840_GameNumber")]
    partial class GameNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("webapi.Models.BoardNumber.GameUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("game_users", (string)null);
                });

            modelBuilder.Entity("webapi.Models.BoardNumber.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("game_rooms", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.AdministrativeRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name_en");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name_en");

                    b.HasKey("Id");

                    b.ToTable("administrative_regions", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.AdministrativeUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name");

                    b.Property<string>("CodeNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name_en");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name_en");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("short_name");

                    b.Property<string>("ShortNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("short_name_en");

                    b.HasKey("Id");

                    b.ToTable("administrative_units", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.District", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar")
                        .HasColumnName("code");

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("integer")
                        .HasColumnName("administrative_unit_id");

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name_en");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name_en");

                    b.Property<string>("ProvinceCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("province_code");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("districts", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.Province", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar")
                        .HasColumnName("code");

                    b.Property<int>("AdministrativeRegionId")
                        .HasColumnType("integer")
                        .HasColumnName("administrative_region_id");

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("integer")
                        .HasColumnName("administrative_unit_id");

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name_en");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name_en");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeRegionId");

                    b.HasIndex("AdministrativeUnitId");

                    b.ToTable("provinces", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.Ward", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar")
                        .HasColumnName("code");

                    b.Property<int>("AdministrativeUnitId")
                        .HasColumnType("integer")
                        .HasColumnName("administrative_unit_id");

                    b.Property<string>("CodeName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("code_name");

                    b.Property<string>("DistrictCode")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("district_code");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name");

                    b.Property<string>("FullNameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("full_name_en");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name");

                    b.Property<string>("NameEn")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("name_en");

                    b.HasKey("Code");

                    b.HasIndex("AdministrativeUnitId");

                    b.HasIndex("DistrictCode");

                    b.ToTable("wards", (string)null);
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.District", b =>
                {
                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Districts")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.Province", b =>
                {
                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.AdministrativeRegion", "AdministrativeRegion")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeRegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Provinces")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdministrativeRegion");

                    b.Navigation("AdministrativeUnit");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.Ward", b =>
                {
                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.AdministrativeUnit", "AdministrativeUnit")
                        .WithMany("Wards")
                        .HasForeignKey("AdministrativeUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.VietnameseAdministrativeUnits.District", "District")
                        .WithMany("Wards")
                        .HasForeignKey("DistrictCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdministrativeUnit");

                    b.Navigation("District");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.AdministrativeRegion", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.AdministrativeUnit", b =>
                {
                    b.Navigation("Districts");

                    b.Navigation("Provinces");

                    b.Navigation("Wards");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.District", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("webapi.Models.VietnameseAdministrativeUnits.Province", b =>
                {
                    b.Navigation("Districts");
                });
#pragma warning restore 612, 618
        }
    }
}