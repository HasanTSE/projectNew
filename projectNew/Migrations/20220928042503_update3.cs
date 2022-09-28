using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalId",
                table: "EmpInfo");

            migrationBuilder.RenameColumn(
                name: "NationalId",
                table: "EmpInfo",
                newName: "GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpInfo_NationalId",
                table: "EmpInfo",
                newName: "IX_EmpInfo_GenderId");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_NationId",
                table: "EmpInfo",
                column: "NationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_EmpNation_NationId",
                table: "EmpInfo",
                column: "NationId",
                principalTable: "EmpNation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_Genders_GenderId",
                table: "EmpInfo",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_EmpNation_NationId",
                table: "EmpInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_Genders_GenderId",
                table: "EmpInfo");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_NationId",
                table: "EmpInfo");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "EmpInfo",
                newName: "NationalId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpInfo_GenderId",
                table: "EmpInfo",
                newName: "IX_EmpInfo_NationalId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_EmpNation_NationalId",
                table: "EmpInfo",
                column: "NationalId",
                principalTable: "EmpNation",
                principalColumn: "Id");
        }
    }
}
