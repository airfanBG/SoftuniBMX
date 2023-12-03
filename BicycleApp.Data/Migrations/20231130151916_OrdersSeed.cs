using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrdersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "52224569-1628-4517-9a07-b54c60e7bd6c", new DateTime(2023, 11, 30, 17, 19, 15, 799, DateTimeKind.Local).AddTicks(7390), new DateTime(2023, 11, 30, 17, 19, 15, 799, DateTimeKind.Local).AddTicks(7374), "AQAAAAIAAYagAAAAEPHN7K+uMHxKFjDRQ7BMmns4xzLo5qYtX4TkR5MBNUatSrO62kgoR+2RYD24MbfVGw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "8ca73a46-0043-4389-aa98-7553e96703be", new DateTime(2023, 11, 30, 17, 19, 15, 737, DateTimeKind.Local).AddTicks(6768), new DateTime(2023, 11, 30, 17, 19, 15, 737, DateTimeKind.Local).AddTicks(6764), "AQAAAAIAAYagAAAAEPXle/1Ve2PLZoYYzAEUictAhmhPXePrg+I5qrqgy4Q5r++WrtrMnwTJGS6ekYg2tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "ed468490-8733-4d96-9b16-0c0a3b66063a", new DateTime(2023, 11, 30, 17, 19, 15, 937, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 11, 30, 17, 19, 15, 937, DateTimeKind.Local).AddTicks(4426), "AQAAAAIAAYagAAAAEOjm49eSprVOW9wm1rrYic9lTsSBBcN5x7kxMS6lmTociND9nKjHtjBDROY251rgEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "dcfc81c1-50b2-431b-bc02-0918f579da07", new DateTime(2023, 11, 30, 17, 19, 15, 676, DateTimeKind.Local).AddTicks(4593), new DateTime(2023, 11, 30, 17, 19, 15, 676, DateTimeKind.Local).AddTicks(4535), "AQAAAAIAAYagAAAAENfk/VBW+zJJx7hrFw8iO0BAmtu0uJheSZMkzPrcDRxiBfGTAXZUf+ypHOMMGkbcSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "103d66da-a739-416b-b5f2-1f4475474089", new DateTime(2023, 11, 30, 17, 19, 15, 863, DateTimeKind.Local).AddTicks(9578), new DateTime(2023, 11, 30, 17, 19, 15, 863, DateTimeKind.Local).AddTicks(9569), "AQAAAAIAAYagAAAAEPQVTCHpFqfvaXcAv1/nhxpIppk+YqKivfHN2YynBCGH6Rx8+BCuUPqVWKBGz1fvDA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "ba30a933-1558-4088-98af-fae8ddce226a", new DateTime(2023, 11, 30, 17, 19, 15, 550, DateTimeKind.Local).AddTicks(6318), "AQAAAAIAAYagAAAAEJrKu2PMSw/lP6cVh9ZWUkiQObBta1HQcLBNcNJ31sNPnWfxSGqpeofOUJoihIJEPQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "d287b1d3-43be-4f0c-bd68-25239b852d2d", new DateTime(2023, 11, 30, 17, 19, 15, 611, DateTimeKind.Local).AddTicks(9302), "AQAAAAIAAYagAAAAEByrxZk0bmRMSySR8rbsPA0d2ApeGme6tD7amyaqZ2kCBTMkCFC3yfvgNpAxu6q8VA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "e547560e-ba17-4596-9c24-5082da4bb0bf", new DateTime(2023, 11, 30, 17, 19, 15, 484, DateTimeKind.Local).AddTicks(5317), "AQAAAAIAAYagAAAAED1flFe/13Ydz8hV/psYbIjC8xAQj3ngE+MoZ4OAUkEI5qM/HNQhRU5zhkjiJUJ/6g==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 19, 16, 6, DateTimeKind.Local).AddTicks(9927), new DateTime(2023, 11, 30, 17, 19, 16, 6, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(18), new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "Description", "Discount", "FinalAmount", "IsDeleted", "PaidAmount", "SaleAmount", "StatusId", "UnpaidAmount", "VAT" },
                values: new object[,]
                {
                    { 2, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1111), null, null, null, "test2", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 3, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1115), null, null, null, "test3", 0m, 950.00m, false, 0m, 825.00m, 1, 750.00m, 125.00m }
                });

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1802), new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1837), new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1878), new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber", "DatetimeAsigned", "Description", "EmployeeId", "EndDatetime", "IsCompleted", "PartName", "PartPrice", "PartQuantity", "SerialNumber", "StartDatetime" },
                values: new object[,]
                {
                    { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "21003785-a275-4139-ae20-af6a6cf8fea8", null, false, "Frame OG2", 110.00m, 1.0, "BID12345679", null },
                    { 2, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "17063948-8fdc-417e-8fb7-2ae6bf572f94", null, false, "Wheel of the YearG2", 65.00m, 2.0, "BID12345679", null },
                    { 2, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", null, false, "Shift2", 220.00m, 2.0, "BID12345679", null },
                    { 3, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 3, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Wheel of the YearGT", 85.00m, 6.0, "BID12345680", null },
                    { 3, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Shift3", 290.00m, 4.0, "BID12345680", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "a0c4fa30-1ed8-4eb0-bbd0-9239c20ff744", new DateTime(2023, 11, 29, 10, 6, 50, 805, DateTimeKind.Local).AddTicks(2124), new DateTime(2023, 11, 29, 10, 6, 50, 805, DateTimeKind.Local).AddTicks(2107), "AQAAAAIAAYagAAAAELsMK519YV9j7JUoalpZQ/ezYQEsdCCy0ISHOIeejn7d2jeeF0pOhnnx3g1jsGHSVw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "1a103d7e-4660-48b9-8f1a-4e2a65a4fb10", new DateTime(2023, 11, 29, 10, 6, 50, 738, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 11, 29, 10, 6, 50, 738, DateTimeKind.Local).AddTicks(8779), "AQAAAAIAAYagAAAAELerDZZ+sbxkZ7jGg2prWVY3L9kQ2KwlbydQa/8/GagKWKoT66xo0irx5MsZH81LKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "071a530a-cb5c-478c-ad80-ad0d3fd34dee", new DateTime(2023, 11, 29, 10, 6, 50, 949, DateTimeKind.Local).AddTicks(3964), new DateTime(2023, 11, 29, 10, 6, 50, 949, DateTimeKind.Local).AddTicks(3940), "AQAAAAIAAYagAAAAEOqXFZGdDKmai8oV1+2d/n2aCZtKmFq4aaIIHwKTLk70MxNJQ5NGq2n0KeKFYJMPdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "aa116186-49b9-4875-b6e0-a679998d3cad", new DateTime(2023, 11, 29, 10, 6, 50, 670, DateTimeKind.Local).AddTicks(4551), new DateTime(2023, 11, 29, 10, 6, 50, 670, DateTimeKind.Local).AddTicks(4534), "AQAAAAIAAYagAAAAEGN8AjS7OSg00FdJSlo8OXekCEKco8ymmEddmChIXvddTbIyRONEOgAT9pTFp60yMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "e1b85246-ee62-461e-9377-cb9d22a154dc", new DateTime(2023, 11, 29, 10, 6, 50, 871, DateTimeKind.Local).AddTicks(6178), new DateTime(2023, 11, 29, 10, 6, 50, 871, DateTimeKind.Local).AddTicks(6116), "AQAAAAIAAYagAAAAECb2l/GcPEKUIK50rsPqobnsVdSkPXdbbJyMkyoD93QY3UM6GKfI8GRW5yKJI5Whmg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "01627dc7-9b38-43ae-9156-ce709bc400e6", new DateTime(2023, 11, 29, 10, 6, 50, 537, DateTimeKind.Local).AddTicks(2149), "AQAAAAIAAYagAAAAEHAjKF1VZssLRuAw4/bkduqTv27vkvMCoacQ9QgLxifTcghGMgLz5d29gpQrHtqA9Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "f8619550-2fc2-4151-b7dc-ec200e81a28d", new DateTime(2023, 11, 29, 10, 6, 50, 604, DateTimeKind.Local).AddTicks(580), "AQAAAAIAAYagAAAAENhGaZiZdjWMQUWhjkibVYQYgFJSY21eMFPIZv3T+dmvDHnp6G/wulLSqeLX2EbNpQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "4620ec20-5d09-4a48-840c-69d08ea52261", new DateTime(2023, 11, 29, 10, 6, 50, 470, DateTimeKind.Local).AddTicks(9471), "AQAAAAIAAYagAAAAEBnCmJcPjShdprWsvMKUwOz8W6OzGk+eJZIZePQ2oMMdb2YTEzO8B0kMxdpsEqCOLA==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7548), new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8301), new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8386), new DateTime(2023, 11, 29, 10, 6, 51, 70, DateTimeKind.Local).AddTicks(8387) });
        }
    }
}
