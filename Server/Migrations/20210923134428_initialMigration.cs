using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationPhases",
                columns: table => new
                {
                    ApplicationPhaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPhases", x => x.ApplicationPhaseId);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compensation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    JobTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.JobTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                columns: table => new
                {
                    WorkHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistories", x => x.WorkHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "JobTypeHelpers",
                columns: table => new
                {
                    JobTypeHelperID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobID = table.Column<int>(type: "int", nullable: false),
                    JobTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypeHelpers", x => x.JobTypeHelperID);
                    table.ForeignKey(
                        name: "FK_JobTypeHelpers_Jobs_JobID",
                        column: x => x.JobID,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTypeHelpers_JobTypes_JobTypeID",
                        column: x => x.JobTypeID,
                        principalTable: "JobTypes",
                        principalColumn: "JobTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitHubLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TimeApplied = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentHelpers",
                columns: table => new
                {
                    DocumentHelperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentHelpers", x => x.DocumentHelperId);
                    table.ForeignKey(
                        name: "FK_DocumentHelpers_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationHelpers",
                columns: table => new
                {
                    EducationHelperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationHelpers", x => x.EducationHelperId);
                    table.ForeignKey(
                        name: "FK_EducationHelpers_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginHelpers",
                columns: table => new
                {
                    LoginHelperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDateLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeDateLogOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHelpers", x => x.LoginHelperId);
                    table.ForeignKey(
                        name: "FK_LoginHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disability = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterHelpers",
                columns: table => new
                {
                    RegisterHelperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDateOfRegistration = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterHelpers", x => x.RegisterHelperId);
                    table.ForeignKey(
                        name: "FK_RegisterHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistoryHelpers",
                columns: table => new
                {
                    WorkHistoryHelperId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WorkHistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistoryHelpers", x => x.WorkHistoryHelperId);
                    table.ForeignKey(
                        name: "FK_WorkHistoryHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkHistoryHelpers_WorkHistories_WorkHistoryId",
                        column: x => x.WorkHistoryId,
                        principalTable: "WorkHistories",
                        principalColumn: "WorkHistoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "Compensation", "CreationDate", "Description", "DueDate", "Location", "Title" },
                values: new object[] { 1, "R45000", new DateTime(2021, 9, 23, 15, 44, 26, 789, DateTimeKind.Local).AddTicks(7940), "blah! blah! blah!", new DateTime(2021, 11, 23, 15, 44, 26, 787, DateTimeKind.Local).AddTicks(7907), "JHB", "Developer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "PasswordHash", "Role" },
                values: new object[] { 1, "sample@gmail.com", "2526sgfgfhsgdf984894s", "Candidate" });

            migrationBuilder.InsertData(
                table: "PersonalInformations",
                columns: new[] { "Id", "Address", "Disability", "Ethnicity", "FirstName", "Gender", "IdNumber", "LastName", "PhoneNumber", "UserId" },
                values: new object[] { 1, "2 Winter Fell Road", false, "Wildling", "John", "male", "74102589631", "Snow", "0329434578", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformations_UserId",
                table: "AdditionalInformations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobId",
                table: "Applications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHelpers_DocumentId",
                table: "DocumentHelpers",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHelpers_UserId",
                table: "DocumentHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationHelpers_EducationId",
                table: "EducationHelpers",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationHelpers_UserId",
                table: "EducationHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeHelpers_JobID",
                table: "JobTypeHelpers",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeHelpers_JobTypeID",
                table: "JobTypeHelpers",
                column: "JobTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHelpers_UserId",
                table: "LoginHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_UserId",
                table: "PersonalInformations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterHelpers_UserId",
                table: "RegisterHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistoryHelpers_UserId",
                table: "WorkHistoryHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistoryHelpers_WorkHistoryId",
                table: "WorkHistoryHelpers",
                column: "WorkHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformations");

            migrationBuilder.DropTable(
                name: "ApplicationPhases");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "DocumentHelpers");

            migrationBuilder.DropTable(
                name: "EducationHelpers");

            migrationBuilder.DropTable(
                name: "JobTypeHelpers");

            migrationBuilder.DropTable(
                name: "LoginHelpers");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "RegisterHelpers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "WorkHistoryHelpers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkHistories");
        }
    }
}
