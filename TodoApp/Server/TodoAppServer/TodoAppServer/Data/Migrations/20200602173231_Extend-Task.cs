using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAppServer.Migrations
{
    public partial class ExtendTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Tasks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Edit",
                table: "Tasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Edit",
                table: "Tasks");
        }
    }
}
