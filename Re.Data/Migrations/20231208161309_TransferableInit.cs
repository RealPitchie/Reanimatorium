using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class TransferableInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransferableEpicrisis",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "date", nullable: true),
                    DateTo = table.Column<DateTime>(type: "date", nullable: true),
                    Diagnosis = table.Column<string>(type: "text", nullable: true),
                    ReasonsHere = table.Column<string>(type: "text", nullable: true),
                    OngoingTherapy = table.Column<string>(type: "text", nullable: true),
                    DynamicsState = table.Column<string>(type: "text", nullable: true),
                    Department = table.Column<string>(type: "text", nullable: true),
                    AgreedWith = table.Column<string>(type: "text", nullable: true),
                    Condition = table.Column<string>(type: "text", nullable: true),
                    Temperature = table.Column<int>(type: "integer", nullable: false),
                    Conscience = table.Column<string>(type: "text", nullable: true),
                    SkinCovers = table.Column<string[]>(type: "text[]", nullable: true),
                    Breathing = table.Column<string>(type: "text", nullable: true),
                    RespiratoryRate = table.Column<int>(type: "integer", nullable: false),
                    Hemodynamics = table.Column<string>(type: "text", nullable: true),
                    ArtherialPressure = table.Column<int[]>(type: "integer[]", nullable: true),
                    Ps = table.Column<int>(type: "integer", nullable: false),
                    VentricularReduce = table.Column<int>(type: "integer", nullable: false),
                    Auscultatory = table.Column<string>(type: "text", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    Abdomen = table.Column<string>(type: "text", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Drainage = table.Column<string>(type: "text", nullable: true),
                    TransferCavacatheter = table.Column<string>(type: "text", nullable: true),
                    InflammationSigns = table.Column<string>(type: "text", nullable: true),
                    TransferEpiduralCavacatheter = table.Column<string>(type: "text", nullable: true),
                    Recomended = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true),
                    ChiefId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferableEpicrisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferableEpicrisis_Doctor_ChiefId",
                        column: x => x.ChiefId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TransferableEpicrisis_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransferableEpicrisis_ChiefId",
                table: "TransferableEpicrisis",
                column: "ChiefId");

            migrationBuilder.CreateIndex(
                name: "IX_TransferableEpicrisis_DoctorId",
                table: "TransferableEpicrisis",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransferableEpicrisis");
        }
    }
}
