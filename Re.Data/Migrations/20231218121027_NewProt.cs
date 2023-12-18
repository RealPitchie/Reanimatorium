using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Re.Data.Migrations
{
    public partial class NewProt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_ArteriaIndications_ArteriaProtocol_IndicationsId",
                table: "Protocols");

            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_CentralVeinIndications_IndicationsId",
                table: "Protocols");

            migrationBuilder.RenameColumn(
                name: "IndicationsId",
                table: "Protocols",
                newName: "EpiduralSpaceIndicationsId");

            migrationBuilder.RenameColumn(
                name: "ArteriaProtocol_IndicationsId",
                table: "Protocols",
                newName: "CentralVeinIndicationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Protocols_IndicationsId",
                table: "Protocols",
                newName: "IX_Protocols_EpiduralSpaceIndicationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Protocols_ArteriaProtocol_IndicationsId",
                table: "Protocols",
                newName: "IX_Protocols_CentralVeinIndicationsId");

            migrationBuilder.AddColumn<string>(
                name: "ArteriaIndicationsId",
                table: "Protocols",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EpiduralSpaceIndications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AllowPostoperativeAnesthesia = table.Column<bool>(type: "boolean", nullable: false),
                    AllowPainSyndromeTreatment = table.Column<bool>(type: "boolean", nullable: false),
                    AllowAcutePancreatitisTreatment = table.Column<bool>(type: "boolean", nullable: false),
                    AllowIntestinalStimulation = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpiduralSpaceIndications", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_ArteriaIndicationsId",
                table: "Protocols",
                column: "ArteriaIndicationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_ArteriaIndications_ArteriaIndicationsId",
                table: "Protocols",
                column: "ArteriaIndicationsId",
                principalTable: "ArteriaIndications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_CentralVeinIndications_CentralVeinIndicationsId",
                table: "Protocols",
                column: "CentralVeinIndicationsId",
                principalTable: "CentralVeinIndications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_EpiduralSpaceIndications_EpiduralSpaceIndications~",
                table: "Protocols",
                column: "EpiduralSpaceIndicationsId",
                principalTable: "EpiduralSpaceIndications",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_ArteriaIndications_ArteriaIndicationsId",
                table: "Protocols");

            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_CentralVeinIndications_CentralVeinIndicationsId",
                table: "Protocols");

            migrationBuilder.DropForeignKey(
                name: "FK_Protocols_EpiduralSpaceIndications_EpiduralSpaceIndications~",
                table: "Protocols");

            migrationBuilder.DropTable(
                name: "EpiduralSpaceIndications");

            migrationBuilder.DropIndex(
                name: "IX_Protocols_ArteriaIndicationsId",
                table: "Protocols");

            migrationBuilder.DropColumn(
                name: "ArteriaIndicationsId",
                table: "Protocols");

            migrationBuilder.RenameColumn(
                name: "EpiduralSpaceIndicationsId",
                table: "Protocols",
                newName: "IndicationsId");

            migrationBuilder.RenameColumn(
                name: "CentralVeinIndicationsId",
                table: "Protocols",
                newName: "ArteriaProtocol_IndicationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Protocols_EpiduralSpaceIndicationsId",
                table: "Protocols",
                newName: "IX_Protocols_IndicationsId");

            migrationBuilder.RenameIndex(
                name: "IX_Protocols_CentralVeinIndicationsId",
                table: "Protocols",
                newName: "IX_Protocols_ArteriaProtocol_IndicationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_ArteriaIndications_ArteriaProtocol_IndicationsId",
                table: "Protocols",
                column: "ArteriaProtocol_IndicationsId",
                principalTable: "ArteriaIndications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Protocols_CentralVeinIndications_IndicationsId",
                table: "Protocols",
                column: "IndicationsId",
                principalTable: "CentralVeinIndications",
                principalColumn: "Id");
        }
    }
}
