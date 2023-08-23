using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_TechniquesId",
                table: "ArtMartialSamourai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtMartial",
                table: "ArtMartial");

            migrationBuilder.RenameTable(
                name: "ArtMartial",
                newName: "ArtMartials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtMartials",
                table: "ArtMartials",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 1490);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 354);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 1914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 253);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 676);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1078);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 1528);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 283);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 390);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 1487);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 1701);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 759);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 1532);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1912);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 183);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 908);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 1238);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 1271);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 686);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 620);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 1458);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 996);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 913);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1568);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 666);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 1112);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1704);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 1334);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 693);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1126);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 1082);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 901);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 281);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 1436);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 1628);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 1543);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1802);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 377);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 181);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1148);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 835);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 733);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 502);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 1539);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 1046);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 287);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 836);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 540);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 954);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 1237);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 1757);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 1003);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 327);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 907);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 239);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 1882);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 177);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 1780);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 1149);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 1273);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 1453);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 337);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1236);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 536);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 373);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 878);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1664);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 1295);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1499);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 966);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 294);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 391);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 636);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 700);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 379);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 945);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 477);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 1581);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 279);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 1521);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 796);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 606);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 924);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 1590);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 129);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 642);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 1403);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 847);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 577);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 1379);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 1242);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1599);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1259);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1367);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1089);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 1728);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 1354);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 343);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 348);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 411);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1082);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 178);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 795);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 161);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 517);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1275);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1379);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 1719);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 170);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 382);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1930);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1459);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 466);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 1983);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1899);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1366);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 751);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1749);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 844);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 991);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1366);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 1947);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1426);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 457);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 688);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 327);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 845);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1949);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 749);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 386);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1658);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 788);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 513);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 852);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1986);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1022);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1463);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 396);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 552);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 1376);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 1053);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 1772);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1468);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 830);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 1299);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 994);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 725);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1756);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 854);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 1384);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1978);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 425);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 995);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 1730);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 295);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1872);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 315);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1916);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1195);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1496);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 1852);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 967);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1405);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1723);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1589);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 309);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 1155);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1461);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 1998);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 709);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 169);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1807);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 888);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 776);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 788);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1505);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1940);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 866);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 1727);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 305);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 1681);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 368);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1958);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 845);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 1720);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 594);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 411);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 779);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 348);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 898);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 654);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1251);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 795);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 101);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1475);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1602);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1505);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 740);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 1527);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 958);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 750);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 340);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 480);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 710);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 248);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 474);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 313);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 563);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 1725);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 943);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 1643);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1347);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 740);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 506);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1809);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1605);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 764);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 221);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1786);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1553);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1912);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 1972);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 1607);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 1834);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1645);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 1596);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1887);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1614);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 109);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 396);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 630);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 945);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 791);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 1529);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 301);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 203);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1871);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1399);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1858);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1373);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 263);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1224);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 836);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 181);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1571);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 1195);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1581);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1406);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 461);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1967);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 778);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 296);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 560);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1752);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1556);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 1554);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1669);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1729);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 1161);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartials_TechniquesId",
                table: "ArtMartialSamourai",
                column: "TechniquesId",
                principalTable: "ArtMartials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartials_TechniquesId",
                table: "ArtMartialSamourai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtMartials",
                table: "ArtMartials");

            migrationBuilder.RenameTable(
                name: "ArtMartials",
                newName: "ArtMartial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtMartial",
                table: "ArtMartial",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 728);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 285);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 382);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 899);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 1560);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 632);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 536);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 415);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 860);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 1060);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 635);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 1939);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 1164);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1522);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 245);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1799);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 1105);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 595);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 1336);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 1785);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 1518);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 487);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 1874);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 480);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1956);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 540);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 727);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 1465);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 1554);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 778);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 521);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 1608);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 449);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1460);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 1982);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 1759);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 959);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1863);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 1701);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 411);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 1495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 417);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1412);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 1911);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1171);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1244);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 382);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 1096);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 903);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 1782);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 307);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 754);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 1397);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1351);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 1546);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 277);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 1514);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1626);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 1120);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 913);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 1932);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1202);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 1615);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 662);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 947);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 1228);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1104);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 1342);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1746);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 436);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1056);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 1763);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 1785);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1780);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 654);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 757);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 1846);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1751);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 770);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 577);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 714);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1386);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 585);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 890);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1346);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 717);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 338);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1598);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 479);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1393);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1538);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 237);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 993);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 990);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1191);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1132);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 920);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 765);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1068);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 181);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1844);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 1252);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1051);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 1759);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 204);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 1899);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 1850);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 753);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 606);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 787);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 721);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 627);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1994);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 1429);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 1920);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1980);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 362);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 402);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 855);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 264);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 257);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 980);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 811);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 1342);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1232);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1596);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1901);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1365);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 332);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 337);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1184);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 1563);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 731);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 1317);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 748);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1930);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 1754);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1979);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1547);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1445);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 901);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1538);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1968);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 1352);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 1604);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 1905);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1563);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 983);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 418);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 343);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 1337);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 724);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1037);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 1548);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1125);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1202);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 1451);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1817);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1449);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 1744);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 904);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1738);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1312);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 994);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 507);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1520);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 1257);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 1997);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1721);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 177);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1268);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1400);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1885);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 1357);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 702);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1724);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1260);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1152);

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
                value: 625);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 331);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 930);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 1289);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1862);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 1054);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 114);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 1997);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 331);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 878);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 1193);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 425);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1713);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 804);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 320);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 1046);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 1991);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 326);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1702);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1641);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 366);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1093);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 1783);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1777);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1731);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 1206);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 228);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1720);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 267);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1122);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 1282);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1741);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1133);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1966);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 122);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1842);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1874);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 650);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 558);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 551);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 305);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1693);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 201);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 732);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 356);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 613);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1275);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 1424);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 119);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1332);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 438);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1938);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 895);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 960);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 444);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 272);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 267);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1304);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 1805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 760);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1712);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 551);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 1674);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 1489);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 1198);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1641);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1494);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 1597);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 816);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1729);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 709);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1183);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 1266);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 488);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 645);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 177);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 1810);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 367);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1720);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 380);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 1825);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1497);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 1275);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 1252);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1448);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1763);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 891);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 408);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 1972);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 918);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1315);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 1535);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_TechniquesId",
                table: "ArtMartialSamourai",
                column: "TechniquesId",
                principalTable: "ArtMartial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
