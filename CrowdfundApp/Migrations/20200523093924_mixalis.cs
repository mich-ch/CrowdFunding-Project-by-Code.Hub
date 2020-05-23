using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdfundApp.Migrations
{
    public partial class mixalis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fundings_Projects_ProjectId",
                table: "Fundings");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Backers_BackerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_BackerId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fundings",
                table: "Fundings");

            migrationBuilder.DropColumn(
                name: "BackerId",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "Fundings",
                newName: "FundingPackages");

            migrationBuilder.RenameIndex(
                name: "IX_Fundings_ProjectId",
                table: "FundingPackages",
                newName: "IX_FundingPackages_ProjectId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundingPackages",
                table: "FundingPackages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FundingPackages_Projects_ProjectId",
                table: "FundingPackages",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FundingPackages_Projects_ProjectId",
                table: "FundingPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundingPackages",
                table: "FundingPackages");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Projects");

            migrationBuilder.RenameTable(
                name: "FundingPackages",
                newName: "Fundings");

            migrationBuilder.RenameIndex(
                name: "IX_FundingPackages_ProjectId",
                table: "Fundings",
                newName: "IX_Fundings_ProjectId");

            migrationBuilder.AddColumn<int>(
                name: "BackerId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fundings",
                table: "Fundings",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_BackerId",
                table: "Projects",
                column: "BackerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fundings_Projects_ProjectId",
                table: "Fundings",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Backers_BackerId",
                table: "Projects",
                column: "BackerId",
                principalTable: "Backers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
