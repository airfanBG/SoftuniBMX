using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "89545dcf-33ae-4b29-9bdd-60439a5d3e55", new DateTime(2023, 12, 6, 18, 21, 38, 206, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 12, 6, 18, 21, 38, 206, DateTimeKind.Local).AddTicks(7327), "AQAAAAIAAYagAAAAEIPalvOG8A/FfU0jcw8CHCHqEz8VqdwG8ZbxUzDbVAJ+SgRmrN3NmUuZTV1Eo+y+0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f4aac8ef-7dbd-4e31-a5bb-164c44635976", new DateTime(2023, 12, 6, 18, 21, 38, 127, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 12, 6, 18, 21, 38, 127, DateTimeKind.Local).AddTicks(9928), "AQAAAAIAAYagAAAAEKb7KYnNyvwlyTkbvPKHElimX/O5iyZxoDKml66OdKdVl7K8rWey1kGBWpaEMkiWsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "0bb385f9-57c7-4654-8331-7e111438c6f1", new DateTime(2023, 12, 6, 18, 21, 38, 351, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 12, 6, 18, 21, 38, 351, DateTimeKind.Local).AddTicks(2124), "AQAAAAIAAYagAAAAEKhj5+HhvLAcMxceFjEWZQ7CqW87PzLzaOvyMEa2oay5muKAXhOhLDHXInQlwxi3zQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "11490ed6-7822-41e3-9a4c-586c6304f1f5", new DateTime(2023, 12, 6, 18, 21, 38, 46, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 12, 6, 18, 21, 38, 46, DateTimeKind.Local).AddTicks(6656), "AQAAAAIAAYagAAAAED6iS56o+4+CLd1KXML1P3cj10UsuwPQpzEBRHlDWxQLt/Eidny9wn+Qnran54NP6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "a6db2b6e-dae0-499c-a622-a8f8ab120149", new DateTime(2023, 12, 6, 18, 21, 38, 283, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 12, 6, 18, 21, 38, 283, DateTimeKind.Local).AddTicks(9847), "AQAAAAIAAYagAAAAEI+MFjMoF4+G0CIhLmpjZDdDAL5LDyP5tV6RkU08Qn92WpmwVsnwBexvskGNS9CC7A==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "b291706b-992f-4737-9c1e-ab1aa05ff7d5", new DateTime(2023, 12, 6, 18, 21, 37, 886, DateTimeKind.Local).AddTicks(6489), "AQAAAAIAAYagAAAAECMl+PLrY5lpWweVmY8wWCbzpBqo8XIAnkYhPDpNnEpVoImddThsCTIdNrf2wlvA9Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "cd6e8127-15ed-40e8-bf1c-2b60ac76ed5a", new DateTime(2023, 12, 6, 18, 21, 37, 968, DateTimeKind.Local).AddTicks(3152), "AQAAAAIAAYagAAAAEJ9Tgth/JoZGA8QkKIxfm7x0sEiJb5F+QP8KrP+iMSfPYBOw7narteiADsEDHBHlPg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "49e83ba8-9755-477f-8d4f-8bef59d87adf", new DateTime(2023, 12, 6, 18, 21, 37, 797, DateTimeKind.Local).AddTicks(4541), "AQAAAAIAAYagAAAAEBuLKSybYzVOHH2NSuU5VfHZbXDC1o+N2AV7+4f6i4h+U7CgDdgOBxhYsxrJeOw7cA==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(5935), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6019), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6022), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.InsertData(
                table: "Delivaries",
                columns: new[] { "Id", "DateDeleted", "DateDelivered", "DateUpdated", "IsDeleted", "Note", "PartId", "QuantityDelivered", "SuplierId" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6026), false, "text4", 1, 4.0, 1 },
                    { 5, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6029), false, "text5", 4, 4.0, 2 },
                    { 6, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6032), false, "text6", 7, 2.0, 3 },
                    { 7, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6035), false, "text7", 1, 3.0, 1 },
                    { 8, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6038), false, "text8", 4, 5.0, 2 },
                    { 9, null, new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6041), false, "text9", 7, 4.0, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "Description", "Discount", "FinalAmount", "IsDeleted", "PaidAmount", "SaleAmount", "StatusId", "UnpaidAmount", "VAT" },
                values: new object[,]
                {
                    { 4, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6368), null, null, null, "test4", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 5, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6371), null, null, null, "test5", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 6, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6375), null, null, null, "test6", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m },
                    { 7, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6378), null, null, null, "test7", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 8, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6381), null, null, null, "test8", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 9, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6385), null, null, null, "test9", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m }
                });

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7349), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7352), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7355), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7261), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7264), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7267), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7270), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7275), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7278), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7288), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7295), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7298), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7080), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7086), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7090), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7134), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7171), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "DatetimeAsigned", "Description", "EmployeeId", "EndDatetime", "IsCompleted", "IsDeleted", "PartName", "PartPrice", "PartQuantity", "SerialNumber", "StartDatetime" },
                values: new object[,]
                {
                    { 4, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 4, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 4, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null },
                    { 5, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 5, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 5, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null },
                    { 6, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 6, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 6, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null },
                    { 7, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 7, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 7, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null },
                    { 8, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 8, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 8, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null },
                    { 9, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 9, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 9, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 4, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 4, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 4, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 5, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 5, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 5, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 6, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 6, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 6, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 7, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 7, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 7, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 8, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 8, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 8, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 9, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 9, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 9, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "4aa89585-3f89-4461-8a93-a3872bf425a3", new DateTime(2023, 12, 6, 14, 9, 53, 91, DateTimeKind.Local).AddTicks(7683), new DateTime(2023, 12, 6, 14, 9, 53, 91, DateTimeKind.Local).AddTicks(7679), "AQAAAAIAAYagAAAAEHkMJBno7jcjUfDPQYqPG7SMbXxM+1mdyqTMampODGuo3lpBP/pv5ys1X3IsCJTUKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "bc4cbef9-a265-49e7-baaa-8dd3c6388ea2", new DateTime(2023, 12, 6, 14, 9, 53, 30, DateTimeKind.Local).AddTicks(3351), new DateTime(2023, 12, 6, 14, 9, 53, 30, DateTimeKind.Local).AddTicks(3343), "AQAAAAIAAYagAAAAEL/AmIfDyAQYd5OB8GKgY8D4lWtekPGtTKB01RE66g57Pkc0reDU3/6VNyHf7oGPVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "c20bb58d-d7ec-4f79-98c8-a507d5d18586", new DateTime(2023, 12, 6, 14, 9, 53, 219, DateTimeKind.Local).AddTicks(3124), new DateTime(2023, 12, 6, 14, 9, 53, 219, DateTimeKind.Local).AddTicks(3083), "AQAAAAIAAYagAAAAEKDlo0MSF1VTDuDoxm6CHXgvxdmiaBQqOwnJw1L8qhfhApCr/Y+c6yMk/e3to0YkPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "6d43d9c5-1aa5-45b8-a3ef-9af62f67280b", new DateTime(2023, 12, 6, 14, 9, 52, 968, DateTimeKind.Local).AddTicks(6470), new DateTime(2023, 12, 6, 14, 9, 52, 968, DateTimeKind.Local).AddTicks(6454), "AQAAAAIAAYagAAAAEJ0wc6zSBDUi7dSc8/3JtseG1IIgCJ/zxfQGtjLwjCCKlfMw6JYGONV19UDVfhXILg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "4bc7f58b-7978-4931-ab97-71102add4b8a", new DateTime(2023, 12, 6, 14, 9, 53, 153, DateTimeKind.Local).AddTicks(8582), new DateTime(2023, 12, 6, 14, 9, 53, 153, DateTimeKind.Local).AddTicks(8526), "AQAAAAIAAYagAAAAEMI6n1aVpNscOcGTVqVhhyOsaoohzM/Ny0ArUGlEutPbZ8qfZ/fMsnxCqKlexm/5UQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "fa5f415b-5713-43ea-8c10-02eb3644f2fb", new DateTime(2023, 12, 6, 14, 9, 52, 842, DateTimeKind.Local).AddTicks(1867), "AQAAAAIAAYagAAAAEI/t2k9oYFopjVcxWjipZVd/p0Ps6rElyVBgncZV49GrEiTrc+NT5L1x7PzKO5bkvQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "b6cafed7-6ab1-4fed-b275-8a27e253ae3d", new DateTime(2023, 12, 6, 14, 9, 52, 906, DateTimeKind.Local).AddTicks(6230), "AQAAAAIAAYagAAAAEG42a4F0P+YGP29utq0NVd/KmKDlFL9LXjscFBe3geyFqHUps6GVq7rJoWskU2xPpA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "e6148dc6-e55e-4fda-941e-8886a6ae154d", new DateTime(2023, 12, 6, 14, 9, 52, 773, DateTimeKind.Local).AddTicks(1087), "AQAAAAIAAYagAAAAEH7xQr68ZVXsMeg9equGbjlVLowS6ny86Eho4nrKokuVffJJFRfyTczqOLKb9H3owg==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6472), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6553), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6556), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7502), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7505), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7428), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7431), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7434), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7439), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7449), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7451), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7304), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7308), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7312), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7391), new DateTime(2023, 12, 6, 14, 9, 53, 282, DateTimeKind.Local).AddTicks(7392) });
        }
    }
}
