using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarterProject.Api.Migrations
{
    public partial class Add_Tokens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Schedules",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 216, 212, 185, 190, 141, 198, 215, 240, 132, 239, 210, 143, 112, 55, 129, 203, 2, 78, 92 }, new byte[] { 199, 113, 40, 28, 93, 184, 230, 72, 104, 189, 48, 18, 107, 172, 62, 227 } });

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules");

            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Schedules",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 67, 43, 57, 0, 2, 137, 97, 10, 206, 214, 188, 96, 140, 181, 158, 32, 22, 198, 149 }, new byte[] { 123, 236, 158, 2, 187, 83, 36, 61, 242, 151, 117, 194, 69, 3, 60, 11 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Positions_PositionId",
                table: "Schedules",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
