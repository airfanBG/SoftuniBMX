using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPropInPartEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Type of the part");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "9d85d0a9-216b-494f-8869-40393e5fb40a", new DateTime(2023, 11, 20, 10, 43, 45, 885, DateTimeKind.Local).AddTicks(1477), new DateTime(2023, 11, 20, 10, 43, 45, 885, DateTimeKind.Local).AddTicks(1444), "AQAAAAIAAYagAAAAELQgS7xc5PzLKLAUiY/XcVVjUFZBMqGKpY7PnixDLbRZ+BXQSeT3qhDXuU9TFkJMWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fe47a99c-ac8e-41ac-956b-fc0e9e10d59b", new DateTime(2023, 11, 20, 10, 43, 45, 821, DateTimeKind.Local).AddTicks(1874), new DateTime(2023, 11, 20, 10, 43, 45, 821, DateTimeKind.Local).AddTicks(1851), "AQAAAAIAAYagAAAAEGET9siCvTVPBmo146zCE+EBDxclSIJsvlhCmrFVqoCJ3y8xduh1MenL45qNp+T6eQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "bd445f33-a866-4bf7-988e-26fa212efb57", new DateTime(2023, 11, 20, 10, 43, 46, 16, DateTimeKind.Local).AddTicks(91), new DateTime(2023, 11, 20, 10, 43, 46, 16, DateTimeKind.Local).AddTicks(62), "AQAAAAIAAYagAAAAENjN+6JYcmm6yvldL/f3uFO2YZerWlIzg4vJapwXl+NC94YvUZLgVfR+4lzDUeQPCw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "9b6e0a33-944b-4df3-a08f-a95bc878d890", new DateTime(2023, 11, 20, 10, 43, 45, 757, DateTimeKind.Local).AddTicks(9415), new DateTime(2023, 11, 20, 10, 43, 45, 757, DateTimeKind.Local).AddTicks(9375), "AQAAAAIAAYagAAAAEKnDBXZRKTea90UDq2JPY6x7x74WKKYaw/w0l9eeTjubxWiCvloOpUC+8Vt16pwdiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "bedf6163-cd10-41c9-974e-536b0dff91b2", new DateTime(2023, 11, 20, 10, 43, 45, 951, DateTimeKind.Local).AddTicks(492), new DateTime(2023, 11, 20, 10, 43, 45, 951, DateTimeKind.Local).AddTicks(460), "AQAAAAIAAYagAAAAEBCOQsmwBDOk7lrsiER31xKdEMZuDayJG/0h8Fxt8JSm9n/Obm+R2beWvINM5+rp9g==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "d5c89559-8fe1-47b7-b7ed-e93816a7eec2", new DateTime(2023, 11, 20, 10, 43, 45, 622, DateTimeKind.Local).AddTicks(8875), "AQAAAAIAAYagAAAAEHuiEvviqFbMjiDseNIhT0UmRm9P1bYZo5gtoVuzcHP75QWbmEeukoymRLIKCMPBiw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "a0d1ab9d-3800-4efb-938d-8d26357b60a2", new DateTime(2023, 11, 20, 10, 43, 45, 687, DateTimeKind.Local).AddTicks(5360), "AQAAAAIAAYagAAAAEA2wM9sLviMETLXWgGPWERKsRrgqKLdjL43cw6TvovfMUIpnsB3u/zROURsJsVx3zw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "b9ad55e9-1e98-4b86-8c96-3bea4de8914a", new DateTime(2023, 11, 20, 10, 43, 45, 555, DateTimeKind.Local).AddTicks(3747), "AQAAAAIAAYagAAAAEId4a3gKNmD5N5dEbOM+VbjyIiB/8uW/PUiddmM6Wm6kv0Pg1VVsO1auPeH+DCOXxQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8173), new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8725), 1 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8755), 2 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Type" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8761), 3 });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9070), new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9130), new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(9200) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "dc14565d-a9a2-47cb-b6f5-d6176f887727", new DateTime(2023, 11, 18, 14, 44, 31, 623, DateTimeKind.Local).AddTicks(2932), new DateTime(2023, 11, 18, 14, 44, 31, 623, DateTimeKind.Local).AddTicks(2903), "AQAAAAIAAYagAAAAEGjPWbdJViEg4E8e9Hx0Yrw8BVkCfJegLkA2vkPiDNmgpOQ+EQLjC58/z9X9p62aSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "89bf5703-800c-48ba-bcb2-3fbfe75e3fea", new DateTime(2023, 11, 18, 14, 44, 31, 496, DateTimeKind.Local).AddTicks(8140), new DateTime(2023, 11, 18, 14, 44, 31, 496, DateTimeKind.Local).AddTicks(8052), "AQAAAAIAAYagAAAAENKd0NeNi3tP7jr5bCYfzK6liqw5WJ5jHLoGlWm5HSbsHq5oESk6mB4C5eOSpPBYkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "036790e6-f909-421a-ad1f-8b99a794b88c", new DateTime(2023, 11, 18, 14, 44, 31, 812, DateTimeKind.Local).AddTicks(7694), new DateTime(2023, 11, 18, 14, 44, 31, 812, DateTimeKind.Local).AddTicks(7668), "AQAAAAIAAYagAAAAEGTC4duCU2qYVOuJqJuy2JUL6RTY2V5NZZhPldvN3haXSGnlve/QnqRlLopvm7Q5Ew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "8adf0a83-3ee2-4aae-8a7c-28283c464b3a", new DateTime(2023, 11, 18, 14, 44, 31, 411, DateTimeKind.Local).AddTicks(240), new DateTime(2023, 11, 18, 14, 44, 31, 411, DateTimeKind.Local).AddTicks(142), "AQAAAAIAAYagAAAAEIYAR/pdmBpW7LkBBdhOPNCKauUMjWMoLHqILOrBh2wd20+tI6z7rARF2O8vfW1QRg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "89fc96f4-1adb-42ad-b158-236bb446e31d", new DateTime(2023, 11, 18, 14, 44, 31, 716, DateTimeKind.Local).AddTicks(9956), new DateTime(2023, 11, 18, 14, 44, 31, 716, DateTimeKind.Local).AddTicks(9923), "AQAAAAIAAYagAAAAEAcoDRsw0A7WNHEBl70Oar3tJuwpyrwMVy2Z/cZeMGT0alXZyRxNTDqP1Hjq4mJeVQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "7f590e59-19de-4c44-a5c5-7279ab8ae481", new DateTime(2023, 11, 18, 14, 44, 31, 228, DateTimeKind.Local).AddTicks(7889), "AQAAAAIAAYagAAAAECf+VwDpRCMMZpQFI/bVWWJpLP+Xz97iEA6C2NSOUyXP4tTl09UOrgzAElMVIOfSAA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "d4685364-4cc0-4392-bbc3-ddd967555f7c", new DateTime(2023, 11, 18, 14, 44, 31, 313, DateTimeKind.Local).AddTicks(5352), "AQAAAAIAAYagAAAAEK8L0aHsxhOsFFX+juPSFQgGviUPAuS6aVvvJniD8fO/RuWtiN5HhXybL6tGAq577A==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "cd2ace25-975e-4cce-ad9a-8dd778e115f7", new DateTime(2023, 11, 18, 14, 44, 31, 131, DateTimeKind.Local).AddTicks(6634), "AQAAAAIAAYagAAAAEKPTUcRtXZgXcYEeAkVXbWczKeUB1fkAWd6kZFzshVastTq3/E14/bFMFJGR3C8n3A==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7146), new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(8033), new DateTime(2023, 11, 18, 14, 44, 31, 908, DateTimeKind.Local).AddTicks(8035) });
        }
    }
}
