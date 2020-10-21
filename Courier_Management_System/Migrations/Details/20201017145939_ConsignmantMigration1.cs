using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Details
{
    public partial class ConsignmantMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "consignment_no",
                table: "Consignment_Details",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "consignment_no",
                table: "Consignment_Details");
        }
    }
}
