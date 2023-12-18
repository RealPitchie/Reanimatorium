using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class NewProt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "RgControlDate",
                table: "Protocols",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsRgControlNeeded",
                table: "Protocols",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CVD",
                table: "Protocols",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CatheterInserted",
                table: "Protocols",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "CathetersInserted",
                table: "Protocols",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Protocols",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PunctionLevel",
                table: "Protocols",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "PunctionLevels",
                table: "Protocols",
                type: "text[]",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatheterInserted",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "CathetersInserted",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "PunctionLevel",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "PunctionLevels",
                table: "Protocols");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "RgControlDate",
                table: "Protocols",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRgControlNeeded",
                table: "Protocols",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "CVD",
                table: "Protocols",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
