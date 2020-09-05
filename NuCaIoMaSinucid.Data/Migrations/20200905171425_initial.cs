using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NuCaIoMaSinucid.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Carti",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Titlu = table.Column<string>(nullable: false),
                    Autor = table.Column<string>(nullable: false),
                    Detalii = table.Column<string>(nullable: false),
                    EsteImprumutata = table.Column<bool>(nullable: false),
                    ClientID = table.Column<int>(nullable: true),
                    DataReturnare = table.Column<DateTime>(nullable: true),
                    DataImprumut = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carti", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carti_Clienti_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clienti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carti_ClientID",
                table: "Carti",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carti");

            migrationBuilder.DropTable(
                name: "Clienti");
        }
    }
}
