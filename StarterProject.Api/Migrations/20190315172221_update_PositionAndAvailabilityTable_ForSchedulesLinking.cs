using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class update_PositionAndAvailabilityTable_ForSchedulesLinking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailabilityId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "PasswordHash", "PasswordSalt", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { "Seeded-Admin-Adress", "Seeded-Admin-City", new byte[] { 232, 67, 43, 57, 0, 2, 137, 97, 10, 206, 214, 188, 96, 140, 181, 158, 32, 22, 198, 149 }, new byte[] { 123, 236, 158, 2, 187, 83, 36, 61, 242, 151, 117, 194, 69, 3, 60, 11 }, "Seeded-Admin-PhoneNumber", "Seeded-Admin-State", "Seeded-Admin-ZipCode" });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_AvailabilityId",
                table: "Schedules",
                column: "AvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_PositionId",
                table: "Schedules",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Availabilities_AvailabilityId",
                table: "Schedules",
                column: "AvailabilityId",
                principalTable: "Availabilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Availabilities_AvailabilityId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_AvailabilityId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_PositionId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "AvailabilityId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Schedules");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "PasswordHash", "PasswordSalt", "PhoneNumber", "State", "ZipCode" },
                values: new object[] { null, null, new byte[] { 4, 43, 199, 177, 44, 5, 54, 139, 113, 211, 224, 212, 90, 41, 110, 46, 75, 129, 162, 188 }, new byte[] { 131, 101, 66, 148, 254, 73, 42, 59, 251, 193, 196, 141, 230, 255, 59, 11 }, null, null, null });
        }
    }
}
