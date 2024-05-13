using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMgt_EF.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "newStudents",
                columns: table => new
                {
                    Student_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_newStudents", x => x.Student_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "newStudents");
        }
    }
}
