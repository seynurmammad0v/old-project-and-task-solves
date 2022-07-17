using Microsoft.EntityFrameworkCore.Migrations;

namespace EvTapsiriqiFrontToBack.Migrations
{
    public partial class addActiveted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activeted",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activeted",
                table: "AspNetUsers");
        }
    }
}
