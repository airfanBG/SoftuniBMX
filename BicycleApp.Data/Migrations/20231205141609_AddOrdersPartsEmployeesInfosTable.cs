using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrdersPartsEmployeesInfosTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyFo~",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "OrderPartEmployeeOrderId",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "OrderPartEmployeePartId",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrdersPartsEmployeesInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Id of the order from the client");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "OrdersPartsEmployeesInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Id of the part");

            migrationBuilder.AddColumn<string>(
                name: "UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Separate unique products by serial number in one order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "aba88914-3322-46da-b197-1f0dc8c3f244", new DateTime(2023, 12, 5, 16, 16, 9, 17, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 12, 5, 16, 16, 9, 17, DateTimeKind.Local).AddTicks(4894), "AQAAAAIAAYagAAAAELo5A5UZEmIwOtD2QC1uBZx+jIG/Wk7XxwJf87QPEzpsfff1EtggRxRqDUpxVDfG5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "e3e8c96c-ebe6-46c2-8290-3b7ab6f8b569", new DateTime(2023, 12, 5, 16, 16, 8, 950, DateTimeKind.Local).AddTicks(9591), new DateTime(2023, 12, 5, 16, 16, 8, 950, DateTimeKind.Local).AddTicks(9573), "AQAAAAIAAYagAAAAEPO3ZMzc/QwlCnXqZoCGFTN/NVPvP/ZhfKxtPwA3HJ5NuQhlZEp9ltlJ32vMPXiAdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "0a486f9a-3d1f-4a55-a7f3-5d69a6b2bd04", new DateTime(2023, 12, 5, 16, 16, 9, 149, DateTimeKind.Local).AddTicks(9358), new DateTime(2023, 12, 5, 16, 16, 9, 149, DateTimeKind.Local).AddTicks(9334), "AQAAAAIAAYagAAAAEHHcHQhgz6fVKTM0oXEdeFQk1GbOTzHAMgk+Rk1dkwhsFeC4TNZkkmwYH0iwz++hXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "923a9822-231e-4593-afe9-d0c06ef19ab3", new DateTime(2023, 12, 5, 16, 16, 8, 884, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 12, 5, 16, 16, 8, 884, DateTimeKind.Local).AddTicks(5454), "AQAAAAIAAYagAAAAEN8k+RrIzxQi3nAeelFO2bYjSLNRxTq2Te+HroYfgyhn1+w+UeQjAKGcZB+8gpbHJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "314d83f3-7633-4411-aac4-7654a9d51359", new DateTime(2023, 12, 5, 16, 16, 9, 83, DateTimeKind.Local).AddTicks(7589), new DateTime(2023, 12, 5, 16, 16, 9, 83, DateTimeKind.Local).AddTicks(7530), "AQAAAAIAAYagAAAAEPR1LRGW65k0zX3XHiOGqiYlZqhj2jmiTlMhAsk1JPw4EaDf8sln+7+U0pqk8xRlxA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "e7b5dd45-8e2d-4112-92d7-9a0bf1b215d6", new DateTime(2023, 12, 5, 16, 16, 8, 751, DateTimeKind.Local).AddTicks(5177), "AQAAAAIAAYagAAAAEDU4T3VF/ra1/fds69BgDnzrgtgqNdcF82ne1oUqeSSKboaTvcqofBMZNJ/VwHGdfg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "68067d55-97e6-4b16-be61-1732b6fe13b5", new DateTime(2023, 12, 5, 16, 16, 8, 818, DateTimeKind.Local).AddTicks(214), "AQAAAAIAAYagAAAAEBRNgwTVF/fvb8Ld4XhhLuxrceSJmW+ARvXboCmoI8V4QjfTiffYnFo/1U5EYHGVBQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "3cc13cd5-f952-4dd3-87ce-d0a87ff4a36b", new DateTime(2023, 12, 5, 16, 16, 8, 684, DateTimeKind.Local).AddTicks(9527), "AQAAAAIAAYagAAAAEMnBodjLFknJkhinb8Zn4vVye9ptJWEwBxtzJ5U03T/LMhpZ7no5t6HiKiMWa5VdGw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2214), new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3197), new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3238), new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3275), new DateTime(2023, 12, 5, 16, 16, 9, 216, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderId_PartId_UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderId_PartId_UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                principalTable: "OrdersPartsEmployees",
                principalColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderId_PartId_UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderId_PartId_UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropColumn(
                name: "UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.AddColumn<int>(
                name: "OrderPartEmployeeOrderId",
                table: "OrdersPartsEmployeesInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderPartEmployeePartId",
                table: "OrdersPartsEmployeesInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "e751e766-8ef2-48b8-9406-e5e2d49a9f59", new DateTime(2023, 12, 5, 10, 20, 49, 122, DateTimeKind.Local).AddTicks(1716), new DateTime(2023, 12, 5, 10, 20, 49, 122, DateTimeKind.Local).AddTicks(1698), "AQAAAAIAAYagAAAAEOY+0WvlvsFr+rVT6av4x19IRAwKFGger+Iz16FK8l/i9HcyRyzBOre+3BKJUxpO2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "1c4e129f-d4b5-416f-8463-5432959adab9", new DateTime(2023, 12, 5, 10, 20, 49, 56, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 12, 5, 10, 20, 49, 56, DateTimeKind.Local).AddTicks(4075), "AQAAAAIAAYagAAAAEFvuCJPcx8qObV6e+Qt6aWL9R54rH3e718Os3tvhzkCvq9danst7627j5J/DaPoxSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "c7aa832c-2672-442e-a1e1-6f452e4fcbed", new DateTime(2023, 12, 5, 10, 20, 49, 255, DateTimeKind.Local).AddTicks(428), new DateTime(2023, 12, 5, 10, 20, 49, 255, DateTimeKind.Local).AddTicks(410), "AQAAAAIAAYagAAAAEGjO1ckH2Ub5vpiX8WDB9OSwj/8K9xlSKUQIZVMsydXQt1re7vyO70cB0lb39D+DUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "4ca468bb-2a44-4889-a6d1-36a3a25222ac", new DateTime(2023, 12, 5, 10, 20, 48, 990, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 12, 5, 10, 20, 48, 990, DateTimeKind.Local).AddTicks(1314), "AQAAAAIAAYagAAAAEONj0Yu9QT8hUUqqZlexNJPBkLGjwvMLBkqrXtGFEPf2Hh/HZzS42RBuvBbOJy4ZDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "7ebf8d0d-6d16-4531-b3af-c47f4d6dd0e1", new DateTime(2023, 12, 5, 10, 20, 49, 188, DateTimeKind.Local).AddTicks(7435), new DateTime(2023, 12, 5, 10, 20, 49, 188, DateTimeKind.Local).AddTicks(7385), "AQAAAAIAAYagAAAAEK4gBs4M9Qs0v9qj43ds/gD2Bh/CKjwac+YXuwfGXU/FBUXHsWnobp37wgSgcAn8WQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "89ae8310-62f1-4e71-bb2f-a1eb238612db", new DateTime(2023, 12, 5, 10, 20, 48, 857, DateTimeKind.Local).AddTicks(4614), "AQAAAAIAAYagAAAAEDK1jBcQxRx/hvSZfnG2zyY1ZgXpWuMR1Dmu/OHRLK5tIRUyA1g/ucddVvh1EJKqRg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "6b3d2c97-bc61-487c-bab5-67af75cfe609", new DateTime(2023, 12, 5, 10, 20, 48, 924, DateTimeKind.Local).AddTicks(562), "AQAAAAIAAYagAAAAEGljegRGAX8lnj1kfyfJ49KKObDe39LSBnow5xO7mD5NagwrYnblBPWh+6mPX0grIg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "d2aee56a-edd1-41c1-a154-a42db101d847", new DateTime(2023, 12, 5, 10, 20, 48, 790, DateTimeKind.Local).AddTicks(8543), "AQAAAAIAAYagAAAAEGgDdO7nqGnDaOUd7kN0xPuDrOC4Jb3r7bTHWpooYCSVVyXIU5WWkUkE54UqT/DLZw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6549), new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7653), new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7694), new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7734), new DateTime(2023, 12, 5, 10, 20, 49, 321, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderPartEmployeeOrderId", "OrderPartEmployeePartId", "OrderPartEmployeeUniqueKeyForSerialNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyFo~",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderPartEmployeeOrderId", "OrderPartEmployeePartId", "OrderPartEmployeeUniqueKeyForSerialNumber" },
                principalTable: "OrdersPartsEmployees",
                principalColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
