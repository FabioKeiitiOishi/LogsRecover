using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LogRecovery.Infrastruture.Data.Migrations
{
    public partial class NewGlobalConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "LogsRecoveries",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "LogsRecoveries",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 4, 0, 14, 53, 214, DateTimeKind.Local).AddTicks(5951),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "LogsRecoveries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Ip", "RecordedTime", "UserAgent" },
                values: new object[] { 1, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "192.168.0.1", new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "GET HTTP 1.0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<bool>(
                name: "Deleted",
                table: "LogsRecoveries",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "LogsRecoveries",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2021, 2, 4, 0, 14, 53, 214, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.InsertData(
                table: "LogsRecoveries",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "Deleted", "Ip", "RecordedTime", "UserAgent" },
                values: new object[] { 1, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "192.168.0.1", new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "GET HTTP 1.0" });
        }
    }
}
