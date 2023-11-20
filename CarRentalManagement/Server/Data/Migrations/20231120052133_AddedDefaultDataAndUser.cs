using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "5040a670-88be-44c9-a772-e445cb20ce71", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOjdBKjsIpQismaV+krJB9uJodXL6fFMPVU6GQtgK7NYt6xovWgeKWK6lU6z9yO5pQ==", null, false, "567d1a73-16dc-4804-a57b-481c024016cd", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7082), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7099), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7104), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7557), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7558), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7560), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7561), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7761), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7763), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7765), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7767), new DateTime(2023, 11, 20, 13, 21, 32, 677, DateTimeKind.Local).AddTicks(7767), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
