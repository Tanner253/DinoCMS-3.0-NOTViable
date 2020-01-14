using Microsoft.EntityFrameworkCore.Migrations;

namespace Scaffold_CMS.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DinoProfile",
                table: "Dinosaur",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackLimits",
                table: "Dinosaur",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DinoProfile",
                table: "Dinosaur");

            migrationBuilder.DropColumn(
                name: "PackLimits",
                table: "Dinosaur");
        }
    }
}
