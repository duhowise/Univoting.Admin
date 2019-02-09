using Microsoft.EntityFrameworkCore.Migrations;

namespace UniVoting.Data.Migrations
{
    public partial class ChangedSettingsToConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                table: "Settings");

            migrationBuilder.RenameTable(
                name: "Settings",
                newName: "ElectionConfigurations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ElectionConfigurations",
                table: "ElectionConfigurations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ElectionConfigurations",
                table: "ElectionConfigurations");

            migrationBuilder.RenameTable(
                name: "ElectionConfigurations",
                newName: "Settings");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                table: "Settings",
                column: "Id");
        }
    }
}
