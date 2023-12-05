using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArteriaIndications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AllowControl = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPressureMonitoring = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPiccoMonitoring = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArteriaIndications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentralVeinIndications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AllowVenoseAccess = table.Column<bool>(type: "boolean", nullable: false),
                    AllowInfusionTherapy = table.Column<bool>(type: "boolean", nullable: false),
                    AllowParenteralNutrition = table.Column<bool>(type: "boolean", nullable: false),
                    AllowHemocorrection = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralVeinIndications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Position = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FIO = table.Column<string>(type: "text", nullable: false),
                    Adress = table.Column<string>(type: "text", nullable: false),
                    Peculiarity = table.Column<string>(type: "text", nullable: false),
                    VAS = table.Column<string>(type: "text", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    ArtPresUp = table.Column<int>(type: "integer", nullable: false),
                    ArtPresDown = table.Column<int>(type: "integer", nullable: false),
                    Pulse = table.Column<int>(type: "integer", nullable: false),
                    SpO2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsLocalAnesthesyNeeded = table.Column<bool>(type: "boolean", nullable: false),
                    LocalAnesthesyType = table.Column<string>(type: "text", nullable: true),
                    LocalAnesthesyTypes = table.Column<string[]>(type: "text[]", nullable: true),
                    LocalAnesthesyDose = table.Column<decimal>(type: "numeric", nullable: false),
                    CatheterUsed = table.Column<string>(type: "text", nullable: true),
                    CathetersUsed = table.Column<string[]>(type: "text[]", nullable: true),
                    TriesNo = table.Column<int>(type: "integer", nullable: false),
                    CatheterInsertedCentimetres = table.Column<int>(type: "integer", nullable: false),
                    Features = table.Column<string>(type: "text", nullable: true),
                    Complications = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    ArteriaProtocol_IndicationsId = table.Column<string>(type: "text", nullable: true),
                    ArteriaToBeCatheterized = table.Column<string>(type: "text", nullable: true),
                    ArteriasToBeCatheterized = table.Column<string[]>(type: "text[]", nullable: true),
                    IndicationsId = table.Column<string>(type: "text", nullable: true),
                    VeinToBeCatheterized = table.Column<string>(type: "text", nullable: true),
                    VeinsToBeCatheterized = table.Column<string[]>(type: "text[]", nullable: true),
                    CVD = table.Column<int>(type: "integer", nullable: true),
                    IsRgControlNeeded = table.Column<bool>(type: "boolean", nullable: true),
                    RgControlDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protocols_ArteriaIndications_ArteriaProtocol_IndicationsId",
                        column: x => x.ArteriaProtocol_IndicationsId,
                        principalTable: "ArteriaIndications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Protocols_CentralVeinIndications_IndicationsId",
                        column: x => x.IndicationsId,
                        principalTable: "CentralVeinIndications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Protocols_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SLRProtocols",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    CallTo = table.Column<string>(type: "text", nullable: true),
                    PatientName = table.Column<string>(type: "text", nullable: true),
                    PatientAge = table.Column<int>(type: "integer", nullable: false),
                    SpontaneousBreathing = table.Column<string>(type: "text", nullable: true),
                    PupilType = table.Column<string>(type: "text", nullable: true),
                    PupilCondition = table.Column<string>(type: "text", nullable: true),
                    EKGMonitor = table.Column<string>(type: "text", nullable: true),
                    WasBaseSLRCarriedOut = table.Column<bool>(type: "boolean", nullable: false),
                    TrachealIntubationNo = table.Column<int>(type: "integer", nullable: false),
                    TrachealIntubationTry = table.Column<int>(type: "integer", nullable: false),
                    Features = table.Column<string>(type: "text", nullable: true),
                    VentilationThrough = table.Column<string>(type: "text", nullable: true),
                    VentilationWith = table.Column<string>(type: "text", nullable: true),
                    DefibrillationInfo = table.Column<string[]>(type: "text[]", nullable: true),
                    IntravenousCatheterInfo = table.Column<string[]>(type: "text[]", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "text", nullable: true),
                    ReanimationCancelReason = table.Column<string>(type: "text", nullable: true),
                    ReanimationFeatures = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLRProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SLRProtocols_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_ArteriaProtocol_IndicationsId",
                table: "Protocols",
                column: "ArteriaProtocol_IndicationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_DoctorId",
                table: "Protocols",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_IndicationsId",
                table: "Protocols",
                column: "IndicationsId");

            migrationBuilder.CreateIndex(
                name: "IX_SLRProtocols_DoctorId",
                table: "SLRProtocols",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "SLRProtocols");

            migrationBuilder.DropTable(
                name: "ArteriaIndications");

            migrationBuilder.DropTable(
                name: "CentralVeinIndications");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
