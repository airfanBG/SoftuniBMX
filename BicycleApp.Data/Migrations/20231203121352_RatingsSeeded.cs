using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RatingsSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "45cebc3f-0a2c-4f26-9458-83d40680f44a", new DateTime(2023, 12, 3, 14, 13, 52, 393, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 12, 3, 14, 13, 52, 393, DateTimeKind.Local).AddTicks(4064), "AQAAAAIAAYagAAAAEMx7PYgw0fbB0WVg4HAN8qNT8aL0pqDPYCMybjvH8DOie+bjrW+nubfA30m+3/m2og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "496a4bce-c972-44bf-91fb-6cc3a7a4b514", new DateTime(2023, 12, 3, 14, 13, 52, 331, DateTimeKind.Local).AddTicks(1689), new DateTime(2023, 12, 3, 14, 13, 52, 331, DateTimeKind.Local).AddTicks(1598), "AQAAAAIAAYagAAAAEFNasHRxwXbXfobaiakpshPZ64taBardLsk7jtX5cN0y4Q9t8YapB/1PmIsycw9Jvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "2ae08d6c-ccb2-438f-a68f-b641872ffac4", new DateTime(2023, 12, 3, 14, 13, 52, 520, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 12, 3, 14, 13, 52, 520, DateTimeKind.Local).AddTicks(8505), "AQAAAAIAAYagAAAAEKnhPMCa7CiTKQaZFJBIreTbTCZoj5nwB1yayhhKgdJS00wU41130++EwbpwgTmtwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "15697442-f55a-413a-b828-998435c2f5dd", new DateTime(2023, 12, 3, 14, 13, 52, 268, DateTimeKind.Local).AddTicks(1261), new DateTime(2023, 12, 3, 14, 13, 52, 268, DateTimeKind.Local).AddTicks(1216), "AQAAAAIAAYagAAAAEHtA2y9cIFN8ocIqrrnFU/gU3+7hYfNnb8WaPbqaADQmJyB9euIV7qPotP0TuZGXsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "0a59cb01-ffff-46cc-a9c9-8a64583b78e4", new DateTime(2023, 12, 3, 14, 13, 52, 457, DateTimeKind.Local).AddTicks(4494), new DateTime(2023, 12, 3, 14, 13, 52, 457, DateTimeKind.Local).AddTicks(4336), "AQAAAAIAAYagAAAAEDR65P06kitdlRJdqCr8vNCNN5+PayECOv7GSzLb+ZAKNdszTGnQJIRVfLtZ1VYNjw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "3bf68036-59bb-4180-b827-06f42d651e4c", new DateTime(2023, 12, 3, 14, 13, 52, 136, DateTimeKind.Local).AddTicks(8490), "AQAAAAIAAYagAAAAEBpy8ogb5HHEgKvpxJxlmF4he/7hTvUyQnSuwMFCKpzMLmJd87CZWU0B+MsA18jmTw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "de53b567-ad67-49c5-88f0-2d8aa3ff7b0d", new DateTime(2023, 12, 3, 14, 13, 52, 205, DateTimeKind.Local).AddTicks(2320), "AQAAAAIAAYagAAAAEBX49VrjCTHcuU22nHIhZXdUr2VOT2c1H8rwqzRhCeSgLLCKqy1HprmWGgD2Qth0wQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "d6d99a1a-4524-4944-bc8e-8394758884ac", new DateTime(2023, 12, 3, 14, 13, 52, 67, DateTimeKind.Local).AddTicks(6076), "AQAAAAIAAYagAAAAEBDXx8m4dVLyqEPgTdsdd5KBPmG1XZxiNcE4dmVE24wrXfY3aw7cKLOkUpBGvO2mlQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2386), new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ClientId", "PartId", "Rating" },
                values: new object[,]
                {
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 11, 3 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 11, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 12, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 12, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 13, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 13, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 14, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 14, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 15, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 15, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 16, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 16, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 17, 2 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 17, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3167), new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3203), new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3237), new DateTime(2023, 12, 3, 14, 13, 52, 584, DateTimeKind.Local).AddTicks(3238) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 11 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 11 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 12 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 12 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 13 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 13 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 14 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 14 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 15 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 15 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 16 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 16 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 17 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 17 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "bda69e76-c7f8-44c4-a3cf-29e8cf91f698", new DateTime(2023, 12, 3, 12, 46, 29, 245, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 12, 3, 12, 46, 29, 245, DateTimeKind.Local).AddTicks(3141), "AQAAAAIAAYagAAAAEEsoGdqTrlDDkZF25IkLgtvWa1I6980WZd3W0ZihbnuHQ5SPLcl2fnGj1oBd7k5c2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "9b028b03-f7a3-4c88-b30d-ad3ab7a2d3c4", new DateTime(2023, 12, 3, 12, 46, 29, 169, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 12, 3, 12, 46, 29, 169, DateTimeKind.Local).AddTicks(2616), "AQAAAAIAAYagAAAAEGKlT4HQi9svbQ3Tgt77/QIEvwmdDSQEqii/nMt3DCW8UVFKKwKPz2mZYwxyZ5O56g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "10255097-e35e-4c0f-b984-b531c0441bb7", new DateTime(2023, 12, 3, 12, 46, 29, 410, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 12, 3, 12, 46, 29, 410, DateTimeKind.Local).AddTicks(2797), "AQAAAAIAAYagAAAAEGzXp9aOnsVvVrrBR9qcIOMM5zMJrNKJFn7GDYUllD0nEYjr6SG37R4273+aWWdvkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "0e7646aa-7cbd-42fa-861e-e23c33844aff", new DateTime(2023, 12, 3, 12, 46, 29, 92, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 12, 3, 12, 46, 29, 92, DateTimeKind.Local).AddTicks(2984), "AQAAAAIAAYagAAAAEAV68zwxKptBMunUcYHG5Zy4/IJr53uDJMtfZBKkg1oXiXtMKJpza2OJBOjBpYtl2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "baecb5b5-8c9e-4ba0-b6fe-5e7a62f6b389", new DateTime(2023, 12, 3, 12, 46, 29, 333, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 12, 3, 12, 46, 29, 333, DateTimeKind.Local).AddTicks(5270), "AQAAAAIAAYagAAAAEDwpL04EZt/AA8DQTKe29JwnSN062h1gi6jOJPzOy5EtEgl6SNl6u+ZLvUVPYRpWnw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "8c32acc2-51a6-4cc9-859c-64044bdeb2ca", new DateTime(2023, 12, 3, 12, 46, 28, 930, DateTimeKind.Local).AddTicks(7487), "AQAAAAIAAYagAAAAEK35A5SxEro0JteXZ9whD4JXr+Iz6fXXmqpJAa+POy6eyq97SnMgn1PCSJ95WDrj5w==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "66bf009b-76d8-417a-bd3d-bf3ae2843ea4", new DateTime(2023, 12, 3, 12, 46, 29, 12, DateTimeKind.Local).AddTicks(8348), "AQAAAAIAAYagAAAAEFctUVH+bis88uUyacGoK0GvIDYZzOycVw/g33fJ+0KTZKgxL0T+9SPJygYZo+g3dw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "621cb756-f40f-4ca2-900a-c2f06d487e97", new DateTime(2023, 12, 3, 12, 46, 28, 848, DateTimeKind.Local).AddTicks(5379), "AQAAAAIAAYagAAAAEIo3v24qDQhLY83KvWlbejQRo0CKj6miCDOuWvVzn0I4pcxlWLDNHOV/7gHIjAkSzw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6533) });
        }
    }
}
