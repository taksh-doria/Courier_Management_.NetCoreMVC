using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Details
{
    public partial class ConsignmentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consignment_Details",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consignment_Details");
        }
    }
}
