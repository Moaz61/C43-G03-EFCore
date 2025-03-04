using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAss.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Departments",
                newName: "DepartmentsManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                newName: "IX_Departments_DepartmentsManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_DepartmentsManagerId",
                table: "Departments",
                column: "DepartmentsManagerId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_DepartmentsManagerId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentsManagerId",
                table: "Departments",
                newName: "ManagerId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentsManagerId",
                table: "Departments",
                newName: "IX_Departments_ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
