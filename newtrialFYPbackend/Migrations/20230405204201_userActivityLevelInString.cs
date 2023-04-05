using Microsoft.EntityFrameworkCore.Migrations;

namespace newtrialFYPbackend.Migrations
{
    public partial class userActivityLevelInString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userActivityLevel",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userActivityLevel",
                table: "AspNetUsers");
        }
    }
}
