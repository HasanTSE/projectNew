using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalityId",
                table: "EmpInfo");

            migrationBuilder.RenameColumn(
                name: "NationalityId",
                table: "EmpInfo",
                newName: "NationalId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpInfo_NationalityId",
                table: "EmpInfo",
                newName: "IX_EmpInfo_NationalId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalId",
                table: "EmpInfo",
                column: "NationalId",
                principalTable: "EmpNation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalId",
                table: "EmpInfo");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "EmpInfo",
                newName: "NationalityId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpInfo_NationalId",
                table: "EmpInfo",
                newName: "IX_EmpInfo_NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalityId",
                table: "EmpInfo",
                column: "NationalityId",
                principalTable: "EmpNation",
                principalColumn: "Id");
        }
    }
}
