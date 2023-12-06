using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    MedSedation = table.Column<string>(type: "text", nullable: true),
                    MuscleTone = table.Column<string>(type: "text", nullable: true),
                    Insuflation = table.Column<string>(type: "text", nullable: true),
                    Sat = table.Column<string>(type: "text", nullable: true),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Chss = table.Column<string>(type: "text", nullable: true),
                    Doctor = table.Column<string[]>(type: "text[]", nullable: true)
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
                name: "ReceptionEpicrises",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Time = table.Column<TimeSpan>(type: "interval", nullable: false),
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
                    Doctor = table.Column<string[]>(type: "text[]", nullable: true),
                    DoctorTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    Patient = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<string>(type: "text", nullable: true),
                    Day = table.Column<string>(type: "text", nullable: true),
                    OperationDay = table.Column<string>(type: "text", nullable: true),
                    Сonditions = table.Column<string[]>(type: "text[]", nullable: true),
                    Сomplaints = table.Column<string[]>(type: "text[]", nullable: true),
                    ComplaintsAbout = table.Column<string>(type: "text", nullable: true),
                    Conscience = table.Column<string[]>(type: "text[]", nullable: true),
                    GcsSum = table.Column<string>(type: "text", nullable: true),
                    RassThis = table.Column<string>(type: "text", nullable: true),
                    Rass = table.Column<string[]>(type: "text[]", nullable: true),
                    Neurologist = table.Column<string>(type: "text", nullable: true),
                    GcsOne = table.Column<string>(type: "text", nullable: true),
                    GcsTwo = table.Column<string>(type: "text", nullable: true),
                    GcsThree = table.Column<string>(type: "text", nullable: true),
                    Skin = table.Column<string[]>(type: "text[]", nullable: true),
                    Breathing = table.Column<string[]>(type: "text[]", nullable: true),
                    Extubation = table.Column<string[]>(type: "text[]", nullable: true),
                    CddField = table.Column<string>(type: "text", nullable: true),
                    InhalationO2 = table.Column<string[]>(type: "text[]", nullable: true),
                    SpeedFlow = table.Column<string>(type: "text", nullable: true),
                    Auscultatory = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreath = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreathInput = table.Column<string>(type: "text", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupport = table.Column<string[]>(type: "text[]", nullable: true),
                    Do = table.Column<string>(type: "text", nullable: true),
                    Cd = table.Column<string>(type: "text", nullable: true),
                    Pdkv = table.Column<string>(type: "text", nullable: true),
                    Fio2 = table.Column<string>(type: "text", nullable: true),
                    Dvdox = table.Column<string>(type: "text", nullable: true),
                    Dpod = table.Column<string>(type: "text", nullable: true),
                    Hemodynamics = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOne = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOneInput = table.Column<string>(type: "text", nullable: true),
                    InotropicSupportTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportTwoInput = table.Column<string>(type: "text", nullable: true),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Сhss = table.Column<string>(type: "text", nullable: true),
                    Spo2 = table.Column<string>(type: "text", nullable: true),
                    Stomach = table.Column<string[]>(type: "text[]", nullable: true),
                    Pain = table.Column<string[]>(type: "text[]", nullable: true),
                    PainAbout = table.Column<string>(type: "text", nullable: true),
                    AbdominalBloating = table.Column<string[]>(type: "text[]", nullable: true),
                    Peristalsis = table.Column<string[]>(type: "text[]", nullable: true),
                    Tongue = table.Column<string[]>(type: "text[]", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Urine = table.Column<string[]>(type: "text[]", nullable: true),
                    BodyTemperature = table.Column<string>(type: "text", nullable: true),
                    Drainage = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAbout = table.Column<string>(type: "text", nullable: true),
                    Additionally = table.Column<string>(type: "text", nullable: true),
                    SeverityOfCondition = table.Column<string>(type: "text", nullable: true),
                    Laboratory1 = table.Column<string>(type: "text", nullable: true),
                    Laboratory2 = table.Column<string>(type: "text", nullable: true),
                    Laboratory3 = table.Column<string>(type: "text", nullable: true),
                    Laboratory4 = table.Column<string>(type: "text", nullable: true),
                    Laboratory5 = table.Column<string>(type: "text", nullable: true),
                    Laboratory6 = table.Column<string>(type: "text", nullable: true),
                    Recommended = table.Column<string>(type: "text", nullable: true),
                    Analyses = table.Column<int>(type: "integer", nullable: false),
                    AnalysesTwo = table.Column<int>(type: "integer", nullable: false),
                    AnalysesThree = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFour = table.Column<int>(type: "integer", nullable: false),
                    AnalysesFive = table.Column<int>(type: "integer", nullable: false),
                    AnalysesSix = table.Column<int>(type: "integer", nullable: false),
                    BioChemistry = table.Column<string>(type: "text", nullable: true),
                    BioChemistry2 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry3 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry4 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry5 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry6 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry7 = table.Column<string>(type: "text", nullable: true),
                    BioChemistry8 = table.Column<string>(type: "text", nullable: true),
                    Hemostasis = table.Column<string>(type: "text", nullable: true),
                    Hemostasis2 = table.Column<string>(type: "text", nullable: true),
                    Hemostasis3 = table.Column<string>(type: "text", nullable: true),
                    Kshs = table.Column<string>(type: "text", nullable: true),
                    Kshs2 = table.Column<string>(type: "text", nullable: true),
                    Kshs3 = table.Column<string>(type: "text", nullable: true),
                    Kshs4 = table.Column<string>(type: "text", nullable: true),
                    Kshs5 = table.Column<string>(type: "text", nullable: true),
                    Kshs6 = table.Column<string>(type: "text", nullable: true),
                    Kshs7 = table.Column<string>(type: "text", nullable: true),
                    Kshs8 = table.Column<string>(type: "text", nullable: true),
                    Kshs9 = table.Column<string>(type: "text", nullable: true),
                    Picco = table.Column<string>(type: "text", nullable: true),
                    Picco2 = table.Column<string>(type: "text", nullable: true),
                    Picco3 = table.Column<string>(type: "text", nullable: true),
                    Picco4 = table.Column<string>(type: "text", nullable: true),
                    Picco5 = table.Column<string>(type: "text", nullable: true),
                    Picco6 = table.Column<string>(type: "text", nullable: true),
                    Picco7 = table.Column<string>(type: "text", nullable: true),
                    Picco8 = table.Column<string>(type: "text", nullable: true),
                    Picco9 = table.Column<string>(type: "text", nullable: true),
                    Picco10 = table.Column<string>(type: "text", nullable: true),
                    Picco11 = table.Column<string>(type: "text", nullable: true),
                    Analyses1 = table.Column<int>(type: "integer", nullable: false),
                    Analyses2 = table.Column<int>(type: "integer", nullable: false),
                    Analyses3 = table.Column<int>(type: "integer", nullable: false)
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
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
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
                    CddField = table.Column<string>(type: "text", nullable: true),
                    InhalationO2 = table.Column<string[]>(type: "text[]", nullable: true),
                    SpeedFlow = table.Column<string>(type: "text", nullable: true),
                    Auscultatory = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreath = table.Column<string[]>(type: "text[]", nullable: true),
                    ShortnessOfBreathInput = table.Column<string>(type: "text", nullable: true),
                    Wheezes = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupport = table.Column<string[]>(type: "text[]", nullable: true),
                    RespiratorySupportMachine = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOne = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportOneInput = table.Column<string>(type: "text", nullable: true),
                    InotropicSupportTwo = table.Column<string[]>(type: "text[]", nullable: true),
                    Hemodynamics = table.Column<string[]>(type: "text[]", nullable: true),
                    InotropicSupportTwoInput = table.Column<string>(type: "text", nullable: true),
                    Do = table.Column<string>(type: "text", nullable: true),
                    Cd = table.Column<string>(type: "text", nullable: true),
                    Pdkv = table.Column<string>(type: "text", nullable: true),
                    Fio2 = table.Column<string>(type: "text", nullable: true),
                    Dvdox = table.Column<string>(type: "text", nullable: true),
                    Dpod = table.Column<string>(type: "text", nullable: true),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Сhss = table.Column<string>(type: "text", nullable: true),
                    Spo2 = table.Column<string>(type: "text", nullable: true),
                    Stomach = table.Column<string[]>(type: "text[]", nullable: true),
                    Pain = table.Column<string[]>(type: "text[]", nullable: true),
                    PainAbout = table.Column<string>(type: "text", nullable: true),
                    AbdominalBloating = table.Column<string[]>(type: "text[]", nullable: true),
                    Peristalsis = table.Column<string[]>(type: "text[]", nullable: true),
                    Tongue = table.Column<string[]>(type: "text[]", nullable: true),
                    Diuresis = table.Column<string>(type: "text", nullable: true),
                    Intravenously = table.Column<string>(type: "text", nullable: true),
                    Urine = table.Column<string[]>(type: "text[]", nullable: true),
                    BodyTemperature = table.Column<string>(type: "text", nullable: true),
                    Drainage = table.Column<string[]>(type: "text[]", nullable: true),
                    DrinageAbout = table.Column<string>(type: "text", nullable: true),
                    Additionally = table.Column<string>(type: "text", nullable: true),
                    Laboratory1 = table.Column<string>(type: "text", nullable: true),
                    Laboratory2 = table.Column<string>(type: "text", nullable: true),
                    Laboratory3 = table.Column<string>(type: "text", nullable: true),
                    Laboratory4 = table.Column<string>(type: "text", nullable: true),
                    Laboratory5 = table.Column<string>(type: "text", nullable: true),
                    Laboratory6 = table.Column<string>(type: "text", nullable: true),
                    Doctor = table.Column<string[]>(type: "text[]", nullable: true),
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
                    AnalysesSix = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandartDiaries", x => x.Id);
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
                name: "IX_ReceptionEpicrises_DoctorId",
                table: "ReceptionEpicrises",
                column: "DoctorId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtubationDiaries");

            migrationBuilder.DropTable(
                name: "ReceptionEpicrises");

            migrationBuilder.DropTable(
                name: "StandartDiaries");

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
