using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeGenerator.Migrations
{
    public partial class M202303111540 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentDisposion",
                table: "StoredFiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentDisposion",
                table: "StoredFiles");
        }
    }
}
