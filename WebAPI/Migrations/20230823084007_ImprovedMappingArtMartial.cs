using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class ImprovedMappingArtMartial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamourai");

            migrationBuilder.CreateTable(
                name: "ArtMartialSamourais",
                columns: table => new
                {
                    ArtMartialId = table.Column<int>(type: "integer", nullable: false),
                    SamouraiId = table.Column<int>(type: "integer", nullable: false),
                    ArtMartialsId = table.Column<int>(type: "integer", nullable: false),
                    SamouraisId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamourais", x => new { x.ArtMartialId, x.SamouraiId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourais_ArtMartials_ArtMartialId",
                        column: x => x.ArtMartialId,
                        principalTable: "ArtMartials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourais_Samourai_SamouraiId",
                        column: x => x.SamouraiId,
                        principalTable: "Samourai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 680);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 1765);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 595);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 835);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 1191);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 779);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 214);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 817);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 1617);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1694);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 1600);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 398);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 112);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1718);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 1287);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1807);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 737);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 1186);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 571);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 387);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 536);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 1414);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 874);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 911);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1057);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 932);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 652);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 513);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 1187);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 1529);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 283);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 116);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 1729);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 606);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 1685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 1706);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1211);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 1859);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 159);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 1881);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 1646);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 856);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 628);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1774);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 968);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 838);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 578);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 1437);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 1230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 328);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 1934);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 425);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 1871);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 723);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 533);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 1129);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1046);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 291);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 922);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 640);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 649);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1413);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 996);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 862);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 1163);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 646);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 1614);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 572);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1140);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 871);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 471);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 115);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 1087);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1575);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 271);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 987);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 1186);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 763);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 1513);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 798);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 1040);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1918);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 1254);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 441);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 118);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 252);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 507);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 304);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 466);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1378);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 1478);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1153);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 950);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 1035);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 1164);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 564);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 417);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 383);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 374);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 368);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1294);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 179);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 1433);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1162);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 203);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1796);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 992);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 1733);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 668);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 585);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1223);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1435);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1564);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 175);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 1564);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 1763);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 620);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1061);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1600);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 620);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 446);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 632);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 1463);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1738);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 815);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 627);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 276);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 729);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 1544);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 471);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 1450);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 390);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 642);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1997);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1447);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 218);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 409);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1448);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 717);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 1276);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 747);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 273);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1909);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 886);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 678);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1868);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1081);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 1817);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 352);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 829);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 697);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 396);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 583);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 331);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 838);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 189);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1559);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 1646);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 1077);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 1510);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 756);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1561);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1786);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1895);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 593);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1187);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1044);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 1162);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 515);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 496);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1953);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1885);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1512);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 1958);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1465);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1379);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1390);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1052);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 191);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 1250);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1654);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1974);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 1596);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1629);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 1681);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 940);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 109);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 113);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 803);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1556);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1744);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 1962);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 400);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 823);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 1123);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1629);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 1596);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 561);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1806);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1549);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 652);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 1744);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 465);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 865);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1504);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 589);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 1322);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 609);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1386);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 1191);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 1567);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1736);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 1690);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1013);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1473);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 1038);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1452);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1740);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 93);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 614);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 547);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 302);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1192);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 1805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1966);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 695);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1568);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1588);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1475);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 1683);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1322);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1595);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 759);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1297);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1110);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 176);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 893);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 1598);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 1025);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 364);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 1828);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1875);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 1450);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1688);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 207);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 1205);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 1912);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 497);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1190);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1182);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 327);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 1316);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 295);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1771);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 999);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1650);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 910);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1257);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1924);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 1831);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 925);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1114);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1711);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 247);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 676);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 774);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 315);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1372);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1913);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 224);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 837);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1390);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1390);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 1479);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourais_SamouraiId",
                table: "ArtMartialSamourais",
                column: "SamouraiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamourais");

            migrationBuilder.CreateTable(
                name: "ArtMartialSamourai",
                columns: table => new
                {
                    TechniquesId = table.Column<int>(type: "integer", nullable: false),
                    UtilisateursId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamourai", x => new { x.TechniquesId, x.UtilisateursId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_ArtMartials_TechniquesId",
                        column: x => x.TechniquesId,
                        principalTable: "ArtMartials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_Samourai_UtilisateursId",
                        column: x => x.UtilisateursId,
                        principalTable: "Samourai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 1604);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 1307);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 1751);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 1010);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 319);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 1891);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 581);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 992);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 1726);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 1616);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 1665);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1391);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1328);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 1302);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 1992);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 253);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1234);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 797);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 1956);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 533);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 595);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 1126);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 842);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 698);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1496);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 159);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1320);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 290);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1082);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 659);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 409);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1639);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 1440);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 1031);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 137);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1223);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 957);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 476);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1301);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 1348);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1769);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1950);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 871);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 1393);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 882);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 1972);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 696);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 1603);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 1641);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 631);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 1980);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1933);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 1293);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 1065);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 1158);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 898);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 800);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 549);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 703);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 1668);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 929);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 1468);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 387);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1094);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 1923);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 730);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1359);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 1268);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1826);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 1927);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 253);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 1715);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 109);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1920);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 627);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1245);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 228);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 1230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 463);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 378);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 563);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1488);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1178);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 184);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 328);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 1209);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 1108);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 1439);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 758);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1681);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 966);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 575);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1934);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 399);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1986);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 166);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1170);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1246);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 891);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 257);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 391);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 1569);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1801);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 530);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1627);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 1363);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 1116);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 645);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 360);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1837);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 315);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 492);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 1795);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1147);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1542);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 1872);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1903);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 637);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 732);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 263);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 1322);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 772);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1688);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 851);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1933);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1041);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1445);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1739);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 906);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1695);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 1052);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1173);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 596);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 471);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 592);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1103);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 868);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 1286);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 227);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 225);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 860);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 492);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 928);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 391);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 929);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 1062);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 1155);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 966);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 470);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 1128);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1142);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 1282);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1050);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 902);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 240);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1191);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1080);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 1327);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 1677);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 534);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1942);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 356);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 455);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 791);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 905);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 1383);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 497);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 313);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1413);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1450);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 377);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 1067);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 777);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1490);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 616);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 334);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 1932);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 272);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1542);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 860);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1548);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1375);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 754);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 1498);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 1332);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 885);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 627);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1438);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 817);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 674);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1985);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 874);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 1394);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 1609);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 602);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 1876);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 1656);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1245);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 218);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 326);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1487);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 242);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 618);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 285);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1986);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1768);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 491);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 575);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 598);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 1819);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 881);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 1352);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1822);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1160);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 1175);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 1664);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1647);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1915);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 291);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 1321);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 483);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1130);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1058);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 655);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 574);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1471);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1473);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 575);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 1818);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 279);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 790);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1172);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1149);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 982);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 280);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 1743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 1660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 995);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 278);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1572);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 141);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 872);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 612);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1147);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 756);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 525);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 654);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1370);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 285);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 1173);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 617);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 203);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 110);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 1660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1773);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 1754);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 514);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1145);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1349);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 370);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1682);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 791);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1412);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 1668);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourai_UtilisateursId",
                table: "ArtMartialSamourai",
                column: "UtilisateursId");
        }
    }
}
