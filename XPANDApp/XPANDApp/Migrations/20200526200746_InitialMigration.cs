using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Captain",
                columns: table => new
                {
                    CaptainId = table.Column<Guid>(nullable: false),
                    CaptainName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captain", x => x.CaptainId);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    DescriptionId = table.Column<Guid>(nullable: false),
                    DescriptionText = table.Column<string>(nullable: true),
                    CaptainId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.DescriptionId);
                    table.ForeignKey(
                        name: "FK_Description_Captain_CaptainId",
                        column: x => x.CaptainId,
                        principalTable: "Captain",
                        principalColumn: "CaptainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planet",
                columns: table => new
                {
                    PlanetId = table.Column<Guid>(nullable: false),
                    PlanetName = table.Column<string>(maxLength: 30, nullable: false),
                    PlanetImage = table.Column<byte[]>(nullable: true),
                    PlanetStatus = table.Column<byte>(nullable: false),
                    DescriptionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planet", x => x.PlanetId);
                    table.ForeignKey(
                        name: "FK_Planet_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Robot",
                columns: table => new
                {
                    RobotId = table.Column<Guid>(nullable: false),
                    RobotName = table.Column<string>(maxLength: 30, nullable: false),
                    DescriptionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robot", x => x.RobotId);
                    table.ForeignKey(
                        name: "FK_Robot_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "DescriptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Description_CaptainId",
                table: "Description",
                column: "CaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_Planet_DescriptionId",
                table: "Planet",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Robot_DescriptionId",
                table: "Robot",
                column: "DescriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planet");

            migrationBuilder.DropTable(
                name: "Robot");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Captain");
        }
    }
}
