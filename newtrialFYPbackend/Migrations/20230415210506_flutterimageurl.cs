using Microsoft.EntityFrameworkCore.Migrations;

namespace newtrialFYPbackend.Migrations
{
    public partial class flutterimageurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "flutterImageUrl",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "flutterImageUrl",
                table: "Meals");
        }
    }
}
