using Microsoft.EntityFrameworkCore.Migrations;

namespace about_me_Web_API.Migrations
{
    public partial class columnRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "EventDetails",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "EventDetails",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "Name");
        }
    }
}
