using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class AddingAvailabilityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 125, 140, 19, 127, 82, 154, 187, 39, 171, 25, 94, 83, 137, 142, 64, 128, 243, 6, 116, 83 }, new byte[] { 165, 91, 175, 228, 244, 205, 212, 104, 22, 245, 26, 178, 21, 13, 119, 182 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 43, 199, 177, 44, 5, 54, 139, 113, 211, 224, 212, 90, 41, 110, 46, 75, 129, 162, 188 }, new byte[] { 131, 101, 66, 148, 254, 73, 42, 59, 251, 193, 196, 141, 230, 255, 59, 11 } });
        }
    }
}
