using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StajyerWebAPI.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Stajyers");

            migrationBuilder.DropColumn(
                name: "Date2",
                table: "Stajyers");

            migrationBuilder.AddColumn<DateTime>(
                name: "CikisTar",
                table: "Stajyers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "KayitTar",
                table: "Stajyers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CikisTar",
                table: "Stajyers");

            migrationBuilder.DropColumn(
                name: "KayitTar",
                table: "Stajyers");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Stajyers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date2",
                table: "Stajyers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
