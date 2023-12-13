using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class Diary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EsCCO",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    EsHCB = table.Column<int>(type: "integer", nullable: false),
                    EsYO = table.Column<int>(type: "integer", nullable: false),
                    EsHCI = table.Column<int>(type: "integer", nullable: false),
                    EsIYO = table.Column<int>(type: "integer", nullable: false),
                    EsCCC = table.Column<int>(type: "integer", nullable: false),
                    EsICCC = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsCCO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtubationDiaries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    MedSedation = table.Column<string>(type: "text", nullable: true),
                    MuscleTone = table.Column<string>(type: "text", nullable: true),
                    Insuflation = table.Column<int>(type: "integer", nullable: false),
                    Sat = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<int>(type: "integer", nullable: false),
                    Chss = table.Column<int>(type: "integer", nullable: false),
                    Doctor = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtubationDiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FioTrac",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CCO = table.Column<int>(type: "integer", nullable: false),
                    SVR = table.Column<int>(type: "integer", nullable: false),
                    SVV = table.Column<int>(type: "integer", nullable: false),
                    SV = table.Column<int>(type: "integer", nullable: false),
                    CVP = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FioTrac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Volume = table.Column<int>(type: "integer", nullable: false),
                    Аmpoule = table.Column<int>(type: "integer", nullable: false),
                    Tablet = table.Column<int>(type: "integer", nullable: false),
                    TTC = table.Column<int>(type: "integer", nullable: false),
                    Purpose = table.Column<string>(type: "text", nullable: false),
                    Medication = table.Column<string>(type: "text", nullable: false),
                    Injection = table.Column<string>(type: "text", nullable: false),
                    Doctor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PiCCO",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CI = table.Column<int>(type: "integer", nullable: true),
                    ITBI = table.Column<int>(type: "integer", nullable: true),
                    CFI = table.Column<int>(type: "integer", nullable: true),
                    SVV = table.Column<int>(type: "integer", nullable: true),
                    SVI = table.Column<int>(type: "integer", nullable: true),
                    ELWI = table.Column<int>(type: "integer", nullable: true),
                    MAP = table.Column<int>(type: "integer", nullable: true),
                    GEDI = table.Column<int>(type: "integer", nullable: true),
                    CVP = table.Column<int>(type: "integer", nullable: true),
                    SVRI = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiCCO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PiCCO2",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CI = table.Column<int>(type: "integer", nullable: false),
                    PVPI = table.Column<int>(type: "integer", nullable: false),
                    CFI = table.Column<int>(type: "integer", nullable: false),
                    SVV = table.Column<int>(type: "integer", nullable: false),
                    SVI = table.Column<int>(type: "integer", nullable: false),
                    ELWI = table.Column<int>(type: "integer", nullable: false),
                    MAP = table.Column<int>(type: "integer", nullable: false),
                    ScvO2 = table.Column<int>(type: "integer", nullable: false),
                    GEDI = table.Column<int>(type: "integer", nullable: false),
                    CVP = table.Column<int>(type: "integer", nullable: false),
                    SVRI = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PiCCO2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Syndroms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    VAS = table.Column<string>(type: "text", nullable: false),
                    ArtPresUp = table.Column<int>(type: "integer", nullable: false),
                    ArtPresDown = table.Column<int>(type: "integer", nullable: false),
                    Pulse = table.Column<int>(type: "integer", nullable: false),
                    SpO2 = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: false),
                    Resuscitator = table.Column<string>(type: "text", nullable: false),
                    Peculiarity = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syndroms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoLEF",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    RHEDV = table.Column<int>(type: "integer", nullable: false),
                    PCWP = table.Column<int>(type: "integer", nullable: false),
                    RL = table.Column<int>(type: "integer", nullable: false),
                    RVEDV = table.Column<int>(type: "integer", nullable: false),
                    LHEDV = table.Column<int>(type: "integer", nullable: false),
                    PVR = table.Column<int>(type: "integer", nullable: false),
                    PAP = table.Column<int>(type: "integer", nullable: false),
                    CVP = table.Column<int>(type: "integer", nullable: false),
                    RVEF = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoLEF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeekendDiaries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    Doctor = table.Column<string[]>(type: "text[]", nullable: true),
                    DoctorTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    Patient = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    OperationDay = table.Column<int>(type: "integer", nullable: false),
                    Сonditions = table.Column<string[]>(type: "text[]", nullable: true),
                    Сomplaints = table.Column<string[]>(type: "text[]", nullable: true),
                    ComplaintsAbout = table.Column<string>(type: "text", nullable: true),
                    Conscience = table.Column<string[]>(type: "text[]", nullable: true),
                    RassThis = table.Column<string>(type: "text", nullable: true),
                    Rass = table.Column<string[]>(type: "text[]", nullable: true),
                    Neurologist = table.Column<string>(type: "text", nullable: true),                
                    Skin = table.Column<string[]>(type: "text[]", nullable: true),
                    Breathing = table.Column<string[]>(type: "text[]", nullable: true),
                    Extubation = table.Column<string[]>(type: "text[]", nullable: true),
                    CddField = table.Column<int>(type: "integer", nullable: false),
                    InhalationO2 = table.Column<string[]>(type: "text[]", nullable: true),
                    SpeedFlow = table.Column<int>(type: "integer", nullable: false),
                    Auscultatory = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreath = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreathInput = table.Column<string>(type: "text", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupport = table.Column<string[]>(type: "text[]", nullable: true),
                    Do = table.Column<int>(type: "integer", nullable: false),
                    Cd = table.Column<int>(type: "integer", nullable: false),
                    Pdkv = table.Column<int>(type: "integer", nullable: false),
                    Fio2 = table.Column<int>(type: "integer", nullable: false),
                    Dvdox = table.Column<int>(type: "integer", nullable: false),
                    Dpod = table.Column<int>(type: "integer", nullable: false),
                    Hemodynamics = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOne = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOneInput = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<int>(type: "integer", nullable: false),
                    Сhss = table.Column<int>(type: "integer", nullable: false),
                    Spo2 = table.Column<int>(type: "integer", nullable: false),
                    Stomach = table.Column<string[]>(type: "text[]", nullable: true),
                    Pain = table.Column<string[]>(type: "text[]", nullable: true),
                    PainAbout = table.Column<string>(type: "text", nullable: true),
                    AbdominalBloating = table.Column<string[]>(type: "text[]", nullable: true),
                    Peristalsis = table.Column<string[]>(type: "text[]", nullable: true),
                    Tongue = table.Column<string[]>(type: "text[]", nullable: true),
                    Diuresis = table.Column<int>(type: "integer", nullable: false),
                    Urine = table.Column<string[]>(type: "text[]", nullable: true),
                    BodyTemperature = table.Column<int>(type: "integer", nullable: false),
                    Drainage = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAbout = table.Column<string>(type: "text", nullable: true),
                    DrainageTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAboutTwo = table.Column<string>(type: "text", nullable: true),
                    Additionally = table.Column<string>(type: "text", nullable: true),
                    SeverityOfCondition = table.Column<string>(type: "text", nullable: true),
                    Laboratory1 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory2 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory3 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory4 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory5 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory6 = table.Column<int>(type: "integer", nullable: false),
                    Recommended = table.Column<string>(type: "text", nullable: true),
                    Analyses = table.Column<int>(type: "integer", nullable: false),
                    AnalysesTwo = table.Column<int>(type: "integer", nullable: false),
                    AnalysesThree = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFour = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFive = table.Column<int>(type: "integer", nullable: false),
                    AnalysesSix = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry2 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry3 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry4 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry5 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry6 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry7 = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry8 = table.Column<int>(type: "integer", nullable: false),
                    Hemostasis = table.Column<int>(type: "integer", nullable: false),
                    Hemostasis2 = table.Column<int>(type: "integer", nullable: false),
                    Hemostasis3 = table.Column<int>(type: "integer", nullable: false),
                    Kshs = table.Column<int>(type: "integer", nullable: false),
                    Kshs2 = table.Column<int>(type: "integer", nullable: false),
                    Kshs3 = table.Column<int>(type: "integer", nullable: false),
                    Kshs4 = table.Column<int>(type: "integer", nullable: false),
                    Kshs5 = table.Column<int>(type: "integer", nullable: false),
                    Kshs6 = table.Column<int>(type: "integer", nullable: false),
                    Kshs7 = table.Column<int>(type: "integer", nullable: false),
                    Kshs8 = table.Column<int>(type: "integer", nullable: false),
                    Kshs9 = table.Column<int>(type: "integer", nullable: false),
                    Picco = table.Column<int>(type: "integer", nullable: false),
                    Picco2 = table.Column<int>(type: "integer", nullable: false),
                    Picco3 = table.Column<int>(type: "integer", nullable: false),
                    Picco4 = table.Column<int>(type: "integer", nullable: false),
                    Picco5 = table.Column<int>(type: "integer", nullable: false),
                    Picco6 = table.Column<int>(type: "integer", nullable: false),
                    Picco7 = table.Column<int>(type: "integer", nullable: false),
                    Picco8 = table.Column<int>(type: "integer", nullable: false),
                    Picco9 = table.Column<int>(type: "integer", nullable: false),
                    Picco10 = table.Column<int>(type: "integer", nullable: false),
                    Picco11 = table.Column<int>(type: "integer", nullable: false),
                    Analyses1 = table.Column<int>(type: "integer", nullable: false),
                    Analyses2 = table.Column<int>(type: "integer", nullable: false),
                    Analyses3 = table.Column<int>(type: "integer", nullable: false),
                    Product = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekendDiaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandartDiaries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time without time zone", nullable: false),
                    Сonditions = table.Column<string[]>(type: "text[]", nullable: true),
                    Сomplaints = table.Column<string[]>(type: "text[]", nullable: true),
                    ComplaintsAbout = table.Column<string>(type: "text", nullable: true),
                    RassThis = table.Column<string>(type: "text", nullable: true),
                    Rass = table.Column<string[]>(type: "text[]", nullable: true),
                    Vash = table.Column<string[]>(type: "text[]", nullable: true),
                    Conscience = table.Column<string[]>(type: "text[]", nullable: true),
                    Skin = table.Column<string[]>(type: "text[]", nullable: true),
                    Breathing = table.Column<string[]>(type: "text[]", nullable: true),
                    Extubation = table.Column<string[]>(type: "text[]", nullable: true),
                    CddField = table.Column<int>(type: "integer", nullable: false),
                    InhalationO2 = table.Column<string[]>(type: "text[]", nullable: true),
                    SpeedFlow = table.Column<int>(type: "integer", nullable: false),
                    Auscultatory = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreath = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreathInput = table.Column<string>(type: "text", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupport = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupportMachine = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOne = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOneInput = table.Column<int>(type: "integer", nullable: false),
                    Hemodynamics = table.Column<string[]>(type: "text[]", nullable: true),
                    Do = table.Column<int>(type: "integer", nullable: false),
                    Cd = table.Column<int>(type: "integer", nullable: false),
                    Pdkv = table.Column<int>(type: "integer", nullable: false),
                    Fio2 = table.Column<int>(type: "integer", nullable: false),
                    Dvdox = table.Column<int>(type: "integer", nullable: false),
                    Dpod = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<int>(type: "integer", nullable: false),
                    Сhss = table.Column<int>(type: "integer", nullable: false),
                    Spo2 = table.Column<int>(type: "integer", nullable: false),
                    Stomach = table.Column<string[]>(type: "text[]", nullable: true),
                    Pain = table.Column<string[]>(type: "text[]", nullable: true),
                    PainAbout = table.Column<string>(type: "text", nullable: true),
                    AbdominalBloating = table.Column<string[]>(type: "text[]", nullable: true),
                    Peristalsis = table.Column<string[]>(type: "text[]", nullable: true),
                    Tongue = table.Column<string[]>(type: "text[]", nullable: true),
                    Diuresis = table.Column<int>(type: "integer", nullable: false),
                    Intravenously = table.Column<int>(type: "integer", nullable: false),
                    Urine = table.Column<string[]>(type: "text[]", nullable: true),
                    BodyTemperature = table.Column<int>(type: "integer", nullable: false),
                    Drainage = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAbout = table.Column<string>(type: "text", nullable: true),
                    Additionally = table.Column<string>(type: "text", nullable: true),
                    DrainageTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAboutTwo = table.Column<string>(type: "text", nullable: true),
                    Laboratory1 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory2 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory3 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory4 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory5 = table.Column<int>(type: "integer", nullable: false),
                    Laboratory6 = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<string[]>(type: "text", nullable: true),
                    PiccoId = table.Column<string>(type: "text", nullable: true),
                    Picco2Id = table.Column<string>(type: "text", nullable: true),
                    FioTracId = table.Column<string>(type: "text", nullable: true),
                    EsCCOId = table.Column<string>(type: "text", nullable: true),
                    VoLEFId = table.Column<string>(type: "text", nullable: true),
                    Analyses = table.Column<int>(type: "integer", nullable: false),
                    AnalysesTwo = table.Column<int>(type: "integer", nullable: false),
                    AnalysesThree = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFour = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFive = table.Column<int>(type: "integer", nullable: false),
                    AnalysesSix = table.Column<int>(type: "integer", nullable: false),
                    Product = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandartDiaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StandartDiaries_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StandartDiaries_EsCCO_EsCCOId",
                        column: x => x.EsCCOId,
                        principalTable: "EsCCO",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StandartDiaries_FioTrac_FioTracId",
                        column: x => x.FioTracId,
                        principalTable: "FioTrac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StandartDiaries_PiCCO_PiccoId",
                        column: x => x.PiccoId,
                        principalTable: "PiCCO",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StandartDiaries_PiCCO2_Picco2Id",
                        column: x => x.Picco2Id,
                        principalTable: "PiCCO2",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StandartDiaries_VoLEF_VoLEFId",
                        column: x => x.VoLEFId,
                        principalTable: "VoLEF",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_EsCCOId",
                table: "StandartDiaries",
                column: "EsCCOId");

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_FioTracId",
                table: "StandartDiaries",
                column: "FioTracId");

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_Picco2Id",
                table: "StandartDiaries",
                column: "Picco2Id");

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_PiccoId",
                table: "StandartDiaries",
                column: "PiccoId");

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_VoLEFId",
                table: "StandartDiaries",
                column: "VoLEFId");

            migrationBuilder.CreateIndex(
                name: "IX_StandartDiaries_DoctorId",
                table: "StandartDiaries",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtubationDiaries");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "StandartDiaries");

            migrationBuilder.DropTable(
                name: "Syndroms");

            migrationBuilder.DropTable(
                name: "WeekendDiaries");

            migrationBuilder.DropTable(
                name: "EsCCO");

            migrationBuilder.DropTable(
                name: "FioTrac");

            migrationBuilder.DropTable(
                name: "PiCCO");

            migrationBuilder.DropTable(
                name: "PiCCO2");

            migrationBuilder.DropTable(
                name: "VoLEF");
        }
    }
}
