using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class aDataIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 15, 9, 35, 180, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.InsertData(
                table: "pawAreas",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "GK", "Güney Kampüs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 15, 4, 54, 409, DateTimeKind.Local).AddTicks(2940));
        }
    }
}
