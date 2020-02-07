using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class AvailabilityDBcontextAdding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 125, 140, 19, 127, 82, 154, 187, 39, 171, 25, 94, 83, 137, 142, 64, 128, 243, 6, 116, 83 }, new byte[] { 165, 91, 175, 228, 244, 205, 212, 104, 22, 245, 26, 178, 21, 13, 119, 182 } });
        }
    }
}
