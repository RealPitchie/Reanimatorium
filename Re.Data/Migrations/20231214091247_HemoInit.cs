using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class HemoInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "HemoEpicrises");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "HemoEpicrises");



     
   

     
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Time",
                table: "ReceptionEpicrises",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "ReceptionEpicrises",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "HemoEpicrises",
                type: "interval",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Indications",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]");

            migrationBuilder.AlterColumn<string>(
                name: "Hemotransfusion",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "GroupRh",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]");

            migrationBuilder.AlterColumn<string>(
                name: "FIO",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Diagnosis",
                table: "HemoEpicrises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HemoEpicrises",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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

         

            migrationBuilder.CreateTable(
                name: "ErythrocyteProtocols",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    FIO = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Group = table.Column<string>(type: "text", nullable: true),
                    Phenotype = table.Column<string>(type: "text", nullable: true),
                    Place = table.Column<string>(type: "text", nullable: true),
                    Indication = table.Column<string>(type: "text", nullable: true),
                    Anamnesis = table.Column<string>(type: "text", nullable: true),
                    Component = table.Column<string>(type: "text", nullable: true),
                    Mfr = table.Column<string>(type: "text", nullable: true),
                    NumberCont = table.Column<int>(type: "integer", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    GroupDonor = table.Column<string>(type: "text", nullable: true),
                    Reagents = table.Column<string>(type: "text", nullable: true),
                    Compatibility = table.Column<string>(type: "text", nullable: true),
                    BiologicalSample = table.Column<string>(type: "text", nullable: true),
                    Transfusion = table.Column<string>(type: "text", nullable: true),
                    Complications = table.Column<string>(type: "text", nullable: true),
                    AD = table.Column<string>(type: "text", nullable: true),
                    ADhafter = table.Column<string>(type: "text", nullable: true),
                    AD2hafter = table.Column<string>(type: "text", nullable: true),
                    HR = table.Column<string>(type: "text", nullable: true),
                    HRhafter = table.Column<string>(type: "text", nullable: true),
                    HR2hafter = table.Column<string>(type: "text", nullable: true),
                    T = table.Column<string>(type: "text", nullable: true),
                    Thafter = table.Column<string>(type: "text", nullable: true),
                    T2hafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Diuresishafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis2hafter = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErythrocyteProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErythrocyteProtocols_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SZPProtocols",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    FIO = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Group = table.Column<string>(type: "text", nullable: true),
                    Phenotype = table.Column<string>(type: "text", nullable: true),
                    Place = table.Column<string>(type: "text", nullable: true),
                    Indication = table.Column<string>(type: "text", nullable: true),
                    Anamnesis = table.Column<string>(type: "text", nullable: true),
                    Component = table.Column<string>(type: "text", nullable: true),
                    Mfr = table.Column<string>(type: "text", nullable: true),
                    NumberCont = table.Column<int>(type: "integer", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    GroupDonor = table.Column<string>(type: "text", nullable: true),
                    Reagents = table.Column<string>(type: "text", nullable: true),
                    Compatibility = table.Column<string>(type: "text", nullable: true),
                    BiologicalSample = table.Column<string>(type: "text", nullable: true),
                    Transfusion = table.Column<string>(type: "text", nullable: true),
                    Complications = table.Column<string>(type: "text", nullable: true),
                    AD = table.Column<string>(type: "text", nullable: true),
                    ADhafter = table.Column<string>(type: "text", nullable: true),
                    AD2hafter = table.Column<string>(type: "text", nullable: true),
                    HR = table.Column<string>(type: "text", nullable: true),
                    HRhafter = table.Column<string>(type: "text", nullable: true),
                    HR2hafter = table.Column<string>(type: "text", nullable: true),
                    T = table.Column<string>(type: "text", nullable: true),
                    Thafter = table.Column<string>(type: "text", nullable: true),
                    T2hafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Diuresishafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis2hafter = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SZPProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SZPProtocols_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThrombocyteProtocols",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    FIO = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Group = table.Column<string>(type: "text", nullable: true),
                    Phenotype = table.Column<string>(type: "text", nullable: true),
                    Place = table.Column<string>(type: "text", nullable: true),
                    Indication = table.Column<string>(type: "text", nullable: true),
                    Anamnesis = table.Column<string>(type: "text", nullable: true),
                    Component = table.Column<string>(type: "text", nullable: true),
                    Mfr = table.Column<string>(type: "text", nullable: true),
                    NumberCont = table.Column<int>(type: "integer", nullable: false),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    GroupDonor = table.Column<string>(type: "text", nullable: true),
                    Reagents = table.Column<string>(type: "text", nullable: true),
                    Compatibility = table.Column<string>(type: "text", nullable: true),
                    BiologicalSample = table.Column<string>(type: "text", nullable: true),
                    Transfusion = table.Column<string>(type: "text", nullable: true),
                    Complications = table.Column<string>(type: "text", nullable: true),
                    AD = table.Column<string>(type: "text", nullable: true),
                    ADhafter = table.Column<string>(type: "text", nullable: true),
                    AD2hafter = table.Column<string>(type: "text", nullable: true),
                    HR = table.Column<string>(type: "text", nullable: true),
                    HRhafter = table.Column<string>(type: "text", nullable: true),
                    HR2hafter = table.Column<string>(type: "text", nullable: true),
                    T = table.Column<string>(type: "text", nullable: true),
                    Thafter = table.Column<string>(type: "text", nullable: true),
                    T2hafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Diuresishafter = table.Column<string>(type: "text", nullable: true),
                    Diuresis2hafter = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThrombocyteProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThrombocyteProtocols_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HemoEpicrises_DoctorId",
                table: "HemoEpicrises",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ErythrocyteProtocols_DoctorId",
                table: "ErythrocyteProtocols",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_SZPProtocols_DoctorId",
                table: "SZPProtocols",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ThrombocyteProtocols_DoctorId",
                table: "ThrombocyteProtocols",
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

            migrationBuilder.DropTable(
                name: "ErythrocyteProtocols");

            migrationBuilder.DropTable(
                name: "SZPProtocols");

            migrationBuilder.DropTable(
                name: "ThrombocyteProtocols");

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


            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Time",
                table: "ReceptionEpicrises",
                type: "interval",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ReceptionEpicrises",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Time",
                table: "HemoEpicrises",
                type: "time without time zone",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Hemotransfusion",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FIO",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Diagnosis",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "HemoEpicrises",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string[]>(
                name: "Doctor",
                table: "HemoEpicrises",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0]);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "HemoEpicrises",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
