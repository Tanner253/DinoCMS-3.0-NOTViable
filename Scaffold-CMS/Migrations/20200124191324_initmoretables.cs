using Microsoft.EntityFrameworkCore.Migrations;

namespace Scaffold_CMS.Migrations
{
    public partial class initmoretables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Additionalinfo",
                table: "Dinosaur",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Dinosaur",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Additionalinfo",
                table: "Dinosaur");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Dinosaur");
        }
    }
}
