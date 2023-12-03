using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class RaitingsSeededInDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "942c14c8-1d9d-4979-a7ae-5d40fbb9d2cf", new DateTime(2023, 11, 28, 13, 18, 55, 290, DateTimeKind.Local).AddTicks(8844), new DateTime(2023, 11, 28, 13, 18, 55, 290, DateTimeKind.Local).AddTicks(8821), "AQAAAAIAAYagAAAAEF9sijAiLYixdiMLBKcOaCI8q10EujMzXAGeCd1zaG7zArVtIZyJl0MNof9QUILW8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "d669f0bf-0e76-4527-a4d9-83633c3d34b8", new DateTime(2023, 11, 28, 13, 18, 55, 229, DateTimeKind.Local).AddTicks(2098), new DateTime(2023, 11, 28, 13, 18, 55, 229, DateTimeKind.Local).AddTicks(2076), "AQAAAAIAAYagAAAAEA+ZgvJ/BuDHQ5ssf0NvZpgD68kFv4EaUV+Ah8efNPCjJI3ylcRlPPKNtE/0JnU0cQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "a9469bd9-fde7-4c6e-b777-c737cf04605a", new DateTime(2023, 11, 28, 13, 18, 55, 414, DateTimeKind.Local).AddTicks(7486), new DateTime(2023, 11, 28, 13, 18, 55, 414, DateTimeKind.Local).AddTicks(7480), "AQAAAAIAAYagAAAAENLVGjM0paAA8EYhsM/N9RAlF8B2Zp1UdUDgG70GNX34D/O82PIdMifhScVRMNZK9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "97a79680-5f85-4016-984f-372553d371a6", new DateTime(2023, 11, 28, 13, 18, 55, 163, DateTimeKind.Local).AddTicks(1161), new DateTime(2023, 11, 28, 13, 18, 55, 163, DateTimeKind.Local).AddTicks(1141), "AQAAAAIAAYagAAAAEFCx7chNrCQ6tmFvZgR4BFUiDdNmW5Wv0bvTtsPQub/SNBg8TsZfAXYIiKY/xozIWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "a543bbe1-03e8-4a25-b1b1-481babe37ab4", new DateTime(2023, 11, 28, 13, 18, 55, 352, DateTimeKind.Local).AddTicks(6640), new DateTime(2023, 11, 28, 13, 18, 55, 352, DateTimeKind.Local).AddTicks(6589), "AQAAAAIAAYagAAAAENOCIBFkKtLNUZcTW7H3/ALU30x72VQvPk+Ytka6AaGoIDsm/M9VtSr1FYBPpGbbiQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "dd5c5d5e-ee27-4b72-9698-a9f3170be303", new DateTime(2023, 11, 28, 13, 18, 55, 38, DateTimeKind.Local).AddTicks(5366), "AQAAAAIAAYagAAAAEH4M7ukABI7TMY8aK2i3NHojkyqEbmzAZ4Ti4FqhK5wwTdY9MRcxdqL+/gkunnt6Hg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "3977b317-65ec-443f-a428-32e2dfe65b50", new DateTime(2023, 11, 28, 13, 18, 55, 100, DateTimeKind.Local).AddTicks(1964), "AQAAAAIAAYagAAAAEGi54Qo1Nybq93lqQyEzqLrpkt+O+dbTQcF9yTMpWz3GZJvKYkU3Vz5pt014Nwr65Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "c3ff8beb-d112-4f7c-a4e6-c3005c29b1e3", new DateTime(2023, 11, 28, 13, 18, 54, 977, DateTimeKind.Local).AddTicks(3177), "AQAAAAIAAYagAAAAEP3bQ4wizkL59RQ7igwmkyDm1cf0Sqx6L1UoTg/EdBnpKDcpRRpH/WQXDmBZAonrAA==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5163), new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ClientId", "PartId", "Rating" },
                values: new object[,]
                {
                    { "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", 1, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 1, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 2, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 2, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 3, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 3, 6 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 4, 3 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 4, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 5, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 5, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 6, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 6, 6 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 7, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 7, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 8, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 9, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 9, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 10, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 10, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6086), new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6125), new DateTime(2023, 11, 28, 13, 18, 55, 476, DateTimeKind.Local).AddTicks(6127) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", 1 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 1 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 2 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 2 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 3 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 3 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 4 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 4 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 5 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 5 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 6 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 6 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 7 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 7 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 8 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 9 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 9 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "99d3ca6f-2067-4316-a5d7-934c93789521", 10 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 10 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "d43e948e-5c83-4527-b69a-3c1a4accfd3a", new DateTime(2023, 11, 28, 9, 11, 7, 851, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 11, 28, 9, 11, 7, 851, DateTimeKind.Local).AddTicks(4535), "AQAAAAIAAYagAAAAEPCXl7VyGPCG2k3PdWx5iXfWjBpcFUFPqIQvaHOG0fLkE7CnsSa9Y9Ly5tyAZtCJqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "83170453-beb4-456c-8a62-3446be655d13", new DateTime(2023, 11, 28, 9, 11, 7, 790, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 11, 28, 9, 11, 7, 790, DateTimeKind.Local).AddTicks(4867), "AQAAAAIAAYagAAAAENgqwqG0NB9HCcl27wi5g/Wvd1CTwKmVTu4teSGUd+fnc0oFgpEVLM7MOTM//0bDnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f45fcfc9-d64b-42b0-8e4a-f935616b8009", new DateTime(2023, 11, 28, 9, 11, 7, 975, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 11, 28, 9, 11, 7, 975, DateTimeKind.Local).AddTicks(1829), "AQAAAAIAAYagAAAAELzFiy5gd3X5y5SFJxzMuAPOWDQpuwreT9+YUEZVM4a9yM47TIX/UGpbQ8cKcRjwtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "db6d4d5e-df3c-45e4-96e8-f360330f8f69", new DateTime(2023, 11, 28, 9, 11, 7, 728, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 11, 28, 9, 11, 7, 728, DateTimeKind.Local).AddTicks(6861), "AQAAAAIAAYagAAAAEG60SKcphyjHnYvW7m2YC+APYeRdOZcTU7j6NsHGP840kKMmGFLguswYGuBrocBdNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f3288a84-56de-4afc-bcfa-c505af51097c", new DateTime(2023, 11, 28, 9, 11, 7, 912, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 11, 28, 9, 11, 7, 912, DateTimeKind.Local).AddTicks(4372), "AQAAAAIAAYagAAAAELDq/30v9sAQgMUvUf6uYHAEBpRj0Selz1qJ4k2sl2tkJKyCgGiwruhDv3pwyz5lhQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "c952d748-7b61-4bdc-aee2-d4230db25219", new DateTime(2023, 11, 28, 9, 11, 7, 595, DateTimeKind.Local).AddTicks(676), "AQAAAAIAAYagAAAAEE73Vg8HgpyIRVEsmlewLaoptmVeDv7DQNIlgybZzFicaf9YHFfyHR14typYACPvAA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "edbba8ca-ab70-4d4c-a9e6-0f0118192d84", new DateTime(2023, 11, 28, 9, 11, 7, 663, DateTimeKind.Local).AddTicks(608), "AQAAAAIAAYagAAAAEHOfuHKFU1ea1KN6ceR5rFvkWaiBxcpaJT+2LoGd8zz9XZoTqKsu2XFwoOAUiuPAVA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "9483ad26-cd91-47a8-8494-324d44004cda", new DateTime(2023, 11, 28, 9, 11, 7, 526, DateTimeKind.Local).AddTicks(4276), "AQAAAAIAAYagAAAAEJxti6KNB9riqhXP96tmyjrlsGFuzliOjNsJaZyyIQIPjk+eiy98MXIW+XS4XTOMIQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6985), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7063), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7064) });
        }
    }
}
