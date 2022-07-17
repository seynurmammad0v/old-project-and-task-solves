using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Metadata;

namespace EvTapsiriqiFrontToBack.Migrations
{
    public partial class AddedBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logo = table.Column<string>(nullable: false),
                    Instagram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");
        }
    }
}
