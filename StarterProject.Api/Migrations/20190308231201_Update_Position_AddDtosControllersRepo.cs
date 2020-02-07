using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Update_Position_AddDtosControllersRepo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 112, 191, 61, 10, 76, 233, 217, 105, 195, 26, 234, 212, 16, 55, 103, 8, 120, 165, 244, 104 }, new byte[] { 197, 55, 209, 33, 211, 167, 255, 192, 168, 176, 226, 118, 120, 198, 128, 63 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 236, 170, 240, 101, 38, 136, 80, 61, 17, 172, 56, 128, 106, 98, 169, 76, 87, 125, 78, 174 }, new byte[] { 136, 113, 229, 42, 67, 21, 55, 162, 9, 20, 78, 162, 35, 104, 214, 225 } });
        }
    }
}
