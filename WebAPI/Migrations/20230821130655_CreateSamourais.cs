using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class CreateSamourais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Armes",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "IdUtilisateur",
                table: "Armes",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Samourai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Force = table.Column<int>(type: "integer", nullable: false),
                    IdArme = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samourai", x => x.Id);
                });

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
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes");

            migrationBuilder.DropTable(
                name: "Samourai");

            migrationBuilder.DropIndex(
                name: "IX_Armes_IdUtilisateur",
                table: "Armes");

            migrationBuilder.DropColumn(
                name: "IdUtilisateur",
                table: "Armes");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Armes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256);
        }
    }
}
