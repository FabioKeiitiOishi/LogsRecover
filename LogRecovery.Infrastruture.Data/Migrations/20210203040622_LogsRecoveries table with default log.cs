using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogRecovery.Infrastruture.Data.Migrations
{
    public partial class LogsRecoveriestablewithdefaultlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LogsRecoveries",
                columns: new[] { "Id", "Ip", "RecordedTime", "UserAgent" },
                values: new object[] { 1, "192.168.0.1", new DateTime(2021, 2, 3, 1, 6, 21, 767, DateTimeKind.Local).AddTicks(9492), "GET HTTP 1.0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
