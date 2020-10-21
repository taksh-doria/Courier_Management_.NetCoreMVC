using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Details
{
    public partial class ConsignmantMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "package_content",
                table: "Consignment_Details",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "package_content",
                table: "Consignment_Details");
        }
    }
}
