using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class DescriptionRobot2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("9ab95449-88c7-4883-b2e6-87440a8c41dd"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("b4f69f2d-7800-43b6-ac35-e4e2dafa59b6"));

            migrationBuilder.DropColumn(
                name: "RobotCrewId",
                table: "Description");

            migrationBuilder.CreateTable(
                name: "DescriptionRobot",
                columns: table => new
                {
                    DescriptionRobotId = table.Column<Guid>(nullable: false),
                    DescriptionId = table.Column<Guid>(nullable: false),
                    RobotId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionRobot", x => x.DescriptionRobotId);
                    table.ForeignKey(
                        name: "FK_DescriptionRobot_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DescriptionRobot_Robot_RobotId",
                        column: x => x.RobotId,
                        principalTable: "Robot",
                        principalColumn: "RobotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("54fea114-9799-4a13-9af0-eb612ce53206"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("ff67af90-c178-4c1a-922e-c902a70461e0"), "T1" });

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionRobot_DescriptionId",
                table: "DescriptionRobot",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionRobot_RobotId",
                table: "DescriptionRobot",
                column: "RobotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionRobot");

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("54fea114-9799-4a13-9af0-eb612ce53206"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("ff67af90-c178-4c1a-922e-c902a70461e0"));

            migrationBuilder.AddColumn<Guid>(
                name: "RobotCrewId",
                table: "Description",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "RobotsCrew",
                columns: table => new
                {
                    RobotsCrewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RobotIds = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobotsCrew", x => x.RobotsCrewId);
                });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("b4f69f2d-7800-43b6-ac35-e4e2dafa59b6"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("9ab95449-88c7-4883-b2e6-87440a8c41dd"), "T1" });

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
    }
}
