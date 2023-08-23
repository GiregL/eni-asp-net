using BO.Model;
using Microsoft.EntityFrameworkCore;

namespace AppSamourai.Data;

/// <summary>
/// DbContext des samourais.
/// </summary>
public class SamouraiDbContext : DbContext
{
    public DbSet<Arme> Armes { get; set; }
    public DbSet<Samourai> Samourais { get; set; }
    public DbSet<ArtMartial> ArtMartials { get; set; }
    
    public SamouraiDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var samouraiBuilder = modelBuilder.Entity<Samourai>();
        var armeBuilder = modelBuilder.Entity<Arme>();
        var artMartialBuilder = modelBuilder.Entity<ArtMartial>();

        samouraiBuilder.HasKey(samourai => samourai.Id);
        armeBuilder.HasKey(arme => arme.Id);
        artMartialBuilder.HasKey(am => am.Id);

        samouraiBuilder.Property(s => s.Nom).IsRequired().HasMaxLength(256);
        armeBuilder.Property(arme => arme.Nom).IsRequired().HasMaxLength(256);
        artMartialBuilder.Property(am => am.Nom).IsRequired().HasMaxLength(64);

        samouraiBuilder.Property(samourai => samourai.Id).ValueGeneratedOnAdd();
        armeBuilder.Property(arme => arme.Id).ValueGeneratedOnAdd();
        artMartialBuilder.Property(am => am.Id).ValueGeneratedOnAdd();
        
        samouraiBuilder
            .HasOne(samourai => samourai.Arme)
            .WithOne(arme => arme.Utilisateur)
            .HasForeignKey<Arme>(arme => arme.IdUtilisateur)
            .OnDelete(DeleteBehavior.SetNull);
        
        // Relation Art martial <-> Samourai
        samouraiBuilder
            .HasMany(samourai => samourai.Techniques)
            .WithMany(techniques => techniques.Utilisateurs);
        
        /*
         * Données factices
         */
        
