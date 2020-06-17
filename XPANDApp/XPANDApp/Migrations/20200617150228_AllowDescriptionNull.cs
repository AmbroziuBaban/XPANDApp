using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XPANDApp.Migrations
{
    public partial class AllowDescriptionNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Description_DescriptionId",
                table: "Planet");

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("06641d0a-9ad0-4384-8641-f3f2ac6fb65e"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("a485cbed-58dd-4c50-b542-13a5c93b8860"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DescriptionId",
                table: "Planet",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("aac6fabe-324e-40e6-b8b9-1ddc53e3e01d"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("c00f4a31-1da6-451b-8cc5-c1f8f33a4ae4"), "T1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Description_DescriptionId",
                table: "Planet",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planet_Description_DescriptionId",
                table: "Planet");

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("aac6fabe-324e-40e6-b8b9-1ddc53e3e01d"));

            migrationBuilder.DeleteData(
                table: "Robot",
                keyColumn: "RobotId",
                keyValue: new Guid("c00f4a31-1da6-451b-8cc5-c1f8f33a4ae4"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DescriptionId",
                table: "Planet",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("a485cbed-58dd-4c50-b542-13a5c93b8860"), "T0" });

            migrationBuilder.InsertData(
                table: "Robot",
                columns: new[] { "RobotId", "RobotName" },
                values: new object[] { new Guid("06641d0a-9ad0-4384-8641-f3f2ac6fb65e"), "T1" });

            migrationBuilder.AddForeignKey(
                name: "FK_Planet_Description_DescriptionId",
                table: "Planet",
                column: "DescriptionId",
                principalTable: "Description",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
