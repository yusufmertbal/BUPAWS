using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class animalTableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pawAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(maxLength: 100, nullable: false),
                    Species = table.Column<string>(maxLength: 100, nullable: false),
                    AnimalArea = table.Column<string>(maxLength: 100, nullable: false),
                    Vaccine = table.Column<string>(maxLength: 256, nullable: false),
                    Health = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pawAnimals", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 17, 39, 21, 591, DateTimeKind.Local).AddTicks(8784));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pawAnimals");

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 16, 35, 44, 252, DateTimeKind.Local).AddTicks(3644));
        }
    }
}
