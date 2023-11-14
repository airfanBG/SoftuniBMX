using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "742f02c6-c0d5-4346-8832-047bdf9c8492", new DateTime(2023, 11, 13, 11, 24, 30, 806, DateTimeKind.Local).AddTicks(435), new DateTime(2023, 11, 13, 11, 24, 30, 806, DateTimeKind.Local).AddTicks(391), "AQAAAAIAAYagAAAAEE87VCPGSxYmOT6UjcgZCvHABJbogFd3nRq2I23a+LIw99Oy54jyhCMXtjINV1n/Iw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "83dc8fb2-497a-4a6d-bfea-87b13dcb0f8f", new DateTime(2023, 11, 13, 11, 24, 30, 676, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 11, 13, 11, 24, 30, 676, DateTimeKind.Local).AddTicks(2295), "AQAAAAIAAYagAAAAEIjCLnxkMaasjDppKf+V1pd50LYRLApBTYry6+PXtxtd2dxDhKlKsfDsn4EzQ2eEcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f81d6e52-faf4-4aae-8af2-c2d5cd18493f", new DateTime(2023, 11, 13, 11, 24, 30, 741, DateTimeKind.Local).AddTicks(1190), new DateTime(2023, 11, 13, 11, 24, 30, 741, DateTimeKind.Local).AddTicks(1151), "AQAAAAIAAYagAAAAEH/Qz0rCBmjKCcuT1cW1IacsgBUiN45RsOmFpJ8UVKlet8FhEg2UazEZrKasdzaZDQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "11f04e33-adea-4054-8a0c-dbef86762b2e", new DateTime(2023, 11, 13, 11, 24, 30, 546, DateTimeKind.Local).AddTicks(4937), "AQAAAAIAAYagAAAAELq0TuqfVjJSM0Vsj1pqNcRJap+Wi3F7Xxg1Er1YwdpA2oBrU/lwwvI+wi+mw3REaA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "120ddcb5-ac1c-40f9-82a4-871278ebc45b", new DateTime(2023, 11, 13, 11, 24, 30, 611, DateTimeKind.Local).AddTicks(5867), "AQAAAAIAAYagAAAAEEYbt1vHFaJPoYyeNn745lMyFtXA9M2lD0Pt7jH32LRRq4eB6yIqjmMdcIgs6suIhg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "bd2e7ab8-c50d-4cfe-843d-c07b2e56fdad", new DateTime(2023, 11, 13, 11, 24, 30, 481, DateTimeKind.Local).AddTicks(7406), "AQAAAAIAAYagAAAAEEPp/F00VYKjqepQE9/CgvOTDEDNNj9Wu+1x2jBk5VvrDMBcifbtIM7sNeYZc7ILVg==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8436), new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "EmployeeId", "OrderId", "PartId" },
                keyValues: new object[] { "21003785-a275-4139-ae20-af6a6cf8fea8", 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 870, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(733), "Pending approval" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(738), "Approved order" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(748), "Frame management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(750), "Wheel management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(753), "Shift management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(764), "Quality control" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[] { 7, new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(767), null, null, false, "Send order" });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1194), new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 11, 13, 11, 24, 30, 871, DateTimeKind.Local).AddTicks(1531) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f01a3d53-6a0e-43e5-af0d-a9b93fe05512", new DateTime(2023, 11, 9, 14, 21, 49, 113, DateTimeKind.Local).AddTicks(4590), new DateTime(2023, 11, 9, 14, 21, 49, 113, DateTimeKind.Local).AddTicks(4555), "AQAAAAIAAYagAAAAENPQfbsq9PgoqdzEA2YGyuD1ULV2RKPTn0QuwkVgawY+h+8NwH10boR2P1th00L4ng==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fb716385-7816-4623-a75c-b9ef42791abc", new DateTime(2023, 11, 9, 14, 21, 48, 981, DateTimeKind.Local).AddTicks(2442), new DateTime(2023, 11, 9, 14, 21, 48, 981, DateTimeKind.Local).AddTicks(2408), "AQAAAAIAAYagAAAAEB36HSwYOFpxi11IACjHLA3eeeV7kq3lwB0ANnWmDjuTlPqd3bfgP+ZsVGgxKnITLA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "2dd314e3-1a13-4016-b10a-16b2863f9e6b", new DateTime(2023, 11, 9, 14, 21, 49, 47, DateTimeKind.Local).AddTicks(3289), new DateTime(2023, 11, 9, 14, 21, 49, 47, DateTimeKind.Local).AddTicks(3250), "AQAAAAIAAYagAAAAEIto+wKWPwypAM4mxPNEKzylZwkjbgiP7A+ya/cUIs4gxnNPlHz6sBRprCDRs9agtQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "6c81b25b-c6fb-4455-92d3-9661d25b6bc0", new DateTime(2023, 11, 9, 14, 21, 48, 848, DateTimeKind.Local).AddTicks(3672), "AQAAAAIAAYagAAAAEMtJmAfpU2Z8NLTklZeTbYJes8inogK62BUjxzGcznCaneJ/7exAusC/A0uSGk9Ytg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "cced88ba-2da9-4761-a642-b6e8515eb47a", new DateTime(2023, 11, 9, 14, 21, 48, 914, DateTimeKind.Local).AddTicks(7238), "AQAAAAIAAYagAAAAELXfjqadLLMxaz2pDxSxqFRRakOPKDju8ML86lI09/JhftAswRpmxkwM8IrFcTVQug==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "416fe525-e612-4242-990d-96fc4e6a9203", new DateTime(2023, 11, 9, 14, 21, 48, 782, DateTimeKind.Local).AddTicks(2531), "AQAAAAIAAYagAAAAEJKbQOWNkS9mIUIH/0647TPZA8YBg2GXV+ZprblO+hoXCTyO5j61uRCht2UF5tMpjQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6137), new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6238), new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "EmployeeId", "OrderId", "PartId" },
                keyValues: new object[] { "21003785-a275-4139-ae20-af6a6cf8fea8", 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6710), "Order approval" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6721), "Frame management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6724), "Wheel management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6726), "Shift management" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6728), "Quality control" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6737), "Send order" });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6849), new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(7151), new DateTime(2023, 11, 9, 14, 21, 49, 179, DateTimeKind.Local).AddTicks(7166) });
        }
    }
}
