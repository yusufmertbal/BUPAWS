using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class AllDataAddedForAreaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 15, 12, 55, 195, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.InsertData(
                table: "pawAreas",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 2, "KK", "Kuzey Kampüs" },
                    { 3, "UK", "Uçaksavar Kampüs" },
                    { 4, "HK", "Hisar Kampüs" },
                    { 5, "SK", "Sarıtepe Kampüs" },
                    { 6, "KAK", "Kandilli Kampüs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pawAreas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 15, 9, 35, 180, DateTimeKind.Local).AddTicks(1787));
        }
    }
}
