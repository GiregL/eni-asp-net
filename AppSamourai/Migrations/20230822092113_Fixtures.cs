using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class Fixtures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "Force", "IdArme", "Nom" },
                values: new object[,]
                {
                    { 1, 201, null, "Abe Masakatsu" },
                    { 2, 597, null, "Adachi Yasumori" },
                    { 3, 1602, null, "Adachi Kagemori" },
                    { 4, 1933, null, "Adams William" },
                    { 5, 537, null, "Aiou Mototsuna" },
                    { 6, 903, null, "Akai Terukage" },
                    { 7, 1767, null, "Akao Kiyotsuna" },
                    { 8, 1300, null, "Akechi Mitsuhide" },
                    { 9, 1603, null, "Akiyama Nobutomo" },
                    { 10, 296, null, "Amago Haruhisa" },
                    { 11, 871, null, "Amago Yoshihisa" },
                    { 12, 653, null, "Andō Morinari" },
                    { 13, 1431, null, "Ankokuji Ekei" },
                    { 14, 1329, null, "Aochi Shigetsuna" },
                    { 15, 1566, null, "Aokage Takaakira" },
                    { 16, 1785, null, "Aoki Kazushige" },
                    { 17, 17, null, "Akahori Chohichi" },
                    { 18, 1319, null, "Arai Hakuseki" },
                    { 19, 1458, null, "Araki Motokiyo" },
                    { 20, 1707, null, "Araki Murashige" },
                    { 21, 1971, null, "Araki Muratsugu" },
                    { 22, 1812, null, "Arima Kihei" },
                    { 23, 1004, null, "Asakura Yoshikage" },
                    { 24, 569, null, "Ayame Kagekatsu" },
                    { 25, 222, null, "Azai Hisamasa" },
                    { 26, 990, null, "Azai Nagamasa" },
                    { 27, 88, null, "Azai Sukemasa" },
                    { 28, 452, null, "Baba Nobufusa" },
                    { 29, 1536, null, "Bessho Nagaharu" },
                    { 30, 753, null, "Chacha" },
                    { 31, 1051, null, "Chiba Shusaku Narimasa" },
                    { 32, 1054, null, "Chōsokabe Morichika" },
                    { 33, 403, null, "Chōsokabe Kunichika" },
                    { 34, 1493, null, "Chōsokabe Motochika" },
                    { 35, 1211, null, "Chōsokabe Nobuchika" },
                    { 36, 989, null, "Collache Eugène" },
                    { 37, 659, null, "Date Masamune" },
                    { 38, 770, null, "Date Shigezane" },
                    { 39, 1390, null, "Doi Toshikatsu" },
                    { 40, 1973, null, "Etō Shinpei" },
                    { 41, 1733, null, "Endō Naotsune" },
                    { 42, 1632, null, "Enjoji Nobutane" },
                    { 43, 366, null, "Enomoto Takeaki" },
                    { 44, 1618, null, "Era Fusahide" },
                    { 45, 95, null, "Fūma Kotarō" },
                    { 46, 422, null, "Fuwa Mitsuharu" },
                    { 47, 1784, null, "Fukushima Masanori" },
                    { 48, 1676, null, "Gamō Katahide" },
                    { 49, 414, null, "Gamō Ujisato" },
                    { 50, 1936, null, "Harada Naomasa" },
                    { 51, 238, null, "Harada Nobutane" },
                    { 52, 1632, null, "Harada Sanosuke" },
                    { 53, 1727, null, "Hasekura Tsunenaga" },
                    { 54, 1501, null, "Hattori Hanzō" },
                    { 55, 379, null, "Hatano Hideharu" },
                    { 56, 1087, null, "Hasegawa Eishin" },
                    { 57, 655, null, "Hayashizaki Jinsuke Shigenobu" },
                    { 58, 1708, null, "Hayashi Narinaga" },
                    { 59, 1417, null, "Hijikata Toshizo" },
                    { 60, 563, null, "Hirate Masahide" },
                    { 61, 1794, null, "Hitotsubashi Keiki" },
                    { 62, 34, null, "Hōjō Masako" },
                    { 63, 1541, null, "Hōjō Tokimune" },
                    { 64, 1163, null, "Hōjō Ujiyasu" },
                    { 65, 1882, null, "Hōjō Ujimasa" },
                    { 66, 1021, null, "Honda Tadakatsu" },
                    { 67, 1391, null, "Honda Tadatomo" },
                    { 68, 1965, null, "Honganji Kennyo" },
                    { 69, 1128, null, "Horio Yoshiharu" },
                    { 70, 1191, null, "Hosokawa Fujitaka" },
                    { 71, 898, null, "Hosokawa Gracia" },
                    { 72, 1070, null, "Hosokawa Tadaoki" },
                    { 73, 1840, null, "Hotta Masatoshi" },
                    { 74, 174, null, "Ii Naoaki" },
                    { 75, 784, null, "Ii Naomasa" },
                    { 76, 291, null, "Ii Naomori" },
                    { 77, 1281, null, "Ii Naonaka" },
                    { 78, 1745, null, "Ii Naosuke" },
                    { 79, 367, null, "Ii Naotaka" },
                    { 80, 684, null, "Ii Naotora" },
                    { 81, 765, null, "Ii Naoyuki" },
                    { 82, 1249, null, "Ii Naozumi" },
                    { 83, 530, null, "Iizasa Ienao" },
                    { 84, 1947, null, "Ijuin Tadaaki" },
                    { 85, 310, null, "Ikeda Tsuneoki" },
                    { 86, 1095, null, "Imagawa Ujizane" },
                    { 87, 507, null, "Imagawa Yoshimoto" },
                    { 88, 849, null, "Imai Kanehira" },
                    { 89, 1003, null, "Inaba Yoshimichi" },
                    { 90, 610, null, "Inugami Nagayasu" },
                    { 91, 757, null, "Ishida Mitsunari" },
                    { 92, 960, null, "Isshiki Fujinaga" },
                    { 93, 1660, null, "Itagaki Nobukata" },
                    { 94, 1485, null, "Itō Hirobumi" },
                    { 95, 1730, null, "Iwanari Tomomichi" },
                    { 96, 1360, null, "Jinbo Nagamoto" },
                    { 97, 1533, null, "Jonas Tönse" },
                    { 98, 689, null, "Kannan Kumar(Salem)" },
                    { 99, 814, null, "Kakeda Toshimune" },
                    { 100, 782, null, "Kaneko Ietada" },
                    { 101, 400, null, "Katagiri Katsumoto" },
                    { 102, 993, null, "Katakura Kojūro" },
                    { 103, 539, null, "Katakura Shigenaga" },
                    { 104, 745, null, "Kataoka Mitsumasa" },
                    { 105, 1105, null, "Katō Kiyomasa" },
                    { 106, 1196, null, "Kawakami Gensai" },
                    { 107, 1911, null, "Kido Takayoshi" },
                    { 108, 1907, null, "Kikkawa Hiroie" },
                    { 109, 1952, null, "Kimotsuki Kanetsugu" },
                    { 110, 1086, null, "Kitamura Kansuke" },
                    { 111, 1619, null, "Kobayakawa Hideaki" },
                    { 112, 689, null, "Kobayakawa Hidekane" },
                    { 113, 1628, null, "Kobayakawa Takakage" },
                    { 114, 50, null, "Konishi Yukinaga" },
                    { 115, 551, null, "Kojima Toyoharu" },
                    { 116, 225, null, "Kuroda Kanbei" },
                    { 117, 809, null, "Kuroda Kiyotaka" },
                    { 118, 884, null, "Kusunoki Masashige" },
                    { 119, 913, null, "Kuwana Tarozaemon" },
                    { 120, 1978, null, "Kumagai Naozane" },
                    { 121, 1299, null, "Maeda Keiji" },
                    { 122, 79, null, "Maeda Matsu" },
                    { 123, 890, null, "Maeda Nagatane" },
                    { 124, 401, null, "Maeda Toshiie" },
                    { 125, 255, null, "Maeda Toshinaga" },
                    { 126, 782, null, "Maeda Toshitsune" },
                    { 127, 1213, null, "Magome Kageyu" },
                    { 128, 1621, null, "Manabe Akifusa" },
                    { 129, 930, null, "Matsudaira Katamori" },
                    { 130, 934, null, "Matsudaira Nobutsuna" },
                    { 131, 1004, null, "Matsudaira Nobuyasu" },
                    { 132, 1561, null, "Matsudaira Higo no Kami Katamori" },
                    { 133, 894, null, "Matsudaira Sadanobu" },
                    { 134, 1672, null, "Matsudaira Tadayoshi" },
                    { 135, 1772, null, "Matsudaira Teru" },
                    { 136, 520, null, "Matsunaga Hisahide" },
                    { 137, 1987, null, "Matsunaga Hisamichi" },
                    { 138, 970, null, "Matsuo Bashō" },
                    { 139, 186, null, "Matsudaira Motoyasu" },
                    { 140, 1905, null, "Minamoto no Mitsunaka" },
                    { 141, 1071, null, "Minamoto no Yoshiie" },
                    { 142, 1208, null, "Minamoto no Yoshimitsu" },
                    { 143, 1526, null, "Minamoto no Yoshinaka" },
                    { 144, 217, null, "Minamoto no Yoshitomo" },
                    { 145, 215, null, "Minamoto no Yoshitsune" },
                    { 146, 280, null, "Minamoto no Tameyoshi" },
                    { 147, 302, null, "Minamoto no Yorimasa" },
                    { 148, 1813, null, "Minamoto no Yorimitsu" },
                    { 149, 1726, null, "Minamoto no Yoritomo" },
                    { 150, 571, null, "Minamoto no Noriyori" },
                    { 151, 787, null, "Minoro Takashi" },
                    { 152, 1108, null, "Miura Anjin" },
                    { 153, 1093, null, "Miura Yoshimoto" },
                    { 154, 219, null, "Miyamoto Musashi" },
                    { 155, 464, null, "Miyoshi Chōkei" },
                    { 156, 1281, null, "Miyoshi Kazuhide" },
                    { 157, 1933, null, "Miyoshi Masaga" },
                    { 158, 226, null, "Miyoshi Masayasu" },
                    { 159, 100, null, "Miyoshi Moriyata" },
                    { 160, 1159, null, "Miyoshi Nagayuki" },
                    { 161, 1265, null, "Miyoshi Yoshitsugu" },
                    { 162, 500, null, "Mizuno Tadakuni" },
                    { 163, 1820, null, "Moniwa Yoshinao" },
                    { 164, 1078, null, "Mōri Motonari" },
                    { 165, 1959, null, "Mōri Nagasada" },
                    { 166, 220, null, "Mori Nagayoshi" },
                    { 167, 27, null, "Mōri Okimoto" },
                    { 168, 745, null, "Mori Ranmaru" },
                    { 169, 498, null, "Mōri Takamoto" },
                    { 170, 774, null, "Mori Tadamasa" },
                    { 171, 1227, null, "Mōri Terumoto" },
                    { 172, 961, null, "Mori Yoshinari" },
                    { 173, 1650, null, "Murai Sadakatsu" },
                    { 174, 435, null, "Nagakura Shinpachi" },
                    { 175, 1891, null, "Nagao Harukage" },
                    { 176, 1042, null, "Nagao Kagenobu" },
                    { 177, 1611, null, "Nagao Masakage" },
                    { 178, 1717, null, "Nagao Tamekage" },
                    { 179, 1642, null, "Nakagawa Kiyohide" },
                    { 180, 1518, null, "Nakaoka Shintarō" },
                    { 181, 1392, null, "Naoe Kagetsuna" },
                    { 182, 1429, null, "Naoe Kanetsugu" },
                    { 183, 194, null, "Narita Kaihime" },
                    { 184, 445, null, "Nene" },
                    { 185, 282, null, "Nihonmatsu Yoshitsugu" },
                    { 186, 1802, null, "Niimi Nishiki" },
                    { 187, 185, null, "Niiro Tadamoto" },
                    { 188, 1313, null, "Niwa Nagahide" },
                    { 189, 613, null, "Niwa Nagashige" },
                    { 190, 160, null, "Oda Hiroyoshi" },
                    { 191, 1256, null, "Oda Nobuhide" },
                    { 192, 226, null, "Oda Nobukata" },
                    { 193, 1044, null, "Oda Nobukiyo" },
                    { 194, 867, null, "Oda Nobunaga" },
                    { 195, 1164, null, "Oda Nobutada" },
                    { 196, 247, null, "Oda Nobutomo" },
                    { 197, 590, null, "Oda Nobukatsu" },
                    { 198, 810, null, "Oda Nobuyasu" },
                    { 199, 313, null, "Ogasawara Shōsai" },
                    { 200, 1167, null, "Ōishi Kuranosuke" },
                    { 201, 880, null, "Okada Izō" },
                    { 202, 1122, null, "Judge Ooka" },
                    { 203, 615, null, "Ōta Dōkan" },
                    { 204, 177, null, "Ōtani Yoshitsugu" },
                    { 205, 12, null, "Ōtani Yoshiharu" },
                    { 206, 1257, null, "Ōtomo Sōrin" },
                    { 207, 748, null, "Okita Sōji" },
                    { 208, 1266, null, "Ōkubo Toshimichi" },
                    { 209, 616, null, "Okunomiya Masaie" },
                    { 210, 1812, null, "Ōuchi Yoshitaka" },
                    { 211, 814, null, "Omy Yoshika" },
                    { 212, 324, null, "Pore Sufi" },
                    { 213, 148, null, "Reizei Takatoyo" },
                    { 214, 1025, null, "Rokkaku Sadayori" },
                    { 215, 1187, null, "Rokkaku Yoshiharu" },
                    { 216, 158, null, "Rokkaku Yoshikata" },
                    { 217, 964, null, "Rusu Masakage" },
                    { 218, 1250, null, "Ryūzōji Takanobu" },
                    { 219, 878, null, "Saigo Kiyokazu" },
                    { 220, 1287, null, "Saigō Masako" },
                    { 221, 1134, null, "Sagara Taketō" },
                    { 222, 1219, null, "Saigō Takamori" },
                    { 223, 1080, null, "Saigo Yoshikatsu" },
                    { 224, 774, null, "Saitō Dōsan" },
                    { 225, 892, null, "Saitō Hajime" },
                    { 226, 669, null, "Saito Musashibō Benkei" },
                    { 227, 1417, null, "Saitō Yoshitatsu" },
                    { 228, 1468, null, "Sakai Tadakiyo" },
                    { 229, 1039, null, "Sakai Tadashige" },
                    { 230, 1478, null, "Sakai Tadatsugu" },
                    { 231, 317, null, "Sakai Tadayo" },
                    { 232, 398, null, "Sakakibara Yasumasa" },
                    { 233, 240, null, "Sakamoto Ryōma" },
                    { 234, 1841, null, "Sakuma Morimasa" },
                    { 235, 479, null, "Sakuma Nobumori" },
                    { 236, 1425, null, "Sanada Akihime" },
                    { 237, 1277, null, "Sanada Komatsuhime" },
                    { 238, 1244, null, "Sanada Masayuki" },
                    { 239, 1032, null, "Sanada Nobuyuki" },
                    { 240, 36, null, "Sanada Yukimura" },
                    { 241, 1202, null, "Sasaki Kojirō" },
                    { 242, 66, null, "Sassa Narimasa" },
                    { 243, 1434, null, "Sasuke Sarutobi" },
                    { 244, 204, null, "Serizawa Kamo" },
                    { 245, 1116, null, "Shibata Katsuie" },
                    { 246, 578, null, "Shima Sakon" },
                    { 247, 552, null, "Shimada Ichirō" },
                    { 248, 1299, null, "Shimazu Katsuhisa" },
                    { 249, 1517, null, "Shimazu Tadahisa" },
                    { 250, 179, null, "Shimazu Tadatsune" },
                    { 251, 1365, null, "Shimazu Tadayoshi" },
                    { 252, 1692, null, "Shimazu Takahisa" },
                    { 253, 1459, null, "Shimazu Toyohisa" },
                    { 254, 191, null, "Shimazu Yoshihiro" },
                    { 255, 325, null, "Shimazu Yoshihisa" },
                    { 256, 1655, null, "Shindou Hiroshii" },
                    { 257, 1511, null, "Sogo Nagayasu" },
                    { 258, 1802, null, "Sue Yoshitaka" },
                    { 259, 914, null, "Tachibana Muneshige" },
                    { 260, 1256, null, "Tachibana Dōsetsu" },
                    { 261, 475, null, "Tachibana Ginchiyo" },
                    { 262, 1174, null, "Taigen Sessai" },
                    { 263, 1480, null, "Taira no Kiyomori" },
                    { 264, 606, null, "Taira Masakado" },
                    { 265, 1128, null, "Takahashi Shigetane" },
                    { 266, 286, null, "Takenaka Shigeharu" },
                    { 267, 244, null, "Takasugi Shinsaku" },
                    { 268, 954, null, "Takayama Justo" },
                    { 269, 1976, null, "Takayama Ukon" },
                    { 270, 299, null, "Takechi Hanpeita" },
                    { 271, 1885, null, "Takeda Katsuyori" },
                    { 272, 1389, null, "Takeda Nobukatsu" },
                    { 273, 658, null, "Takeda Nobushige" },
                    { 274, 1197, null, "Takeda Shingen" },
                    { 275, 435, null, "Takenaka Hanbei" },
                    { 276, 1607, null, "Tani Tadasumi" },
                    { 277, 1468, null, "Tōdō Takatora" },
                    { 278, 110, null, "Toki Yorinari" },
                    { 279, 1641, null, "Tochimitsu Gantyoki" },
                    { 280, 1357, null, "Tokugawa Ieyasu" },
                    { 281, 161, null, "Tokugawa Hidetada" },
                    { 282, 958, null, "Tokugawa Nariaki" },
                    { 283, 1634, null, "Tokugawa Yoshinobu" },
                    { 284, 1813, null, "Torii Mototada" },
                    { 285, 1153, null, "Toyotomi Hidenaga" },
                    { 286, 1389, null, "Toyotomi Hideyoshi" },
                    { 287, 956, null, "Toyotomi Hideyori" },
                    { 288, 1896, null, "Tozuka Tadaharu" },
                    { 289, 1063, null, "Tsukahara Bokuden" },
                    { 290, 781, null, "Uesugi Kagekatsu" },
                    { 291, 1766, null, "Uesugi Kagetora" },
                    { 292, 1827, null, "Uesugi Kenshin" },
                    { 293, 149, null, "Ujiie Naotomo" },
                    { 294, 287, null, "Ukita Naoie" },
                    { 295, 101, null, "Ukita Okiie" },
                    { 296, 1713, null, "Umezawa Michiharu" },
                    { 297, 1541, null, "Usami Sadamitsu" },
                    { 298, 735, null, "Uyama Hisanobu" },
                    { 299, 1885, null, "Wada Shinsuke" },
                    { 300, 1895, null, "Watanabe Kazan" },
                    { 301, 841, null, "Watanabe no Tsuna" },
                    { 302, 539, null, "Yasumero Kenshin" },
                    { 303, 1874, null, "Yagyū Jūbei Mitsuyoshi" },
                    { 304, 1845, null, "Yagyū Munenori" },
                    { 305, 540, null, "Yamauchi Kazutoyo" },
                    { 306, 332, null, "Yamada Arinaga" },
                    { 307, 1919, null, "Yamada Arinobu" },
                    { 308, 1629, null, "Yamada Nagamasa" },
                    { 309, 960, null, "Yamagata Masakage" },
                    { 310, 789, null, "Yamakawa Hiroshi" },
                    { 311, 1518, null, "Yamakawa Kenjirō" },
                    { 312, 1539, null, "Yamakawa Naoe" },
                    { 313, 1591, null, "Yamanaka Yukimori" },
                    { 314, 747, null, "Yamanami Keisuke" },
                    { 315, 1468, null, "Yamaoka Tesshū" },
                    { 316, 414, null, "Yanagawa Kenzaburo" },
                    { 317, 112, null, "Yanagisawa Yoshiyasu" },
                    { 318, 885, null, "Yonekura Shigetsugu" },
                    { 319, 1934, null, "Yūki Hideyasu" },
                    { 320, 72, null, "Yasuke" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320);
        }
    }
}
