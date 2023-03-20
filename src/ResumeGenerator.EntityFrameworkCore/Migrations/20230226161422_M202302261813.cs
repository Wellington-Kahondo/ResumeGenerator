using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResumeGenerator.Migrations
{
    public partial class M202302261813 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoredFiles_Sections_SectionId",
                table: "StoredFiles");

            migrationBuilder.DropIndex(
                name: "IX_StoredFiles_SectionId",
                table: "StoredFiles");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "StoredFiles");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Certifications");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Certifications");

            migrationBuilder.AddColumn<Guid>(
                name: "ResumeId",
                table: "StoredFiles",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "WorkExperiences",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "WorkExperiences",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "WorkExperiences",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "WorkExperiences",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectionId",
                table: "StoredFiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Skills",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Skills",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Skills",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Skills",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Skills",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Sections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Sections",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Resumes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Resumes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Resumes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Resumes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Resumes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Resumes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Resumes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Education",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Education",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Education",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Education",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Education",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Education",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Certifications",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Certifications",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Certifications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Certifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Certifications",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Certifications",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoredFiles_SectionId",
                table: "StoredFiles",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_StoredFiles_Sections_SectionId",
                table: "StoredFiles",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
