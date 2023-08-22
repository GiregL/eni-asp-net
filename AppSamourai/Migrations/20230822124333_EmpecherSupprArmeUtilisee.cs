using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class EmpecherSupprArmeUtilisee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes");

            migrationBuilder.DropIndex(
                name: "IX_Armes_IdUtilisateur",
                table: "Armes");

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "IdUtilisateur",
                table: "Armes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Armes_IdUtilisateur",
                table: "Armes",
                column: "IdUtilisateur");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1889, "Abe Masakatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 783, "Adachi Yasumori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 531, "Adachi Kagemori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1124, "Adams William" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1415, "Aiou Mototsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 925, "Akai Terukage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 3, "Akao Kiyotsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 94, "Akechi Mitsuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 213, "Akiyama Nobutomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1894, "Amago Haruhisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1354, "Amago Yoshihisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1002, "Andō Morinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1908, "Ankokuji Ekei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1430, "Aochi Shigetsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1588, "Aokage Takaakira" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1824, "Aoki Kazushige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 779, "Akahori Chohichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 756, "Arai Hakuseki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 823, "Araki Motokiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1474, "Araki Murashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1140, "Araki Muratsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 208, "Arima Kihei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 612, "Asakura Yoshikage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1264, "Ayame Kagekatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 630, "Azai Hisamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 274, "Azai Nagamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1787, "Azai Sukemasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 636, "Baba Nobufusa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 8, "Bessho Nagaharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 38, "Chacha" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 217, "Chiba Shusaku Narimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 734, "Chōsokabe Morichika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1815, "Chōsokabe Kunichika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 121, "Chōsokabe Motochika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 48, "Chōsokabe Nobuchika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 373, "Collache Eugène" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 49, "Date Masamune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1432, "Date Shigezane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 719, "Doi Toshikatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1769, "Etō Shinpei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1290, "Endō Naotsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1668, "Enjoji Nobutane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1129, "Enomoto Takeaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1100, "Era Fusahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1914, "Fūma Kotarō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1082, "Fuwa Mitsuharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1574, "Fukushima Masanori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 623, "Gamō Katahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 600, "Gamō Ujisato" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1394, "Harada Naomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 572, "Harada Nobutane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1119, "Harada Sanosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 746, "Hasekura Tsunenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1557, "Hattori Hanzō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 758, "Hatano Hideharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 452, "Hasegawa Eishin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 713, "Hayashizaki Jinsuke Shigenobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1528, "Hayashi Narinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 206, "Hijikata Toshizo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 236, "Hirate Masahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1800, "Hitotsubashi Keiki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 770, "Hōjō Masako" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 508, "Hōjō Tokimune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1706, "Hōjō Ujiyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 622, "Hōjō Ujimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 608, "Honda Tadakatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 874, "Honda Tadatomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1785, "Honganji Kennyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 530, "Horio Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 846, "Hosokawa Fujitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 234, "Hosokawa Gracia" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 30, "Hosokawa Tadaoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 305, "Hotta Masatoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1097, "Ii Naoaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 818, "Ii Naomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1756, "Ii Naomori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 986, "Ii Naonaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 912, "Ii Naosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 492, "Ii Naotaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1408, "Ii Naotora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1893, "Ii Naoyuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1003, "Ii Naozumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 195, "Iizasa Ienao" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1744, "Ijuin Tadaaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1886, "Ikeda Tsuneoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 784, "Imagawa Ujizane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 421, "Imagawa Yoshimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 409, "Imai Kanehira" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1585, "Inaba Yoshimichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 173, "Inugami Nagayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1596, "Ishida Mitsunari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 187, "Isshiki Fujinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1745, "Itagaki Nobukata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1312, "Itō Hirobumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1088, "Iwanari Tomomichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 424, "Jinbo Nagamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 459, "Jonas Tönse" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1404, "Kannan Kumar(Salem)" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 981, "Kakeda Toshimune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1671, "Kaneko Ietada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1098, "Katagiri Katsumoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1703, "Katakura Kojūro" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1051, "Katakura Shigenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1038, "Kataoka Mitsumasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1605, "Katō Kiyomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 101, "Kawakami Gensai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 180, "Kido Takayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 771, "Kikkawa Hiroie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1273, "Kimotsuki Kanetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1081, "Kitamura Kansuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 101, "Kobayakawa Hideaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 417, "Kobayakawa Hidekane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 784, "Kobayakawa Takakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 72, "Konishi Yukinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1476, "Kojima Toyoharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 457, "Kuroda Kanbei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1066, "Kuroda Kiyotaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1924, "Kusunoki Masashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1717, "Kuwana Tarozaemon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 78, "Kumagai Naozane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 986, "Maeda Keiji" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 541, "Maeda Matsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1942, "Maeda Nagatane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 916, "Maeda Toshiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1619, "Maeda Toshinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1530, "Maeda Toshitsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1341, "Magome Kageyu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 732, "Manabe Akifusa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 353, "Matsudaira Katamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 997, "Matsudaira Nobutsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 259, "Matsudaira Nobuyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1708, "Matsudaira Higo no Kami Katamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 763, "Matsudaira Sadanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1217, "Matsudaira Tadayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 261, "Matsudaira Teru" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1894, "Matsunaga Hisahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 15, "Matsunaga Hisamichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 37, "Matsuo Bashō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1236, "Matsudaira Motoyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 588, "Minamoto no Mitsunaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1856, "Minamoto no Yoshiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1803, "Minamoto no Yoshimitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1146, "Minamoto no Yoshinaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 823, "Minamoto no Yoshitomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1409, "Minamoto no Yoshitsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 230, "Minamoto no Tameyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 174, "Minamoto no Yorimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 856, "Minamoto no Yorimitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 0, "Minamoto no Yoritomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 380, "Minamoto no Noriyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1650, "Minoro Takashi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1892, "Miura Anjin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1071, "Miura Yoshimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 209, "Miyamoto Musashi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 505, "Miyoshi Chōkei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1941, "Miyoshi Kazuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1556, "Miyoshi Masaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 62, "Miyoshi Masayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 588, "Miyoshi Moriyata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1605, "Miyoshi Nagayuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1406, "Miyoshi Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1471, "Mizuno Tadakuni" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 264, "Moniwa Yoshinao" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1107, "Mōri Motonari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 752, "Mōri Nagasada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1161, "Mori Nagayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 489, "Mōri Okimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1347, "Mori Ranmaru" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1995, "Mōri Takamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1993, "Mori Tadamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 679, "Mōri Terumoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1274, "Mori Yoshinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1921, "Murai Sadakatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 365, "Nagakura Shinpachi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 560, "Nagao Harukage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1884, "Nagao Kagenobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 302, "Nagao Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 951, "Nagao Tamekage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 110, "Nakagawa Kiyohide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 943, "Nakaoka Shintarō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 128, "Naoe Kagetsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 262, "Naoe Kanetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 184, "Narita Kaihime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 543, "Nene" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 230, "Nihonmatsu Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1515, "Niimi Nishiki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 606, "Niiro Tadamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 984, "Niwa Nagahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 217, "Niwa Nagashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1401, "Oda Hiroyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 351, "Oda Nobuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 869, "Oda Nobukata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1267, "Oda Nobukiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1270, "Oda Nobunaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 186, "Oda Nobutada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 969, "Oda Nobutomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 995, "Oda Nobukatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 274, "Oda Nobuyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 547, "Ogasawara Shōsai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1053, "Ōishi Kuranosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 781, "Okada Izō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1026, "Judge Ooka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1909, "Ōta Dōkan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1573, "Ōtani Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 16, "Ōtani Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1382, "Ōtomo Sōrin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1477, "Okita Sōji" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 270, "Ōkubo Toshimichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1567, "Okunomiya Masaie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1181, "Ōuchi Yoshitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1777, "Omy Yoshika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1302, "Pore Sufi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 568, "Reizei Takatoyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 751, "Rokkaku Sadayori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 477, "Rokkaku Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 63, "Rokkaku Yoshikata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1275, "Rusu Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1897, "Ryūzōji Takanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 794, "Saigo Kiyokazu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 124, "Saigō Masako" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1780, "Sagara Taketō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1482, "Saigō Takamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1818, "Saigo Yoshikatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 830, "Saitō Dōsan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1338, "Saitō Hajime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 685, "Saito Musashibō Benkei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1778, "Saitō Yoshitatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 810, "Sakai Tadakiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1351, "Sakai Tadashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1496, "Sakai Tadatsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1339, "Sakai Tadayo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1209, "Sakakibara Yasumasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1684, "Sakamoto Ryōma" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 63, "Sakuma Morimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 990, "Sakuma Nobumori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1817, "Sanada Akihime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1684, "Sanada Komatsuhime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1008, "Sanada Masayuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1744, "Sanada Nobuyuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1453, "Sanada Yukimura" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1367, "Sasaki Kojirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 593, "Sassa Narimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1237, "Sasuke Sarutobi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1523, "Serizawa Kamo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 886, "Shibata Katsuie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1909, "Shima Sakon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1509, "Shimada Ichirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1087, "Shimazu Katsuhisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1668, "Shimazu Tadahisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 140, "Shimazu Tadatsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 815, "Shimazu Tadayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1991, "Shimazu Takahisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1487, "Shimazu Toyohisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1980, "Shimazu Yoshihiro" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 745, "Shimazu Yoshihisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1568, "Shindou Hiroshii" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1386, "Sogo Nagayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 763, "Sue Yoshitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1149, "Tachibana Muneshige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1291, "Tachibana Dōsetsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 528, "Tachibana Ginchiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 670, "Taigen Sessai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 852, "Taira no Kiyomori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 860, "Taira Masakado" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1504, "Takahashi Shigetane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 489, "Takenaka Shigeharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 860, "Takasugi Shinsaku" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1677, "Takayama Justo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 789, "Takayama Ukon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1140, "Takechi Hanpeita" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 850, "Takeda Katsuyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1840, "Takeda Nobukatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1470, "Takeda Nobushige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1677, "Takeda Shingen" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 168, "Takenaka Hanbei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 29, "Tani Tadasumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 174, "Tōdō Takatora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 835, "Toki Yorinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1953, "Tochimitsu Gantyoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1518, "Tokugawa Ieyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1044, "Tokugawa Hidetada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 372, "Tokugawa Nariaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 75, "Tokugawa Yoshinobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 525, "Torii Mototada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 838, "Toyotomi Hidenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1385, "Toyotomi Hideyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1899, "Toyotomi Hideyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1117, "Tozuka Tadaharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1261, "Tsukahara Bokuden" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1467, "Uesugi Kagekatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 695, "Uesugi Kagetora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1707, "Uesugi Kenshin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1422, "Ujiie Naotomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 76, "Ukita Naoie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 633, "Ukita Okiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1883, "Umezawa Michiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 82, "Usami Sadamitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 330, "Uyama Hisanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1380, "Wada Shinsuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1855, "Watanabe Kazan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1790, "Watanabe no Tsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 820, "Yasumero Kenshin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1608, "Yagyū Jūbei Mitsuyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 745, "Yagyū Munenori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1111, "Yamauchi Kazutoyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1000, "Yamada Arinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 396, "Yamada Arinobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1698, "Yamada Nagamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1282, "Yamagata Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 713, "Yamakawa Hiroshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1125, "Yamakawa Kenjirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 532, "Yamakawa Naoe" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 36, "Yamanaka Yukimori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1054, "Yamanami Keisuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1731, "Yamaoka Tesshū" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1640, "Yanagawa Kenzaburo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 200, "Yanagisawa Yoshiyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 694, "Yonekura Shigetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 778, "Yūki Hideyasu" });

            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "Force", "IdArme", "Nom" },
                values: new object[] { 321, 751, null, "Yasuke" });

            migrationBuilder.CreateIndex(
                name: "IX_Samourai_IdArme",
                table: "Samourai",
                column: "IdArme",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samourai_Armes_IdArme",
                table: "Samourai",
                column: "IdArme",
                principalTable: "Armes",
                principalColumn: "IdUtilisateur",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samourai_Armes_IdArme",
                table: "Samourai");

            migrationBuilder.DropIndex(
                name: "IX_Samourai_IdArme",
                table: "Samourai");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Armes_IdUtilisateur",
                table: "Armes");

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.AlterColumn<int>(
                name: "IdUtilisateur",
                table: "Armes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 597, "Adachi Yasumori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1602, "Adachi Kagemori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1933, "Adams William" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 537, "Aiou Mototsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 903, "Akai Terukage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1767, "Akao Kiyotsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1300, "Akechi Mitsuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1603, "Akiyama Nobutomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 296, "Amago Haruhisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 871, "Amago Yoshihisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 653, "Andō Morinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1431, "Ankokuji Ekei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1329, "Aochi Shigetsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1566, "Aokage Takaakira" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1785, "Aoki Kazushige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 17, "Akahori Chohichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1319, "Arai Hakuseki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1458, "Araki Motokiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1707, "Araki Murashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1971, "Araki Muratsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1812, "Arima Kihei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1004, "Asakura Yoshikage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 569, "Ayame Kagekatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 222, "Azai Hisamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 990, "Azai Nagamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 88, "Azai Sukemasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 452, "Baba Nobufusa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1536, "Bessho Nagaharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 753, "Chacha" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1051, "Chiba Shusaku Narimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1054, "Chōsokabe Morichika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 403, "Chōsokabe Kunichika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1493, "Chōsokabe Motochika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1211, "Chōsokabe Nobuchika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 989, "Collache Eugène" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 659, "Date Masamune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 770, "Date Shigezane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1390, "Doi Toshikatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1973, "Etō Shinpei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1733, "Endō Naotsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1632, "Enjoji Nobutane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 366, "Enomoto Takeaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1618, "Era Fusahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 95, "Fūma Kotarō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 422, "Fuwa Mitsuharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1784, "Fukushima Masanori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1676, "Gamō Katahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 414, "Gamō Ujisato" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1936, "Harada Naomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 238, "Harada Nobutane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1632, "Harada Sanosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1727, "Hasekura Tsunenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1501, "Hattori Hanzō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 379, "Hatano Hideharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1087, "Hasegawa Eishin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 655, "Hayashizaki Jinsuke Shigenobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1708, "Hayashi Narinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1417, "Hijikata Toshizo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 563, "Hirate Masahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1794, "Hitotsubashi Keiki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 34, "Hōjō Masako" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1541, "Hōjō Tokimune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1163, "Hōjō Ujiyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1882, "Hōjō Ujimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1021, "Honda Tadakatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1391, "Honda Tadatomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1965, "Honganji Kennyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1128, "Horio Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1191, "Hosokawa Fujitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 898, "Hosokawa Gracia" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1070, "Hosokawa Tadaoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1840, "Hotta Masatoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 174, "Ii Naoaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 784, "Ii Naomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 291, "Ii Naomori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1281, "Ii Naonaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1745, "Ii Naosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 367, "Ii Naotaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 684, "Ii Naotora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 765, "Ii Naoyuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1249, "Ii Naozumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 530, "Iizasa Ienao" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1947, "Ijuin Tadaaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 310, "Ikeda Tsuneoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1095, "Imagawa Ujizane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 507, "Imagawa Yoshimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 849, "Imai Kanehira" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1003, "Inaba Yoshimichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 610, "Inugami Nagayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 757, "Ishida Mitsunari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 960, "Isshiki Fujinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1660, "Itagaki Nobukata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1485, "Itō Hirobumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1730, "Iwanari Tomomichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1360, "Jinbo Nagamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1533, "Jonas Tönse" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 689, "Kannan Kumar(Salem)" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 814, "Kakeda Toshimune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 782, "Kaneko Ietada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 400, "Katagiri Katsumoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 993, "Katakura Kojūro" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 539, "Katakura Shigenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 745, "Kataoka Mitsumasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1105, "Katō Kiyomasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1196, "Kawakami Gensai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1911, "Kido Takayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1907, "Kikkawa Hiroie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1952, "Kimotsuki Kanetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1086, "Kitamura Kansuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1619, "Kobayakawa Hideaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 689, "Kobayakawa Hidekane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1628, "Kobayakawa Takakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 50, "Konishi Yukinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 551, "Kojima Toyoharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 225, "Kuroda Kanbei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 809, "Kuroda Kiyotaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 884, "Kusunoki Masashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 913, "Kuwana Tarozaemon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1978, "Kumagai Naozane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1299, "Maeda Keiji" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 79, "Maeda Matsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 890, "Maeda Nagatane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 401, "Maeda Toshiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 255, "Maeda Toshinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 782, "Maeda Toshitsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1213, "Magome Kageyu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1621, "Manabe Akifusa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 930, "Matsudaira Katamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 934, "Matsudaira Nobutsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1004, "Matsudaira Nobuyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1561, "Matsudaira Higo no Kami Katamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 894, "Matsudaira Sadanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1672, "Matsudaira Tadayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1772, "Matsudaira Teru" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 520, "Matsunaga Hisahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1987, "Matsunaga Hisamichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 970, "Matsuo Bashō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 186, "Matsudaira Motoyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1905, "Minamoto no Mitsunaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1071, "Minamoto no Yoshiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1208, "Minamoto no Yoshimitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1526, "Minamoto no Yoshinaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 217, "Minamoto no Yoshitomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 215, "Minamoto no Yoshitsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 280, "Minamoto no Tameyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 302, "Minamoto no Yorimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1813, "Minamoto no Yorimitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1726, "Minamoto no Yoritomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 571, "Minamoto no Noriyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 787, "Minoro Takashi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1108, "Miura Anjin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1093, "Miura Yoshimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 219, "Miyamoto Musashi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 464, "Miyoshi Chōkei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1281, "Miyoshi Kazuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1933, "Miyoshi Masaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 226, "Miyoshi Masayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 100, "Miyoshi Moriyata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1159, "Miyoshi Nagayuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1265, "Miyoshi Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 500, "Mizuno Tadakuni" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1820, "Moniwa Yoshinao" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1078, "Mōri Motonari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1959, "Mōri Nagasada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 220, "Mori Nagayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 27, "Mōri Okimoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 745, "Mori Ranmaru" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 498, "Mōri Takamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 774, "Mori Tadamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1227, "Mōri Terumoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 961, "Mori Yoshinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1650, "Murai Sadakatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 435, "Nagakura Shinpachi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1891, "Nagao Harukage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1042, "Nagao Kagenobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1611, "Nagao Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1717, "Nagao Tamekage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1642, "Nakagawa Kiyohide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1518, "Nakaoka Shintarō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1392, "Naoe Kagetsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1429, "Naoe Kanetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 194, "Narita Kaihime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 445, "Nene" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 282, "Nihonmatsu Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1802, "Niimi Nishiki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 185, "Niiro Tadamoto" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1313, "Niwa Nagahide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 613, "Niwa Nagashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 160, "Oda Hiroyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1256, "Oda Nobuhide" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 226, "Oda Nobukata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1044, "Oda Nobukiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 867, "Oda Nobunaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1164, "Oda Nobutada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 247, "Oda Nobutomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 590, "Oda Nobukatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 810, "Oda Nobuyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 313, "Ogasawara Shōsai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1167, "Ōishi Kuranosuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 880, "Okada Izō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1122, "Judge Ooka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 615, "Ōta Dōkan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 177, "Ōtani Yoshitsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 12, "Ōtani Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1257, "Ōtomo Sōrin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 748, "Okita Sōji" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1266, "Ōkubo Toshimichi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 616, "Okunomiya Masaie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1812, "Ōuchi Yoshitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 814, "Omy Yoshika" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 324, "Pore Sufi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 148, "Reizei Takatoyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1025, "Rokkaku Sadayori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1187, "Rokkaku Yoshiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 158, "Rokkaku Yoshikata" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 964, "Rusu Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1250, "Ryūzōji Takanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 878, "Saigo Kiyokazu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1287, "Saigō Masako" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1134, "Sagara Taketō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1219, "Saigō Takamori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1080, "Saigo Yoshikatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 774, "Saitō Dōsan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 892, "Saitō Hajime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 669, "Saito Musashibō Benkei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1417, "Saitō Yoshitatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1468, "Sakai Tadakiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1039, "Sakai Tadashige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1478, "Sakai Tadatsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 317, "Sakai Tadayo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 398, "Sakakibara Yasumasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 240, "Sakamoto Ryōma" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1841, "Sakuma Morimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 479, "Sakuma Nobumori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1425, "Sanada Akihime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1277, "Sanada Komatsuhime" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1244, "Sanada Masayuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1032, "Sanada Nobuyuki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 36, "Sanada Yukimura" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1202, "Sasaki Kojirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 66, "Sassa Narimasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1434, "Sasuke Sarutobi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 204, "Serizawa Kamo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1116, "Shibata Katsuie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 578, "Shima Sakon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 552, "Shimada Ichirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1299, "Shimazu Katsuhisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1517, "Shimazu Tadahisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 179, "Shimazu Tadatsune" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1365, "Shimazu Tadayoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1692, "Shimazu Takahisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1459, "Shimazu Toyohisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 191, "Shimazu Yoshihiro" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 325, "Shimazu Yoshihisa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1655, "Shindou Hiroshii" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1511, "Sogo Nagayasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1802, "Sue Yoshitaka" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 914, "Tachibana Muneshige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1256, "Tachibana Dōsetsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 475, "Tachibana Ginchiyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1174, "Taigen Sessai" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1480, "Taira no Kiyomori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 606, "Taira Masakado" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1128, "Takahashi Shigetane" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 286, "Takenaka Shigeharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 244, "Takasugi Shinsaku" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 954, "Takayama Justo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1976, "Takayama Ukon" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 299, "Takechi Hanpeita" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1885, "Takeda Katsuyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1389, "Takeda Nobukatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 658, "Takeda Nobushige" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1197, "Takeda Shingen" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 435, "Takenaka Hanbei" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1607, "Tani Tadasumi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1468, "Tōdō Takatora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 110, "Toki Yorinari" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1641, "Tochimitsu Gantyoki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1357, "Tokugawa Ieyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 161, "Tokugawa Hidetada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 958, "Tokugawa Nariaki" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1634, "Tokugawa Yoshinobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1813, "Torii Mototada" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1153, "Toyotomi Hidenaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1389, "Toyotomi Hideyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 956, "Toyotomi Hideyori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1896, "Tozuka Tadaharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1063, "Tsukahara Bokuden" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 781, "Uesugi Kagekatsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1766, "Uesugi Kagetora" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1827, "Uesugi Kenshin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 149, "Ujiie Naotomo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 287, "Ukita Naoie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 101, "Ukita Okiie" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1713, "Umezawa Michiharu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1541, "Usami Sadamitsu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 735, "Uyama Hisanobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1885, "Wada Shinsuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1895, "Watanabe Kazan" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 841, "Watanabe no Tsuna" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 539, "Yasumero Kenshin" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1874, "Yagyū Jūbei Mitsuyoshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1845, "Yagyū Munenori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 540, "Yamauchi Kazutoyo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 332, "Yamada Arinaga" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1919, "Yamada Arinobu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1629, "Yamada Nagamasa" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 960, "Yamagata Masakage" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 789, "Yamakawa Hiroshi" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1518, "Yamakawa Kenjirō" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1539, "Yamakawa Naoe" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1591, "Yamanaka Yukimori" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 747, "Yamanami Keisuke" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1468, "Yamaoka Tesshū" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 414, "Yanagawa Kenzaburo" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 112, "Yanagisawa Yoshiyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 885, "Yonekura Shigetsugu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 1934, "Yūki Hideyasu" });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Force", "Nom" },
                values: new object[] { 72, "Yasuke" });

            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "Force", "IdArme", "Nom" },
                values: new object[] { 1, 201, null, "Abe Masakatsu" });

            migrationBuilder.CreateIndex(
                name: "IX_Armes_IdUtilisateur",
                table: "Armes",
                column: "IdUtilisateur",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes",
                column: "IdUtilisateur",
                principalTable: "Samourai",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
