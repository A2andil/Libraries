using Microsoft.EntityFrameworkCore.Migrations;

namespace Crepixa.Migrations
{
    public partial class ProjctEdition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagsIds",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "TagsIds",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