        int id = 1;
        Random r = new Random();
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Abe Masakatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Adachi Yasumori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Adachi Kagemori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Adams William", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Aiou Mototsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Akai Terukage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Akao Kiyotsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Akechi Mitsuhide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Akiyama Nobutomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Amago Haruhisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Amago Yoshihisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Andō Morinari", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ankokuji Ekei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Aochi Shigetsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Aokage Takaakira", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Aoki Kazushige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Akahori Chohichi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Arai Hakuseki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Araki Motokiyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Araki Murashige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Araki Muratsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Arima Kihei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Asakura Yoshikage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ayame Kagekatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Azai Hisamasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Azai Nagamasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Azai Sukemasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Baba Nobufusa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Bessho Nagaharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chacha", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chiba Shusaku Narimasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chōsokabe Morichika", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chōsokabe Kunichika", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chōsokabe Motochika", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Chōsokabe Nobuchika", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Collache Eugène", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Date Masamune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Date Shigezane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Doi Toshikatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Etō Shinpei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Endō Naotsune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Enjoji Nobutane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Enomoto Takeaki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Era Fusahide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Fūma Kotarō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Fuwa Mitsuharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Fukushima Masanori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Gamō Katahide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Gamō Ujisato", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Harada Naomasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Harada Nobutane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Harada Sanosuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hasekura Tsunenaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hattori Hanzō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hatano Hideharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hasegawa Eishin", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hayashizaki Jinsuke Shigenobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hayashi Narinaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hijikata Toshizo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hirate Masahide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hitotsubashi Keiki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hōjō Masako", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hōjō Tokimune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hōjō Ujiyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hōjō Ujimasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Honda Tadakatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Honda Tadatomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Honganji Kennyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Horio Yoshiharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hosokawa Fujitaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hosokawa Gracia", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hosokawa Tadaoki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Hotta Masatoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naoaki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naomasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naomori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naonaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naosuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naotaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naotora", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naoyuki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ii Naozumi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Iizasa Ienao", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ijuin Tadaaki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ikeda Tsuneoki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Imagawa Ujizane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Imagawa Yoshimoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Imai Kanehira", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Inaba Yoshimichi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Inugami Nagayasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ishida Mitsunari", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Isshiki Fujinaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Itagaki Nobukata", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Itō Hirobumi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Iwanari Tomomichi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Jinbo Nagamoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Jonas Tönse", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kannan Kumar(Salem)", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kakeda Toshimune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kaneko Ietada", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Katagiri Katsumoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Katakura Kojūro", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Katakura Shigenaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kataoka Mitsumasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Katō Kiyomasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kawakami Gensai", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kido Takayoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kikkawa Hiroie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kimotsuki Kanetsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kitamura Kansuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kobayakawa Hideaki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kobayakawa Hidekane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kobayakawa Takakage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Konishi Yukinaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kojima Toyoharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kuroda Kanbei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kuroda Kiyotaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kusunoki Masashige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kuwana Tarozaemon", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Kumagai Naozane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Keiji", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Matsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Nagatane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Toshiie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Toshinaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Maeda Toshitsune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Magome Kageyu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Manabe Akifusa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Katamori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Nobutsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Nobuyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Higo no Kami Katamori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Sadanobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Tadayoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Teru", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsunaga Hisahide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsunaga Hisamichi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsuo Bashō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Matsudaira Motoyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Mitsunaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoshiie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoshimitsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoshinaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoshitomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoshitsune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Tameyoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yorimasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yorimitsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Yoritomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minamoto no Noriyori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Minoro Takashi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miura Anjin", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miura Yoshimoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyamoto Musashi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Chōkei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Kazuhide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Masaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Masayasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Moriyata", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Nagayuki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Miyoshi Yoshitsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mizuno Tadakuni", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Moniwa Yoshinao", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mōri Motonari", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mōri Nagasada", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mori Nagayoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mōri Okimoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mori Ranmaru", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mōri Takamoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mori Tadamasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mōri Terumoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Mori Yoshinari", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Murai Sadakatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nagakura Shinpachi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nagao Harukage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nagao Kagenobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nagao Masakage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nagao Tamekage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nakagawa Kiyohide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nakaoka Shintarō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Naoe Kagetsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Naoe Kanetsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Narita Kaihime", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nene", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Nihonmatsu Yoshitsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Niimi Nishiki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Niiro Tadamoto", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Niwa Nagahide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Niwa Nagashige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Hiroyoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobuhide", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobukata", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobukiyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobunaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobutada", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobutomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobukatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Oda Nobuyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ogasawara Shōsai", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōishi Kuranosuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Okada Izō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Judge Ooka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōta Dōkan", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōtani Yoshitsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōtani Yoshiharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōtomo Sōrin", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Okita Sōji", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōkubo Toshimichi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Okunomiya Masaie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ōuchi Yoshitaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Omy Yoshika", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Pore Sufi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Reizei Takatoyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Rokkaku Sadayori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Rokkaku Yoshiharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Rokkaku Yoshikata", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Rusu Masakage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ryūzōji Takanobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saigo Kiyokazu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saigō Masako", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sagara Taketō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saigō Takamori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saigo Yoshikatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saitō Dōsan", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saitō Hajime", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saito Musashibō Benkei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Saitō Yoshitatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakai Tadakiyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakai Tadashige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakai Tadatsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakai Tadayo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakakibara Yasumasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakamoto Ryōma", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakuma Morimasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sakuma Nobumori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sanada Akihime", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sanada Komatsuhime", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sanada Masayuki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sanada Nobuyuki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sanada Yukimura", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sasaki Kojirō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sassa Narimasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sasuke Sarutobi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Serizawa Kamo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shibata Katsuie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shima Sakon", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimada Ichirō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Katsuhisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Tadahisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Tadatsune", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Tadayoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Takahisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Toyohisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Yoshihiro", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shimazu Yoshihisa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Shindou Hiroshii", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sogo Nagayasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Sue Yoshitaka", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tachibana Muneshige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tachibana Dōsetsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tachibana Ginchiyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Taigen Sessai", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Taira no Kiyomori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Taira Masakado", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takahashi Shigetane", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takenaka Shigeharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takasugi Shinsaku", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takayama Justo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takayama Ukon", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takechi Hanpeita", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takeda Katsuyori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takeda Nobukatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takeda Nobushige", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takeda Shingen", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Takenaka Hanbei", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tani Tadasumi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tōdō Takatora", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Toki Yorinari", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tochimitsu Gantyoki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tokugawa Ieyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tokugawa Hidetada", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tokugawa Nariaki", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tokugawa Yoshinobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Torii Mototada", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Toyotomi Hidenaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Toyotomi Hideyoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Toyotomi Hideyori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tozuka Tadaharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Tsukahara Bokuden", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Uesugi Kagekatsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Uesugi Kagetora", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Uesugi Kenshin", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ujiie Naotomo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ukita Naoie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Ukita Okiie", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Umezawa Michiharu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Usami Sadamitsu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Uyama Hisanobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Wada Shinsuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Watanabe Kazan", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Watanabe no Tsuna", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yasumero Kenshin", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yagyū Jūbei Mitsuyoshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yagyū Munenori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamauchi Kazutoyo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamada Arinaga", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamada Arinobu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamada Nagamasa", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamagata Masakage", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamakawa Hiroshi", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamakawa Kenjirō", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamakawa Naoe", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamanaka Yukimori", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamanami Keisuke", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yamaoka Tesshū", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yanagawa Kenzaburo", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yanagisawa Yoshiyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yonekura Shigetsugu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yūki Hideyasu", Force=r.Next(2000) });
        modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = ++id, Nom = "Yasuke", Force=r.Next(2000) });
    }

    public DbSet<BO.Model.Samourai> Samourai { get; set; } = default!;
}