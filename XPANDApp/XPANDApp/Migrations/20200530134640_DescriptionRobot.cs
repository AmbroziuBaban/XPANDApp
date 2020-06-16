using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class DescriptionRobot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("136cc2b7-be15-4611-acbf-5b19a982826c"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("d872b1d5-fc58-4a93-9cf6-2387a72323d8"));

            migrationBuilder.AlterColumn<string>(
                name: "RobotName",
                table: "Robot",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("b4f69f2d-7800-43b6-ac35-e4e2dafa59b6"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("9ab95449-88c7-4883-b2e6-87440a8c41dd"), "T1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("9ab95449-88c7-4883-b2e6-87440a8c41dd"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("b4f69f2d-7800-43b6-ac35-e4e2dafa59b6"));

            migrationBuilder.AlterColumn<string>(
                name: "RobotName",
                table: "Robot",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("d872b1d5-fc58-4a93-9cf6-2387a72323d8"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("136cc2b7-be15-4611-acbf-5b19a982826c"), "T1" });
        }
    }
}
