using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Employee
{
    public partial class EmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    emp_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    emp_name = table.Column<string>(nullable: true),
                    emp_role = table.Column<string>(nullable: true),
                    emp_address = table.Column<string>(nullable: true),
                    emp_city = table.Column<string>(nullable: true),
                    emp_email = table.Column<string>(nullable: true),
                    emp_password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.emp_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
