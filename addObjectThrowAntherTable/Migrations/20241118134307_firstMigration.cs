using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace addObjectThrowAntherTable.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sessions",
                columns: table => new
                {
                    sessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sessionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessions", x => x.sessionId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentId);
                });

            migrationBuilder.CreateTable(
                name: "sessionstudent",
                columns: table => new
                {
                    sessionssessionId = table.Column<int>(type: "int", nullable: false),
                    studentsstudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sessionstudent", x => new { x.sessionssessionId, x.studentsstudentId });
                    table.ForeignKey(
                        name: "FK_sessionstudent_sessions_sessionssessionId",
                        column: x => x.sessionssessionId,
                        principalTable: "sessions",
                        principalColumn: "sessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sessionstudent_students_studentsstudentId",
                        column: x => x.studentsstudentId,
                        principalTable: "students",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sessionstudent_studentsstudentId",
                table: "sessionstudent",
                column: "studentsstudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sessionstudent");

            migrationBuilder.DropTable(
                name: "sessions");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
