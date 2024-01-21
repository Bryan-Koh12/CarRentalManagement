using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomerID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleID",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Bookings",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Bookings",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_VehicleID",
                table: "Bookings",
                newName: "IX_Bookings_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CustomerID",
                table: "Bookings",
                newName: "IX_Bookings_CustomerId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e7d13b2-f291-4c29-86eb-a3fe23ee5a70", "AQAAAAIAAYagAAAAEDZAOcx8v7HtGxZULzQ/uP8mTKNTfR28cNR7zGGigOcL1pmGGpvSdD5FAZSGGi095Q==", "eab3378c-0b35-4945-b8c2-f022c8c1186b" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3503), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3518), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3846), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3846) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3848), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4029), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 1, 8, 12, 20, 31, 972, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomerId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Vehicles_VehicleId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Bookings",
                newName: "VehicleID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Bookings",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_VehicleId",
                table: "Bookings",
                newName: "IX_Bookings_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                newName: "IX_Bookings_CustomerID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "560f49cc-b550-4662-a9a7-5d509e5b1dbd", "AQAAAAIAAYagAAAAEB3/CKI+CZruqphteTtqtyeyCg+t/39CindDHQUONfINSFayvsJ0Wpl04KVbmPCLJQ==", "c0519e86-e5df-48fb-a54f-54f2028e9aab" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6181), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6520), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6703), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6706), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6708), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 1, 3, 12, 23, 44, 13, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomerID",
                table: "Bookings",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Vehicles_VehicleID",
                table: "Bookings",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
