using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class ready1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BloodGroupId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParmanentDistrictId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PresentDistrictId",
                table: "EmpInfo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bloods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bloods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParDistricts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParmanentDistrict = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParDistricts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreDistricts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresentDistrict = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreDistricts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_BloodGroupId",
                table: "EmpInfo",
                column: "BloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_ParmanentDistrictId",
                table: "EmpInfo",
                column: "ParmanentDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpInfo_PresentDistrictId",
                table: "EmpInfo",
                column: "PresentDistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_Bloods_BloodGroupId",
                table: "EmpInfo",
                column: "BloodGroupId",
                principalTable: "Bloods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_ParDistricts_ParmanentDistrictId",
                table: "EmpInfo",
                column: "ParmanentDistrictId",
                principalTable: "ParDistricts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpInfo_PreDistricts_PresentDistrictId",
                table: "EmpInfo",
                column: "PresentDistrictId",
                principalTable: "PreDistricts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_Bloods_BloodGroupId",
                table: "EmpInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_ParDistricts_ParmanentDistrictId",
                table: "EmpInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpInfo_PreDistricts_PresentDistrictId",
                table: "EmpInfo");

            migrationBuilder.DropTable(
                name: "Bloods");

            migrationBuilder.DropTable(
                name: "ParDistricts");

            migrationBuilder.DropTable(
                name: "PreDistricts");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_BloodGroupId",
                table: "EmpInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_ParmanentDistrictId",
                table: "EmpInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmpInfo_PresentDistrictId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "BloodGroupId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "ParmanentDistrictId",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "PresentDistrictId",
                table: "EmpInfo");
        }
    }
}
