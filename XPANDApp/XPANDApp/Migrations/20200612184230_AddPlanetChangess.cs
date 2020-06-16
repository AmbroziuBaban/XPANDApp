using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class AddPlanetChangess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("30e6bb78-6863-47ff-bf3f-62ee6e43c5c6"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("3dde5406-fcab-4b53-8a80-14c3f8cda7d5"), "T1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("30e6bb78-6863-47ff-bf3f-62ee6e43c5c6"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("3dde5406-fcab-4b53-8a80-14c3f8cda7d5"));

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("cfa46b87-bdf4-4930-9da2-d264f706fad7"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("a55ef03b-9fda-4748-aad2-147ce38529b0"), "T1" });
        }
    }
}
