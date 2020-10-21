using Microsoft.EntityFrameworkCore.Migrations;

namespace Courier_Management_System.Migrations.City
{
    public partial class CityMigration : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
