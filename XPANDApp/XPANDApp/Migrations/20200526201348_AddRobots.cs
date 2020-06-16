using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class AddRobots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CaptainName",
                table: "Captain",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "DescriptionId", "RobotName" },
                values: new object[] { new Guid("bc56ddf7-06a2-4d2f-9890-f2f7db1f2df7"), null, "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "DescriptionId", "RobotName" },
                values: new object[] { new Guid("5992b72c-cfe9-44c0-aee2-0e4ce652d5c0"), null, "T1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("5992b72c-cfe9-44c0-aee2-0e4ce652d5c0"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("bc56ddf7-06a2-4d2f-9890-f2f7db1f2df7"));

            migrationBuilder.AlterColumn<string>(
                name: "CaptainName",
                table: "Captain",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
