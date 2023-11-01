using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9090), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9093), false, "first department" });

            migrationBuilder.InsertData(
                table: "PartCategories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ImageUrl", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9459), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9461), "test", false, "first" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9675), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9680), false, "first_test" });

            migrationBuilder.InsertData(
                table: "Supliers",
                columns: new[] { "Id", "Address", "ContactName", "DateCreated", "DateDeleted", "DateUpdated", "Email", "IsDeleted", "Name", "PhoneNumeber", "VATNumber" },
                values: new object[] { 1, "Sofia, center", "Pesh Peshev", new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9737), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9740), "text@test.bg", false, "X Ltd", "1234567890", "123456789" });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9793), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9796), false, "Sofia" });

            migrationBuilder.InsertData(
                table: "VATCategories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "VATPercent" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9853), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9856), false, 20.00m });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateOfHire", "DateOfLeave", "DateUpdated", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "IsManeger", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21003785-a275-4139-ae20-af6a6cf8fea8", 0, "da4a438c-9876-4526-a817-0656a3cb106c", new DateTime(2023, 11, 1, 21, 13, 39, 172, DateTimeKind.Local).AddTicks(4270), new DateTime(2023, 11, 1, 21, 13, 39, 172, DateTimeKind.Local).AddTicks(4209), null, null, 1, "employee@test.bg", false, "Marin", false, false, "Marinov", false, null, "EMPLOYEE@TEST.BG", null, "AQAAAAIAAYagAAAAEMxGR7smgIgurf1QzKxtQ4EUz5jCN12SD+qgqZcGQ+vV5wRCGLQ8AmNEuNrSaD9daQ==", "1234567890", false, "mehanik", "EMPLOYEE@TEST.BG", false, "employee@test.bg" },
                    { "406e8cf1-acaa-44a8-afec-585ff64bed34", 0, "defcafa2-1866-4fe0-8ce4-be968b2ad2d5", new DateTime(2023, 11, 1, 21, 13, 39, 262, DateTimeKind.Local).AddTicks(3009), new DateTime(2023, 11, 1, 21, 13, 39, 262, DateTimeKind.Local).AddTicks(2911), null, null, 1, "manager@test.bg", false, "Kalin", false, true, "Kalinov", false, null, "MANAGER@TEST.BG", null, "AQAAAAIAAYagAAAAEFhnajQacvBwEtS/qqKjLcARPFSrIc/HGwGMjP5e2fiVvg4WJ58URLLWumP9QNyXng==", "1234567890", false, "manager", "MANAGER@TEST.BG", false, "manager@test.bg" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateUpdated", "DelivaryAddress", "Email", "EmailConfirmed", "FirstName", "IBAN", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 0, 1000.00m, "4e9605f1-ab01-49bd-aada-14b86ae17012", new DateTime(2023, 11, 1, 21, 13, 39, 97, DateTimeKind.Local).AddTicks(4952), null, null, "Sofia, Mladost 1, bl 20", "client@test.bg", false, "Ivan", "BG0012345678910111212", false, "Ivanov", false, null, "CLIENT@TEST.BG", null, "AQAAAAIAAYagAAAAEFoL7UL/uxge1nhdbJOzMMx3SNvU4T0ss3I3k+exR27Catlf5/TcXFr3ldhMEQTifA==", "1234567890", false, "CLIENT@TEST.BG", 1, false, "client@test.bg" });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "IsDeleted", "Name", "OEMNumber", "Quantity", "SalePrice", "Unit", "VATCategoryId" },
                values: new object[] { 1, 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9405), null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9407), "test", false, "test", "oemtest", 1.0, 10.00m, "бр", 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ClientId", "DateCreated", "DateUpdated", "Description", "PartId", "Title" },
                values: new object[] { 1, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(8887), new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(8953), "Test Description", 1, "Test Title" });

            migrationBuilder.InsertData(
                table: "Delivaries",
                columns: new[] { "Id", "DateDelivered", "DateUpdated", "Note", "PartId", "QuantityDelivered", "SuplierId" },
                values: new object[] { 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9021), new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9024), "text", 1, 2.0, 1 });

            migrationBuilder.InsertData(
                table: "ImagesParts",
                columns: new[] { "Id", "ImageName", "ImageUrl", "PartId" },
                values: new object[] { 1, "image", "test", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "Description", "Discount", "FinalAmount", "IsDeleted", "PaidAmount", "SaleAmount", "SerialNumber", "StatusId", "UnpaidAmount", "VAT" },
                values: new object[] { 1, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9231), null, null, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9233), "row=1;partId=1;partName=test;partPrice=10.00,priceQty=1$", 0m, 12.00m, false, 0m, 10.00m, "BID12345678", 1, 12.00m, 2.00m });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ClientId", "PartId", "Rating" },
                values: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 1, 5 });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "EmployeeId", "OrderId", "PartId", "DatetimeAsigned", "Description", "EndDatetime", "IsCompleted", "StartDatetime" },
                values: new object[] { "21003785-a275-4139-ae20-af6a6cf8fea8", 1, 1, new DateTime(2023, 11, 1, 21, 13, 39, 372, DateTimeKind.Local).AddTicks(9274), "test", null, false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "EmployeeId", "OrderId", "PartId" },
                keyValues: new object[] { "21003785-a275-4139-ae20-af6a6cf8fea8", 1, 1 });

            migrationBuilder.DeleteData(
                table: "Rates",
                keyColumns: new[] { "ClientId", "PartId" },
                keyValues: new object[] { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
