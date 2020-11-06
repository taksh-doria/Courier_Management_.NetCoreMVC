using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    city_name = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    city_pincode = table.Column<short>(nullable: false),
                    branch_address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.city_name);
                });

            migrationBuilder.CreateTable(
                name: "Consignment_Details",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    consignment_no = table.Column<long>(nullable: false),
                    package_content = table.Column<string>(nullable: true),
                    user = table.Column<string>(nullable: true),
                    package_type = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    destination_city = table.Column<string>(nullable: true),
                    Consignee_name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    pkg_weight_in_grams = table.Column<float>(nullable: false),
                    amount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignment_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Consignment_Status",
                columns: table => new
                {
                    pkg_id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    consignment_no = table.Column<long>(nullable: false),
                    user = table.Column<string>(nullable: true),
                    consignee_name = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignment_Status", x => x.pkg_id);
                });

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

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    phone_no = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Consignment_Details");

            migrationBuilder.DropTable(
                name: "Consignment_Status");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
