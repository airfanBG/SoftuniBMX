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
                name: "FK_OrderPartEmployeeInfo_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSer~",
                table: "OrderPartEmployeeInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPartEmployeeInfo",
                table: "OrderPartEmployeeInfo");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderPartEmployeeInfo");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "OrderPartEmployeeInfo");

            migrationBuilder.RenameTable(
                name: "OrderPartEmployeeInfo",
                newName: "OrdersPartsEmployeesInfos");

            migrationBuilder.RenameIndex(
                name: "IX_OrderPartEmployeeInfo_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                newName: "IX_OrdersPartsEmployeesInfos_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersPartsEmployeesInfos",
                table: "OrdersPartsEmployeesInfos",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyFo~",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderPartEmployeeOrderId", "OrderPartEmployeePartId", "OrderPartEmployeeUniqueKeyForSerialNumber" },
                principalTable: "OrdersPartsEmployees",
                principalColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyFo~",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersPartsEmployeesInfos",
                table: "OrdersPartsEmployeesInfos");

            migrationBuilder.RenameTable(
                name: "OrdersPartsEmployeesInfos",
                newName: "OrderPartEmployeeInfo");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber",
                table: "OrderPartEmployeeInfo",
                newName: "IX_OrderPartEmployeeInfo_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSerialNumber");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderPartEmployeeInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Id of the order from the client");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "OrderPartEmployeeInfo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Id of the part from the order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPartEmployeeInfo",
                table: "OrderPartEmployeeInfo",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "51c8d4cf-fc72-4e2a-9331-aaf592c1dd65", new DateTime(2023, 12, 5, 9, 36, 35, 181, DateTimeKind.Local).AddTicks(4706), new DateTime(2023, 12, 5, 9, 36, 35, 181, DateTimeKind.Local).AddTicks(4687), "AQAAAAIAAYagAAAAELfZ3MXUjaf0b6rHPKr4UqVJMcT2ubROhF+8NWAo6cm8qNLUUXu4vuAh5+p7i23DXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "1673b321-5fe8-437f-8b46-091e145b235a", new DateTime(2023, 12, 5, 9, 36, 35, 115, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 12, 5, 9, 36, 35, 115, DateTimeKind.Local).AddTicks(5579), "AQAAAAIAAYagAAAAEBh6Q6Znwcv06KD6aQdOHiLjEJE0ybv4j9F8krHNe9d8bZf/coYJYeSIsE/mjHAn7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fb54f750-f52b-4d6f-a5b5-2b0933590728", new DateTime(2023, 12, 5, 9, 36, 35, 314, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 12, 5, 9, 36, 35, 314, DateTimeKind.Local).AddTicks(2215), "AQAAAAIAAYagAAAAEHieebae3xYblGX6IwARYomDizESYSN6H96X19wN2G7WyD/iP+uC47jXmGN95CwbdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "48cab80a-2533-4ff1-bd7d-5b70b8630bd3", new DateTime(2023, 12, 5, 9, 36, 35, 49, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 12, 5, 9, 36, 35, 49, DateTimeKind.Local).AddTicks(1206), "AQAAAAIAAYagAAAAEJIgorF40cQ9kFWN7OnkmRWb6CqtOg8njIP6T2F0SWp32QWLXUvDEFoEF5XsoTiEUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "b6a96c64-7c8b-43fe-8ff3-5f1267096937", new DateTime(2023, 12, 5, 9, 36, 35, 247, DateTimeKind.Local).AddTicks(7035), new DateTime(2023, 12, 5, 9, 36, 35, 247, DateTimeKind.Local).AddTicks(6981), "AQAAAAIAAYagAAAAEJNgtAEU7aeMrsTc5YwON0HttYeGI2sc02YTFp0H5A4Ydqv1tOflpEzJbqgg4BwyUA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "5f833fc6-997f-439f-a63c-baafe216c94f", new DateTime(2023, 12, 5, 9, 36, 34, 913, DateTimeKind.Local).AddTicks(7614), "AQAAAAIAAYagAAAAEJAXN9Yc8i8sKmgJS0+tchxcLnxDbsZAdJmJnJepIJKsl0YcY/Af+4/l5tImFFye5Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "e7c767d1-8be1-4943-8a96-155399f18038", new DateTime(2023, 12, 5, 9, 36, 34, 982, DateTimeKind.Local).AddTicks(3181), "AQAAAAIAAYagAAAAEKPNVPCUqpZ+qzsU5/FTAWVKzbi0UNoZOykITsrQ0yY4DthMeA7RkRQOZWT50HPfjw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "73986fa1-2ac1-4658-90c7-d13d6d650336", new DateTime(2023, 12, 5, 9, 36, 34, 847, DateTimeKind.Local).AddTicks(5986), "AQAAAAIAAYagAAAAEFqmmjlaOFr2PPsipK0aasWhFTBG+AmUUkGAkSXeIu9Xb9m9mCvTWjkbE/s2K6A+Yw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8082), new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8168), new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9227), new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9350), new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9391), new DateTime(2023, 12, 5, 9, 36, 35, 380, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPartEmployeeInfo_OrdersPartsEmployees_OrderPartEmployeeOrderId_OrderPartEmployeePartId_OrderPartEmployeeUniqueKeyForSer~",
                table: "OrderPartEmployeeInfo",
                columns: new[] { "OrderPartEmployeeOrderId", "OrderPartEmployeePartId", "OrderPartEmployeeUniqueKeyForSerialNumber" },
                principalTable: "OrdersPartsEmployees",
                principalColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
