using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogRecovery.Infrastruture.Data.Migrations
{
    public partial class UpdatedDefaultLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "RecordedTime" },
                values: new object[] { new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LogsRecoveries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "RecordedTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 3, 2, 2, 15, 500, DateTimeKind.Local).AddTicks(2921) });
        }
    }
}
