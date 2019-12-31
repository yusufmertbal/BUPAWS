using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class healthTableAndDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pawHealths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthyOrSick = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pawHealths", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 16, 35, 44, 252, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.InsertData(
                table: "pawHealths",
                columns: new[] { "Id", "HealthyOrSick" },
                values: new object[] { 2, "Hasta" });

            migrationBuilder.InsertData(
                table: "pawHealths",
                columns: new[] { "Id", "HealthyOrSick" },
                values: new object[] { 1, "Sağlıklı" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pawHealths");

            migrationBuilder.UpdateData(
                table: "PawUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 12, 31, 16, 27, 36, 337, DateTimeKind.Local).AddTicks(190));
        }
    }
}
