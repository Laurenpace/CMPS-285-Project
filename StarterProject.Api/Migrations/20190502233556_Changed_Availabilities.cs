using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Changed_Availabilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Availabilities");

            migrationBuilder.AddColumn<bool>(
                name: "FridayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FridayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MondayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MondayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SaturdayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SaturdayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SundayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SundayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThursdayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ThursdayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TuesdayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TuesdayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WednesdayAM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "WednesdayPM",
                table: "Availabilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 174, 129, 150, 252, 90, 155, 8, 109, 227, 4, 168, 217, 139, 43, 197, 164, 232, 165, 109, 39 }, new byte[] { 223, 219, 208, 248, 120, 160, 155, 78, 21, 41, 91, 173, 158, 126, 74, 77 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FridayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "FridayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "MondayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "MondayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "SaturdayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "SaturdayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "SundayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "SundayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "ThursdayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "ThursdayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "TuesdayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "TuesdayPM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "WednesdayAM",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "WednesdayPM",
                table: "Availabilities");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Availabilities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Availabilities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 216, 212, 185, 190, 141, 198, 215, 240, 132, 239, 210, 143, 112, 55, 129, 203, 2, 78, 92 }, new byte[] { 199, 113, 40, 28, 93, 184, 230, 72, 104, 189, 48, 18, 107, 172, 62, 227 } });
        }
    }
}
