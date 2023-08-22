using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpEni.Migrations
{
    /// <inheritdoc />
    public partial class DeleteSamourai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes");

            migrationBuilder.AddForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes",
                column: "IdUtilisateur",
                principalTable: "Samourai",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes");

            migrationBuilder.AddForeignKey(
                name: "FK_Armes_Samourai_IdUtilisateur",
                table: "Armes",
                column: "IdUtilisateur",
                principalTable: "Samourai",
                principalColumn: "Id");
        }
    }
}
