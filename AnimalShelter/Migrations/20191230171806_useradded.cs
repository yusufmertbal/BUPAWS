using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class useradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PawUsers",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "Surname", "UserName" },
                values: new object[] { 1, new DateTime(2019, 12, 30, 20, 18, 6, 332, DateTimeKind.Local).AddTicks(8059), "YMB", "admin", "Bal", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
