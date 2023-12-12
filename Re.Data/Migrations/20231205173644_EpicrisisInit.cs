using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class EpicrisisInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReceptionEpicrises",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    DeliveredFrom = table.Column<string>(type: "text", nullable: true),
                    AVLDueTransportation = table.Column<string>(type: "text", nullable: true),
                    Complaints = table.Column<string>(type: "text", nullable: true),
                    ComplaintText = table.Column<string>(type: "text", nullable: true),
                    VAS = table.Column<string>(type: "text", nullable: true),
                    Condition = table.Column<string>(type: "text", nullable: true),
                    Conscience = table.Column<string>(type: "text", nullable: true),
                    Ramsey = table.Column<string>(type: "text", nullable: true),
                    MuscleTone = table.Column<string>(type: "text", nullable: true),
                    SkinCovers = table.Column<string[]>(type: "text[]", nullable: true),
                    Cyanosis = table.Column<string>(type: "text", nullable: true),
                    Marbling = table.Column<string>(type: "text", nullable: true),
                    PeripheralEdema = table.Column<string>(type: "text", nullable: true),
                    VeinsToBeCatheterized = table.Column<string[]>(type: "text[]", nullable: true),
                    InflammationInCatheter = table.Column<string>(type: "text", nullable: true),
                    SpontaneousBreathing = table.Column<string>(type: "text", nullable: true),
                    BreathingThrough = table.Column<string>(type: "text", nullable: true),
                    BreathingDisorder = table.Column<string>(type: "text", nullable: true),
                    RespiratoryRate = table.Column<int>(type: "integer", nullable: false),
                    Auscultatory = table.Column<string>(type: "text", nullable: true),
                    BreathingRate = table.Column<string[]>(type: "text[]", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupport = table.Column<string>(type: "text", nullable: true),
                    OxygenInsufflation = table.Column<string>(type: "text", nullable: true),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Device = table.Column<string>(type: "text", nullable: true),
                    Mode = table.Column<string>(type: "text", nullable: true),
                    Till = table.Column<int>(type: "integer", nullable: false),
                    Inotropes = table.Column<string>(type: "text", nullable: true),
                    InotropesValue = table.Column<int>(type: "integer", nullable: false),
                    InotropesUnits = table.Column<string>(type: "text", nullable: true),
                    InotropesDescription = table.Column<string>(type: "text", nullable: true),
                    BR = table.Column<int>(type: "integer", nullable: false),
                    Pinsp = table.Column<int>(type: "integer", nullable: false),
                    Psupp = table.Column<int>(type: "integer", nullable: false),
                    PEEP = table.Column<int>(type: "integer", nullable: false),
                    FiO2 = table.Column<int>(type: "integer", nullable: false),
                    Hemodynamics = table.Column<string>(type: "text", nullable: true),
                    ArtherialPressure = table.Column<int[]>(type: "integer[]", nullable: true),
                    Pulse = table.Column<int>(type: "integer", nullable: false),
                    PulseRhythm = table.Column<string>(type: "text", nullable: true),
                    HeartRate = table.Column<int>(type: "integer", nullable: false),
                    SpO2 = table.Column<int>(type: "integer", nullable: false),
                    Abdomen = table.Column<string>(type: "text", nullable: true),
                    AbdomenText = table.Column<string>(type: "text", nullable: true),
                    Pain = table.Column<string>(type: "text", nullable: true),
                    PainText = table.Column<string>(type: "text", nullable: true),
                    Distension = table.Column<string>(type: "text", nullable: true),
                    DistensionText = table.Column<string>(type: "text", nullable: true),
                    Peristalsis = table.Column<string>(type: "text", nullable: true),
                    Tongue = table.Column<string[]>(type: "text[]", nullable: true),
                    Diuresis = table.Column<double>(type: "double precision", nullable: false),
                    Urine = table.Column<string>(type: "text", nullable: true),
                    Drainage = table.Column<string>(type: "text", nullable: true),
                    LaboratoryData = table.Column<string>(type: "text", nullable: true),
                    Addition = table.Column<string>(type: "text", nullable: true),
                    SeverityOfCondition = table.Column<string>(type: "text", nullable: true),
                    TreatmentPlan = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionEpicrises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceptionEpicrises_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReceptionEpicrises_DoctorId",
                table: "ReceptionEpicrises",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceptionEpicrises");
        }
    }
}
