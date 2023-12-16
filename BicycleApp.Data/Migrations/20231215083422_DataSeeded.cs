using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fcadfe7a-6af1-4930-9bf1-fd48654e479b", new DateTime(2023, 12, 15, 10, 34, 22, 139, DateTimeKind.Local).AddTicks(5457), new DateTime(2023, 12, 15, 10, 34, 22, 139, DateTimeKind.Local).AddTicks(5440), "AQAAAAIAAYagAAAAEJQKDbZcTmELBNGmVsCX2HQvuLm/1HBKM1Y/AYUl9Xrh7D3qhyKB/erKVQmXvj6J8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "759e483a-1ec8-47eb-a2fc-361f5724cbb5", new DateTime(2023, 12, 15, 10, 34, 21, 882, DateTimeKind.Local).AddTicks(9599), "AQAAAAIAAYagAAAAEN4NB/h2D4s/9MSwue3nTYP6yoGumub/ISZ6BvKb84O0u/+Zks4+lYo1UoxU13O92A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f9f4f697-ed5d-4358-a09d-231e5960a9ce", new DateTime(2023, 12, 15, 10, 34, 22, 77, DateTimeKind.Local).AddTicks(628), new DateTime(2023, 12, 15, 10, 34, 22, 77, DateTimeKind.Local).AddTicks(617), "AQAAAAIAAYagAAAAEALcxVUq1qFJj/IeE2fCpWjZUMzfMYyOYzo+ZD+zzVqSBTZuDSU8rTCbBxRnQ6T6Yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "49acc124-af38-49e6-ba00-eeed3fb9a480", new DateTime(2023, 12, 15, 10, 34, 22, 264, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 12, 15, 10, 34, 22, 264, DateTimeKind.Local).AddTicks(9598), "AQAAAAIAAYagAAAAEBZUd1LX+mQ1FVJzUqCzmvGf40mh18s0RZ98DniPgOYu2XQic3IqLH03oNzMCTAFFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f09bfc70-d35e-404e-8cb1-3a5f7cc0aed0", new DateTime(2023, 12, 15, 10, 34, 22, 15, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 12, 15, 10, 34, 22, 15, DateTimeKind.Local).AddTicks(1963), "AQAAAAIAAYagAAAAEO3BBpjcG5DdxP2qAV0mWnSagfayFFJy06P6zKOCeIxsG68w/VgYlmUXY6b7DznONg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "ea02869c-cffe-4bb8-9c70-31a48904f040", new DateTime(2023, 12, 15, 10, 34, 22, 202, DateTimeKind.Local).AddTicks(736), new DateTime(2023, 12, 15, 10, 34, 22, 202, DateTimeKind.Local).AddTicks(664), "AQAAAAIAAYagAAAAEJ+Yiz4HP+jlA/Z8l2ZijKMMaQ2vEonkjPp7QrzI/q6E4PLKkWM9pBIKORWmZ/tgcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "174424bd-6678-4b57-9182-1d56ead11b1c", new DateTime(2023, 12, 15, 10, 34, 21, 952, DateTimeKind.Local).AddTicks(93), "AQAAAAIAAYagAAAAEMGjyrd+gr7HnkUlvE2+2lfg5w4uTg/dEK4ybT1XPwQtm9Xg/ADSVGLsu6qsQpzbSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "2ceea2d9-4ac6-4525-bb82-2e7e7f5a65b3", new DateTime(2023, 12, 15, 10, 34, 21, 811, DateTimeKind.Local).AddTicks(3165), "AQAAAAIAAYagAAAAEBk2qg1+IrLoBaLNQkFk1WeV+PcgoknxEy3bv6QnNHKJqZ5RMYuwtchrGbf6K65Q0A==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 327, DateTimeKind.Local).AddTicks(9832), new DateTime(2023, 12, 15, 10, 34, 22, 327, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(60), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(65), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(69), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(73), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(77), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(94), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2224), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2231), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1149), 32.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1162), 43.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1168), 32.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1210), 29.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1238), 29.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2097), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2105), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2109), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2121), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2125), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2130), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1918), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 12, 15, 10, 34, 22, 328, DateTimeKind.Local).AddTicks(2003) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fbac9cff-afc2-437d-b3fd-d121d217a693", new DateTime(2023, 12, 13, 20, 40, 31, 775, DateTimeKind.Local).AddTicks(9287), new DateTime(2023, 12, 13, 20, 40, 31, 775, DateTimeKind.Local).AddTicks(9261), "AQAAAAIAAYagAAAAEMOGQR1ReMEkj5RN3msYz4S7nTDVZAwy0bCOc9TnyP9lKpOIhMw5ooxBeCZB6ViAOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "01ad3e46-f0b6-4ec3-a97f-5e02fb195b3e", new DateTime(2023, 12, 13, 20, 40, 31, 510, DateTimeKind.Local).AddTicks(8070), "AQAAAAIAAYagAAAAEMLrJw2t3fbHvwBsO7YODzR9I3zPkXkWBsbEkFz+Zg3rEnlTrUAn9n+NkmNRjU8HJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fe190462-a544-444d-8e11-da799fe95215", new DateTime(2023, 12, 13, 20, 40, 31, 709, DateTimeKind.Local).AddTicks(5533), new DateTime(2023, 12, 13, 20, 40, 31, 709, DateTimeKind.Local).AddTicks(5513), "AQAAAAIAAYagAAAAEAsfEasf1jxn0ZAR32nfr9SnGpNAOWs/cVvJGe4UCitoGqcANQvyS4qVcyuPRF8WIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "3ec93885-124a-4f49-9b6d-0eaf71bddfbe", new DateTime(2023, 12, 13, 20, 40, 31, 908, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 12, 13, 20, 40, 31, 908, DateTimeKind.Local).AddTicks(4776), "AQAAAAIAAYagAAAAEF+Jft+ZSbWLofYjkA+hxSWEB+WAKrdbHz9SMr3IlRAt1oRZxstpB3aDvR2z4uNC2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "c1234c44-4afe-4218-9a8f-767bed6b7329", new DateTime(2023, 12, 13, 20, 40, 31, 643, DateTimeKind.Local).AddTicks(5407), new DateTime(2023, 12, 13, 20, 40, 31, 643, DateTimeKind.Local).AddTicks(5336), "AQAAAAIAAYagAAAAEKMgCHPOKVCrj4s1OkO+lYJRmoVOMnJ6WAm9KydZOVz6MTPok4ZLBZndQ84T1Yl0fA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "fade5236-3198-4cad-8107-406321072c5a", new DateTime(2023, 12, 13, 20, 40, 31, 842, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 12, 13, 20, 40, 31, 842, DateTimeKind.Local).AddTicks(1787), "AQAAAAIAAYagAAAAEKE+qjjOi4vchaqhdrACMXVSGu5zI4llZ88dSm+/6SVPLqn7SuNGTgx0Aq+kevuLNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "9533c2ea-9a6e-4814-af28-7ec17d94d174", new DateTime(2023, 12, 13, 20, 40, 31, 577, DateTimeKind.Local).AddTicks(575), "AQAAAAIAAYagAAAAECUExORZzhWz/ihHYXkVi3RIpHmu3plCNhpQ7UOaOXYMAxHVEyM7gg7fGOe3WBDMsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "f5e033c5-8269-4eb7-a478-c82f8c28ddd0", new DateTime(2023, 12, 13, 20, 40, 31, 443, DateTimeKind.Local).AddTicks(9), "AQAAAAIAAYagAAAAEAhAP9g6aR30fL9TBmt2dNXVxLc/+UQG7K6LZrXS0pgn3ddLaVgZnvtlBnyIZ7bndg==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7882), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7971), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7973), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7979), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7982), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7985), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8012), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9064), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9071), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8566), 2.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8576), 4.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8579), 3.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8593), 9.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Quantity" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8610), 9.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8983), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8987), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8990), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8993), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8996), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9001), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9004), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9006), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9009), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9020), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9022), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8854), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8899), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8937), new DateTime(2023, 12, 13, 20, 40, 31, 974, DateTimeKind.Local).AddTicks(8938) });
        }
    }
}
