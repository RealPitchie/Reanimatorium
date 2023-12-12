using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class HemoEpicrisisfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "HemoEpicrises");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "TransferableEpicrisis",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "TransferableEpicrisis",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ReceptionEpicrises",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Indications",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroupRh",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EritGroup",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SZPGroup",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrombGroup",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "danerit",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "danszp",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dantromb",
                table: "HemoEpicrises",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HemoEpicrises_DoctorId",
                table: "HemoEpicrises",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_HemoEpicrises_Doctor_DoctorId",
                table: "HemoEpicrises",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HemoEpicrises_Doctor_DoctorId",
                table: "HemoEpicrises");

            migrationBuilder.DropIndex(
                name: "IX_HemoEpicrises_DoctorId",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "EritGroup",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "SZPGroup",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "TrombGroup",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "danerit",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "danszp",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "dantromb",
                table: "HemoEpicrises");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "TransferableEpicrisis",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "TransferableEpicrisis",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ReceptionEpicrises",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string[]>(
                name: "Indications",
                table: "HemoEpicrises",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string[]>(
                name: "GroupRh",
                table: "HemoEpicrises",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "Doctor",
                table: "HemoEpicrises",
                type: "text[]",
                nullable: true);
        }
    }
}
