using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class vaccinetableanddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pawVaccines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pawVaccines", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 16, 27, 36, 337, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.InsertData(
                table: "pawVaccines",
                columns: new[] { "Id", "VaccineName" },
                values: new object[,]
                {
                    { 1, "Aşılı" },
                    { 2, "Aşısız" },
                    { 3, "Bilinmiyor" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pawVaccines");

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 15, 12, 55, 195, DateTimeKind.Local).AddTicks(7364));
        }
    }
}
