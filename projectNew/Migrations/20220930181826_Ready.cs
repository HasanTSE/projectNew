using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectNew.Migrations
{
    public partial class Ready : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthCertifcateNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "EmpInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetectionSpot",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingLicenseNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContact",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FathersNameBn",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "EmpInfo",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersName",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersNameBn",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameBn",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NidNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalContact",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resident",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TinNo",
                table: "EmpInfo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "EmpInfo",
                type: "decimal(18,4)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthCertifcateNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "CarNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "DetectionSpot",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "DrivingLicenseNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "EmergencyContact",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "FathersNameBn",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "MothersName",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "MothersNameBn",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "NameBn",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "NidNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "PersonalContact",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "Resident",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "TinNo",
                table: "EmpInfo");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "EmpInfo");
        }
    }
}
