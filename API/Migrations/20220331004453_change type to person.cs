using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class changetypetoperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Persons");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
