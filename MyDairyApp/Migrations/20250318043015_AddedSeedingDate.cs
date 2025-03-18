using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyDairyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DairyEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Content for entry 1", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7024), "Entry 1" },
                    { 2, "Content for entry 2", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7980), "Entry 2" },
                    { 3, "Content for entry 3", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7985), "Entry 3" },
                    { 4, "Content for entry 4", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7989), "Entry 4" },
                    { 5, "Content for entry 5", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7992), "Entry 5" },
                    { 6, "Content for entry 6", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(7996), "Entry 6" },
                    { 7, "Content for entry 7", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8000), "Entry 7" },
                    { 8, "Content for entry 8", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8004), "Entry 8" },
                    { 9, "Content for entry 9", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8008), "Entry 9" },
                    { 10, "Content for entry 10", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8012), "Entry 10" },
                    { 11, "Content for entry 11", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8016), "Entry 11" },
                    { 12, "Content for entry 12", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8020), "Entry 12" },
                    { 13, "Content for entry 13", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8023), "Entry 13" },
                    { 14, "Content for entry 14", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8027), "Entry 14" },
                    { 15, "Content for entry 15", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8031), "Entry 15" },
                    { 16, "Content for entry 16", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8035), "Entry 16" },
                    { 17, "Content for entry 17", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8039), "Entry 17" },
                    { 18, "Content for entry 18", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8042), "Entry 18" },
                    { 19, "Content for entry 19", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8046), "Entry 19" },
                    { 20, "Content for entry 20", new DateTime(2025, 3, 18, 10, 0, 14, 275, DateTimeKind.Local).AddTicks(8050), "Entry 20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DairyEntries",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
