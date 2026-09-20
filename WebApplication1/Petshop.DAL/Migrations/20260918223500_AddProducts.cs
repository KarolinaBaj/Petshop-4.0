using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Kategorija_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivkategorije = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Kategorija_id);
                });

            migrationBuilder.CreateTable(
                name: "korisnik",
                columns: table => new
                {
                    Korsnik_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    prezime = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    lozinka = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    adresa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    br_telefona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnik", x => x.Korsnik_id);
                });

            migrationBuilder.CreateTable(
                name: "Orderitems",
                columns: table => new
                {
                    stavkaporudzbine_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    porudzbina_id = table.Column<int>(type: "int", nullable: false),
                    Proizvod_id = table.Column<int>(type: "int", nullable: false),
                    kolicina = table.Column<int>(type: "int", nullable: false),
                    cena = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orderitems", x => x.stavkaporudzbine_id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    porudzbina_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    korisnik_id = table.Column<int>(type: "int", nullable: false),
                    Datumporudzbine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ukupnacena = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.porudzbina_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Proizvod_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cena = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    kolicinanastanju = table.Column<int>(type: "int", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    kategorija_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Proizvod_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "korisnik");

            migrationBuilder.DropTable(
                name: "Orderitems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
