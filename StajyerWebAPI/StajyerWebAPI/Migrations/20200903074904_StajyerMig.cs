using Microsoft.EntityFrameworkCore.Migrations;

namespace StajyerWebAPI.Migrations
{
    public partial class StajyerMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stajyers",
                columns: table => new
                {
                    StajyerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    TCNo = table.Column<string>(nullable: true),
                    Okul = table.Column<string>(nullable: true),
                    Bolum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stajyers", x => x.StajyerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stajyers");
        }
    }
}
