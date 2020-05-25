using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdfundApp.Migrations
{
    public partial class stelios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPhoto",
                table: "Multimedia");

            migrationBuilder.DropColumn(
                name: "IsVideo",
                table: "Multimedia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPhoto",
                table: "Multimedia",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVideo",
                table: "Multimedia",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
