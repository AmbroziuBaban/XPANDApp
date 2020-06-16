using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class AddPlanetChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("54fea114-9799-4a13-9af0-eb612ce53206"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("ff67af90-c178-4c1a-922e-c902a70461e0"));

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("cfa46b87-bdf4-4930-9da2-d264f706fad7"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("a55ef03b-9fda-4748-aad2-147ce38529b0"), "T1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("a55ef03b-9fda-4748-aad2-147ce38529b0"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("cfa46b87-bdf4-4930-9da2-d264f706fad7"));

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("54fea114-9799-4a13-9af0-eb612ce53206"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("ff67af90-c178-4c1a-922e-c902a70461e0"), "T1" });
        }
    }
}
