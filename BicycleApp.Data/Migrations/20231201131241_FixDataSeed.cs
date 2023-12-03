using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { 3, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "e1edf496-0553-465b-86af-4cfc8005e8a9", new DateTime(2023, 12, 1, 15, 12, 40, 627, DateTimeKind.Local).AddTicks(1878), new DateTime(2023, 12, 1, 15, 12, 40, 627, DateTimeKind.Local).AddTicks(1797), "AQAAAAIAAYagAAAAEOsdZiKfqOX5FrCqrFOzrY0gSDp319RcyqH7f51A2Al1n7qB7XcoQvlGzoKicShrCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "1a7e6a16-0dea-495d-b639-8b8adb5a0b24", new DateTime(2023, 12, 1, 15, 12, 40, 547, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 12, 1, 15, 12, 40, 547, DateTimeKind.Local).AddTicks(188), "AQAAAAIAAYagAAAAEJhctJlvAGj2PF1KsJtr5XhCzNmdjjkduJxyzMab6WTCU0qhFNQRAwJ14p0o1tNjkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "b0e6c335-81f0-41b1-9808-b19f4a647392", new DateTime(2023, 12, 1, 15, 12, 40, 803, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 12, 1, 15, 12, 40, 803, DateTimeKind.Local).AddTicks(6147), "AQAAAAIAAYagAAAAENYaeOi/iNhu8uS5rErieiS4RqbmzmmxrIN74ijdqCeovpOA0MoFo/UwSxHVHqAD+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "de09bcf5-bde7-4ecd-83a6-0e59698a6e71", new DateTime(2023, 12, 1, 15, 12, 40, 468, DateTimeKind.Local).AddTicks(4543), new DateTime(2023, 12, 1, 15, 12, 40, 468, DateTimeKind.Local).AddTicks(4493), "AQAAAAIAAYagAAAAEMx4GL1MQ/fiJeBtR65rgfN/RkaWMPJRiWaH89cLuFts1e+Eq1OJHqyo4OJfnDUhXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "157d3763-adce-4a69-a9ca-66757522e2f9", new DateTime(2023, 12, 1, 15, 12, 40, 710, DateTimeKind.Local).AddTicks(3863), new DateTime(2023, 12, 1, 15, 12, 40, 710, DateTimeKind.Local).AddTicks(3825), "AQAAAAIAAYagAAAAEB5pYzUP3shyQdFf0iMxC76QvgggbvUra/zVZzvGzivebjlmmW2tEQ1S1a8ueaxOcw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "724f583a-77a9-41b4-b81b-cabb3dba5743", new DateTime(2023, 12, 1, 15, 12, 40, 316, DateTimeKind.Local).AddTicks(172), "AQAAAAIAAYagAAAAEAXI/Ao2u5+bzdjhkdi940XWLLR/X1ibHP3onQ0qQe+n9YHbHZtB1xnP1pKFDbtwRA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "7eb0b339-117e-4ebb-9d07-661627b2fb07", new DateTime(2023, 12, 1, 15, 12, 40, 391, DateTimeKind.Local).AddTicks(4640), "AQAAAAIAAYagAAAAEN8jhn+iVAfSEHahxSxQbHypZlxryseZwu0hZK7HKoEaBCdmdtlx5j+j0CdS6kElvw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "ef250bf1-9274-4c29-9e48-355092fcccd5", new DateTime(2023, 12, 1, 15, 12, 40, 235, DateTimeKind.Local).AddTicks(1394), "AQAAAAIAAYagAAAAECg0Q5iSWDVxqAHwK+Z14BT/ZM1I5Hj1e29oFRwGqff8sDHfzaPNGdAi0VdYfU+ALA==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6288), new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6454), new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                columns: new[] { "DatetimeAsigned", "PartName", "PartPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6988), "Frame OG", 100.00m });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber", "DatetimeAsigned", "Description", "EmployeeId", "EndDatetime", "IsCompleted", "PartName", "PartPrice", "PartQuantity", "SerialNumber", "StartDatetime" },
                values: new object[,]
                {
                    { 2, 4, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "17063948-8fdc-417e-8fb7-2ae6bf572f94", null, false, "Wheel of the Year for road", 75.00m, 2.0, "BID12345679", null },
                    { 2, 12, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", null, false, "Shift", 220.00m, 2.0, "BID12345679", null },
                    { 3, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Wheel of the Year for montain", 85.00m, 6.0, "BID12345680", null },
                    { 3, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Road budget Shifts", 290.00m, 4.0, "BID12345680", null }
                });

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8104), new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8196), new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(8199) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 4, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 12, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 3, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" });

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 30, 17, 19, 16, 7, DateTimeKind.Local).AddTicks(1115));

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
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                columns: new[] { "DatetimeAsigned", "PartName", "PartPrice" },
                values: new object[] { null, "Frame OG2", 110.00m });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber", "DatetimeAsigned", "Description", "EmployeeId", "EndDatetime", "IsCompleted", "PartName", "PartPrice", "PartQuantity", "SerialNumber", "StartDatetime" },
                values: new object[,]
                {
                    { 2, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "17063948-8fdc-417e-8fb7-2ae6bf572f94", null, false, "Wheel of the YearG2", 65.00m, 2.0, "BID12345679", null },
                    { 2, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", null, false, "Shift2", 220.00m, 2.0, "BID12345679", null },
                    { 3, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Wheel of the YearGT", 85.00m, 6.0, "BID12345680", null },
                    { 3, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", null, "test", null, null, false, "Shift3", 290.00m, 4.0, "BID12345680", null }
                });

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
        }
    }
}
