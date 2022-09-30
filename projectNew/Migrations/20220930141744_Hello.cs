using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class Hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignationId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Compas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_id = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_id = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Desigs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_id = table.Column<int>(type: "int", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desigs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_CompanyId",
                table: "EmpInfo",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_DepartmentId",
                table: "EmpInfo",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_DesignationId",
                table: "EmpInfo",
                column: "DesignationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_Compas_CompanyId",
                table: "EmpInfo",
                column: "CompanyId",
                principalTable: "Compas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_Depts_DepartmentId",
                table: "EmpInfo",
                column: "DepartmentId",
                principalTable: "Depts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_Desigs_DesignationId",
                table: "EmpInfo",
                column: "DesignationId",
                principalTable: "Desigs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_Compas_CompanyId",
                table: "EmpInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_Depts_DepartmentId",
                table: "EmpInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_Desigs_DesignationId",
                table: "EmpInfo");

            migrationBuilder.DropTable(
                name: "Compas");

            migrationBuilder.DropTable(
                name: "Depts");

            migrationBuilder.DropTable(
                name: "Desigs");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_CompanyId",
                table: "EmpInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_DepartmentId",
                table: "EmpInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_DesignationId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "DesignationId",
                table: "EmpInfo");
        }
    }
}
