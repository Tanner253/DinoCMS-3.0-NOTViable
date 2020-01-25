using Microsoft.EntityFrameworkCore.Migrations;

namespace Scaffold_CMS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dinosaur",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Diet = table.Column<string>(nullable: false),
                    NeedToKnow = table.Column<string>(nullable: false),
                    Behavior = table.Column<string>(nullable: false),
                    SocialInteraction = table.Column<string>(nullable: false),
                    PackLimits = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Additionalinfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinosaur", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dinosaur");
        }
    }
}
