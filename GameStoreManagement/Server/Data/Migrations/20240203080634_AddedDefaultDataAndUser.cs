using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Platform", "Price", "ReleaseDate", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(723), "Call of Duty", "Play Station", 49.899999999999999, new DateTime(2009, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" },
                    { 2, "System", new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(726), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(726), "Need for Speed", "X-box", 39.899999999999999, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "System" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "ContactNumber", "Createdby", "DOB", "DateCreated", "DateUpdated", "Email", "NRIC", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "New York", "96750134", "System", new DateTime(2002, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(978), "emily@gmail.com", "K2456345T", "Edward Williams", "System" },
                    { 2, "Boston", "80850134", "System", new DateTime(1981, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 2, 3, 16, 6, 34, 517, DateTimeKind.Local).AddTicks(980), "jamie.dornan@gmail.com", "T7458445J", "Dave Jonas", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
