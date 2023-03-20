using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeGenerator.Migrations
{
    public partial class M202303182211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Resumes_ResumeId",
                table: "Profile");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "SectionId",
                table: "Profile",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Profile_SectionId",
                table: "Profile",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Resumes_ResumeId",
                table: "Profile",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Sections_SectionId",
                table: "Profile",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Resumes_ResumeId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Sections_SectionId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_SectionId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Profile");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResumeId",
                table: "Profile",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Resumes_ResumeId",
                table: "Profile",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
