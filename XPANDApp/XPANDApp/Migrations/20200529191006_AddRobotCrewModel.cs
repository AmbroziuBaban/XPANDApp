using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class AddRobotCrewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robot_Description_DescriptionId",
                table: "Robot");

            migrationBuilder.DropIndex(
                name: "IX_Robot_DescriptionId",
                table: "Robot");

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("5992b72c-cfe9-44c0-aee2-0e4ce652d5c0"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("bc56ddf7-06a2-4d2f-9890-f2f7db1f2df7"));

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Robot");

            migrationBuilder.AddColumn<Guid>(
                name: "RobotCrewId",
                table: "Description",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "RobotsCrew",
                columns: table => new
                {
                    RobotsCrewId = table.Column<Guid>(nullable: false),
                    RobotIds = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotsCrew", x => x.RobotsCrewId);
                });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("d872b1d5-fc58-4a93-9cf6-2387a72323d8"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("136cc2b7-be15-4611-acbf-5b19a982826c"), "T1" });

            migrationBuilder.CreateIndex(
                name: "IX_Description_RobotCrewId",
                table: "Description",
                column: "RobotCrewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Description_RobotsCrew_RobotCrewId",
                table: "Description",
                column: "RobotCrewId",
                principalTable: "RobotsCrew",
                principalColumn: "RobotsCrewId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Description_RobotsCrew_RobotCrewId",
                table: "Description");

            migrationBuilder.DropTable(
                name: "RobotsCrew");

            migrationBuilder.DropIndex(
                name: "IX_Description_RobotCrewId",
                table: "Description");

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("136cc2b7-be15-4611-acbf-5b19a982826c"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("d872b1d5-fc58-4a93-9cf6-2387a72323d8"));

            migrationBuilder.DropColumn(
                name: "RobotCrewId",
                table: "Description");

            migrationBuilder.AddColumn<Guid>(
                name: "DescriptionId",
                table: "Robot",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "DescriptionId", "RobotName" },
                values: new object[] { new Guid("bc56ddf7-06a2-4d2f-9890-f2f7db1f2df7"), null, "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "DescriptionId", "RobotName" },
                values: new object[] { new Guid("5992b72c-cfe9-44c0-aee2-0e4ce652d5c0"), null, "T1" });

            migrationBuilder.CreateIndex(
                name: "IX_Robot_DescriptionId",
                table: "Robot",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Robot_Description_DescriptionId",
                table: "Robot",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
