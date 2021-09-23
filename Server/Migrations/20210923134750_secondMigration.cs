using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkHistoryHelperId",
                table: "WorkHistoryHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WorkHistoryId",
                table: "WorkHistories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Statuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RegisterHelperId",
                table: "RegisterHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LoginHelperId",
                table: "LoginHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobTypeID",
                table: "JobTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobTypeHelperID",
                table: "JobTypeHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Jobs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EducationId",
                table: "Educations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EducationHelperId",
                table: "EducationHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "Documents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DocumentHelperId",
                table: "DocumentHelpers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Applications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ApplicationPhaseId",
                table: "ApplicationPhases",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 9, 23, 15, 47, 48, 397, DateTimeKind.Local).AddTicks(5056), new DateTime(2021, 11, 23, 15, 47, 48, 396, DateTimeKind.Local).AddTicks(2565) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WorkHistoryHelpers",
                newName: "WorkHistoryHelperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WorkHistories",
                newName: "WorkHistoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Statuses",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RegisterHelpers",
                newName: "RegisterHelperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoginHelpers",
                newName: "LoginHelperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobTypes",
                newName: "JobTypeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "JobTypeHelpers",
                newName: "JobTypeHelperID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jobs",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Educations",
                newName: "EducationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EducationHelpers",
                newName: "EducationHelperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documents",
                newName: "DocumentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DocumentHelpers",
                newName: "DocumentHelperId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Applications",
                newName: "ApplicationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ApplicationPhases",
                newName: "ApplicationPhaseId");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 9, 23, 15, 44, 26, 789, DateTimeKind.Local).AddTicks(7940), new DateTime(2021, 11, 23, 15, 44, 26, 787, DateTimeKind.Local).AddTicks(7907) });
        }
    }
}
