using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeGenerator.Migrations
{
    public partial class M202303042136 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoredFiles_Resumes_ResumeId",
                table: "StoredFiles");

            migrationBuilder.DropIndex(
                name: "IX_StoredFiles_ResumeId",
                table: "StoredFiles");

            migrationBuilder.DropColumn(
                name: "ResumeId",
                table: "StoredFiles");

            migrationBuilder.AddColumn<Guid>(
                name: "StoredFileId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_StoredFileId",
                table: "Persons",
                column: "StoredFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_StoredFiles_StoredFileId",
                table: "Persons",
                column: "StoredFileId",
                principalTable: "StoredFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_StoredFiles_StoredFileId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_StoredFileId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "StoredFileId",
                table: "Persons");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "StoredFiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_StoredFiles_ResumeId",
                table: "StoredFiles",
                column: "ResumeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoredFiles_Resumes_ResumeId",
                table: "StoredFiles",
                column: "ResumeId",
                principalTable: "Resumes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
