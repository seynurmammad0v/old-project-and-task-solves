using Microsoft.EntityFrameworkCore.Migrations;

namespace CamexAPI.Migrations
{
    public partial class fixFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeNameTranlates");

            migrationBuilder.AlterColumn<float>(
                name: "PriceValue",
                table: "Offices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "PriceValue",
                table: "Cities",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "OfficeNameTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    OfficeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeNameTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeNameTranslates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficeNameTranslates_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfficeNameTranslates_LanguageId",
                table: "OfficeNameTranslates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeNameTranslates_OfficeId",
                table: "OfficeNameTranslates",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeNameTranslates");

            migrationBuilder.AlterColumn<int>(
                name: "PriceValue",
                table: "Offices",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "PriceValue",
                table: "Cities",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.CreateTable(
                name: "OfficeNameTranlates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeNameTranlates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeNameTranlates_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficeNameTranlates_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OfficeNameTranlates_LanguageId",
                table: "OfficeNameTranlates",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeNameTranlates_OfficeId",
                table: "OfficeNameTranlates",
                column: "OfficeId");
        }
    }
}
