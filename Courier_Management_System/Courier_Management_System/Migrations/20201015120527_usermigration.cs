using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations
{
    public partial class usermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "users");
        }
    }
}
