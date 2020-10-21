using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Status
{
    public partial class StatusMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "consignment_no",
                table: "Consignment_Status",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "consignment_no",
                table: "Consignment_Status");
        }
    }
}
