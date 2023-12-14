using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class Diaries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorTwo",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "ExtubationDiaries");

            migrationBuilder.AlterColumn<string>(
                name: "Сonditions",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Сomplaints",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Urine",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stomach",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RespiratorySupport",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rass",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Peristalsis",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pain",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InhalationO2",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hemodynamics",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Extubation",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Conscience",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Breathing",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Auscultatory",
                table: "WeekendDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorFiveId",
                table: "WeekendDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorFourId",
                table: "WeekendDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "WeekendDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorThreeId",
                table: "WeekendDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorTwoId",
                table: "WeekendDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Сonditions",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Сomplaints",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Vash",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Urine",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Stomach",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RespiratorySupport",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rass",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Peristalsis",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pain",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InhalationO2",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hemodynamics",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Extubation",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Conscience",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Breathing",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Auscultatory",
                table: "StandartDiaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorId",
                table: "ExtubationDiaries",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HemoEpicrises",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FIO = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    GroupRh = table.Column<string[]>(type: "text[]", nullable: false),
                    Diagnosis = table.Column<string>(type: "text", nullable: false),
                    Indications = table.Column<string[]>(type: "text[]", nullable: false),
                    Hemotransfusion = table.Column<string>(type: "text", nullable: false),
                    Doctor = table.Column<string[]>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HemoEpicrises", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeekendDiaries_DoctorFiveId",
                table: "WeekendDiaries",
                column: "DoctorFiveId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekendDiaries_DoctorFourId",
                table: "WeekendDiaries",
                column: "DoctorFourId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekendDiaries_DoctorId",
                table: "WeekendDiaries",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekendDiaries_DoctorThreeId",
                table: "WeekendDiaries",
                column: "DoctorThreeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekendDiaries_DoctorTwoId",
                table: "WeekendDiaries",
                column: "DoctorTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtubationDiaries_DoctorId",
                table: "ExtubationDiaries",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtubationDiaries_Doctor_DoctorId",
                table: "ExtubationDiaries",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorFiveId",
                table: "WeekendDiaries",
                column: "DoctorFiveId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorFourId",
                table: "WeekendDiaries",
                column: "DoctorFourId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorId",
                table: "WeekendDiaries",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorThreeId",
                table: "WeekendDiaries",
                column: "DoctorThreeId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorTwoId",
                table: "WeekendDiaries",
                column: "DoctorTwoId",
                principalTable: "Doctor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtubationDiaries_Doctor_DoctorId",
                table: "ExtubationDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorFiveId",
                table: "WeekendDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorFourId",
                table: "WeekendDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorId",
                table: "WeekendDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorThreeId",
                table: "WeekendDiaries");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekendDiaries_Doctor_DoctorTwoId",
                table: "WeekendDiaries");

            migrationBuilder.DropTable(
                name: "HemoEpicrises");

            migrationBuilder.DropIndex(
                name: "IX_WeekendDiaries_DoctorFiveId",
                table: "WeekendDiaries");

            migrationBuilder.DropIndex(
                name: "IX_WeekendDiaries_DoctorFourId",
                table: "WeekendDiaries");

            migrationBuilder.DropIndex(
                name: "IX_WeekendDiaries_DoctorId",
                table: "WeekendDiaries");

            migrationBuilder.DropIndex(
                name: "IX_WeekendDiaries_DoctorThreeId",
                table: "WeekendDiaries");

            migrationBuilder.DropIndex(
                name: "IX_WeekendDiaries_DoctorTwoId",
                table: "WeekendDiaries");

            migrationBuilder.DropIndex(
                name: "IX_ExtubationDiaries_DoctorId",
                table: "ExtubationDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorFiveId",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorFourId",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorThreeId",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorTwoId",
                table: "WeekendDiaries");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "ExtubationDiaries");

            migrationBuilder.AddColumn<string[]>(
                name: "Doctor",
                table: "WeekendDiaries",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "DoctorTwo",
                table: "WeekendDiaries",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "Doctor",
                table: "ExtubationDiaries",
                type: "text[]",
                nullable: true);
        }
    }
}
