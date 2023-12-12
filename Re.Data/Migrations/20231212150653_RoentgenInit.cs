using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class RoentgenInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbdominalRoentgens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AllowPostoperativeAnalysis = table.Column<bool>(type: "boolean", nullable: false),
                    AllowGasAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPassageRating = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPositionControl = table.Column<bool>(type: "boolean", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Other = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    LocationPosition = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbdominalRoentgens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbdominalRoentgens_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChestСavityRoentgens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AllowPostoperativeAnalysis = table.Column<bool>(type: "boolean", nullable: false),
                    AllowHemopneumothoraxException = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPositionControl = table.Column<bool>(type: "boolean", nullable: false),
                    AllowDiagnosticsChanges = table.Column<bool>(type: "boolean", nullable: false),
                    AllowIdentificationInjuries = table.Column<bool>(type: "boolean", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Other = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    LocationPosition = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChestСavityRoentgens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChestСavityRoentgens_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TomographicExplorations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ExplorationType = table.Column<string>(type: "text", nullable: true),
                    IsContrasted = table.Column<bool>(type: "boolean", nullable: false),
                    IsHead = table.Column<bool>(type: "boolean", nullable: false),
                    IsThoracicCavity = table.Column<bool>(type: "boolean", nullable: false),
                    IsAbdominalCavity = table.Column<bool>(type: "boolean", nullable: false),
                    IsCervicalSpine = table.Column<bool>(type: "boolean", nullable: false),
                    IsPelvicCavity = table.Column<bool>(type: "boolean", nullable: false),
                    Indication = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Other = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    LocationPosition = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TomographicExplorations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TomographicExplorations_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbdominalRoentgens_DoctorId",
                table: "AbdominalRoentgens",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChestСavityRoentgens_DoctorId",
                table: "ChestСavityRoentgens",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_TomographicExplorations_DoctorId",
                table: "TomographicExplorations",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbdominalRoentgens");

            migrationBuilder.DropTable(
                name: "ChestСavityRoentgens");

            migrationBuilder.DropTable(
                name: "TomographicExplorations");
        }
    }
}
