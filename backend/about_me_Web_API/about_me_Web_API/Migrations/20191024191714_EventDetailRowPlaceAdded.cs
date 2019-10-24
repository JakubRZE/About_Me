using Microsoft.EntityFrameworkCore.Migrations;

namespace about_me_Web_API.Migrations
{
    public partial class EventDetailRowPlaceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "EventDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "EventDetails");
        }
    }
}
