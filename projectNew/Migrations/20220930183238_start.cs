using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emp_id",
                table: "Desigs");

            migrationBuilder.DropColumn(
                name: "Emp_id",
                table: "Depts");

            migrationBuilder.DropColumn(
                name: "Emp_id",
                table: "Compas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Emp_id",
                table: "Desigs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emp_id",
                table: "Depts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emp_id",
                table: "Compas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
