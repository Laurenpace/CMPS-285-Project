using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_Position_AddPostDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 248, 89, 100, 221, 97, 141, 171, 194, 141, 54, 74, 159, 235, 19, 197, 160, 167, 17, 6, 78 }, new byte[] { 104, 128, 73, 242, 220, 190, 211, 221, 183, 189, 192, 201, 18, 27, 182, 138 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 191, 61, 10, 76, 233, 217, 105, 195, 26, 234, 212, 16, 55, 103, 8, 120, 165, 244, 104 }, new byte[] { 197, 55, 209, 33, 211, 167, 255, 192, 168, 176, 226, 118, 120, 198, 128, 63 } });
        }
    }
}
