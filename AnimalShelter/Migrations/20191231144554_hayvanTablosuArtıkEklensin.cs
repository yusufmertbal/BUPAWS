using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class hayvanTablosuArtıkEklensin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 17, 45, 53, 993, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.InsertData(
                table: "pawAnimals",
                columns: new[] { "Id", "AnimalArea", "AnimalName", "CreatedDate", "Health", "Species", "Vaccine" },
                values: new object[] { 1, "KK Kuzey Kampüs", "Harun", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hasta", "Köpek", "Aşılı" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pawAnimals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 17, 39, 21, 591, DateTimeKind.Local).AddTicks(8784));
        }
    }
}
