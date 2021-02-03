using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogRecovery.Infrastruture.Data.Migrations
{
    public partial class Commonfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "LogsRecoveries",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "LogsRecoveries",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "LogsRecoveries",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordedTime",
                value: new DateTime(2021, 2, 3, 2, 2, 15, 500, DateTimeKind.Local).AddTicks(2921));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "LogsRecoveries");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "LogsRecoveries");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "LogsRecoveries");

            migrationBuilder.UpdateData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1,
                column: "RecordedTime",
                value: new DateTime(2021, 2, 3, 1, 6, 21, 767, DateTimeKind.Local).AddTicks(9492));
        }
    }
}
