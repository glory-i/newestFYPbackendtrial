using Microsoft.EntityFrameworkCore.Migrations;

namespace newtrialFYPbackend.Migrations
{
    public partial class HeightInCm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Height",
                table: "AspNetUsers",
                newName: "HeightInInches");

            migrationBuilder.AddColumn<double>(
                name: "HeightInCm",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "HeightInFeet",
                table: "AspNetUsers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeightInCm",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HeightInFeet",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "HeightInInches",
                table: "AspNetUsers",
                newName: "Height");
        }
    }
}
