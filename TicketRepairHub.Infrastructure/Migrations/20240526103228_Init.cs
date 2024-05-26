using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketRepairHub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FailureTreePartFailures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartFailureDecscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailureTreePartFailures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailureTreeParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailureTreeParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailureTreeTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailureTreeTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestLimits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinTestResult1 = table.Column<double>(type: "float", nullable: false),
                    MaxTestResult1 = table.Column<double>(type: "float", nullable: false),
                    MinTestResult2 = table.Column<double>(type: "float", nullable: false),
                    MaxTestResult2 = table.Column<double>(type: "float", nullable: false),
                    MinTestResult3 = table.Column<double>(type: "float", nullable: false),
                    MaxTestResult3 = table.Column<double>(type: "float", nullable: false),
                    MinTestResult4 = table.Column<double>(type: "float", nullable: false),
                    MaxTestResult4 = table.Column<double>(type: "float", nullable: false),
                    MinTestResult5 = table.Column<double>(type: "float", nullable: false),
                    MaxTestResult5 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestLimits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalResult1 = table.Column<bool>(type: "bit", nullable: false),
                    TestResult1 = table.Column<double>(type: "float", nullable: false),
                    IsTestResult1OK = table.Column<bool>(type: "bit", nullable: false),
                    TestResult2 = table.Column<double>(type: "float", nullable: false),
                    IsTestResult2OK = table.Column<bool>(type: "bit", nullable: false),
                    TestResult3 = table.Column<double>(type: "float", nullable: false),
                    IsTestResult3OK = table.Column<bool>(type: "bit", nullable: false),
                    TestResult4 = table.Column<double>(type: "float", nullable: false),
                    IsTestResult4OK = table.Column<bool>(type: "bit", nullable: false),
                    TestResult5 = table.Column<double>(type: "float", nullable: false),
                    IsTestResult5OK = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsTicketClosed = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAtDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestResultId = table.Column<int>(type: "int", nullable: false),
                    TestLimitId = table.Column<int>(type: "int", nullable: false),
                    FailedOnTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailedOnPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FailedOnPartDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorComment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_TestLimits_TestLimitId",
                        column: x => x.TestLimitId,
                        principalTable: "TestLimits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_TestResults_TestResultId",
                        column: x => x.TestResultId,
                        principalTable: "TestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TestLimitId",
                table: "Tickets",
                column: "TestLimitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TestResultId",
                table: "Tickets",
                column: "TestResultId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FailureTreePartFailures");

            migrationBuilder.DropTable(
                name: "FailureTreeParts");

            migrationBuilder.DropTable(
                name: "FailureTreeTests");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TestLimits");

            migrationBuilder.DropTable(
                name: "TestResults");
        }
    }
}
