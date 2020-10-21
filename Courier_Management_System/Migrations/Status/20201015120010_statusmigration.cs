using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.Status
{
    public partial class statusmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consignment_Status",
                columns: table => new
                {
                    pkg_id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user = table.Column<string>(nullable: true),
                    consignee_name = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consignment_Status", x => x.pkg_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consignment_Status");
        }
    }
}
