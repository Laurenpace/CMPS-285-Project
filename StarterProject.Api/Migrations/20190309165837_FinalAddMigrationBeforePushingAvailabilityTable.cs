using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class FinalAddMigrationBeforePushingAvailabilityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 87, 71, 48, 138, 51, 32, 19, 187, 21, 197, 95, 105, 100, 222, 202, 171, 20, 189, 169 }, new byte[] { 194, 78, 12, 85, 55, 252, 110, 167, 217, 206, 199, 206, 158, 9, 161, 114 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "End", "Start" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 11, 144, 109, 242, 224, 20, 190, 231, 101, 182, 68, 70, 133, 60, 234, 212, 9, 126, 153 }, new byte[] { 7, 211, 151, 157, 33, 213, 209, 112, 108, 52, 193, 213, 147, 224, 231, 148 } });
        }
    }
}
