using Microsoft.EntityFrameworkCore.Migrations;

namespace Crepixa.Migrations
{
    public partial class UpdateSurvyOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "SurveiesOptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "SurveiesOptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
