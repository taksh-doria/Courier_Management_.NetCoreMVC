using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations
{
    public partial class statusmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "current_city",
                table: "Consignment_Status",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "current_city",
                table: "Consignment_Status");
        }
    }
}
