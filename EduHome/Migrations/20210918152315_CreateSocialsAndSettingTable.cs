using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class CreateSocialsAndSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(maxLength: 255, nullable: true),
                    FooterLogo = table.Column<string>(maxLength: 255, nullable: true),
                    Addres = table.Column<string>(maxLength: 150, nullable: false),
                    HeaderPhone = table.Column<string>(maxLength: 50, nullable: false),
                    FooterNumberOne = table.Column<string>(maxLength: 50, nullable: false),
                    FooterNumberTwo = table.Column<string>(maxLength: 50, nullable: false),
                    SiteName = table.Column<string>(maxLength: 50, nullable: false),
                    Copyright = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "socials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 50, nullable: false),
                    Links = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "socials");
        }
    }
}
