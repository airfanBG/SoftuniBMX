using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SetPropertyEmailConfirmedToTrue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompatiblePartPart");

            migrationBuilder.CreateTable(
                name: "CompatablePartPart",
                columns: table => new
                {
                    CompatablePartsId = table.Column<int>(type: "int", nullable: false),
                    PartsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatablePartPart", x => new { x.CompatablePartsId, x.PartsId });
                    table.ForeignKey(
                        name: "FK_CompatablePartPart_CompatableParts_CompatablePartsId",
                        column: x => x.CompatablePartsId,
                        principalTable: "CompatableParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompatablePartPart_Parts_PartsId",
                        column: x => x.PartsId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "a3c4cd05-64a5-4014-b87f-612718735456", new DateTime(2023, 12, 12, 11, 19, 52, 741, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 12, 12, 11, 19, 52, 741, DateTimeKind.Local).AddTicks(1679), true, "AQAAAAIAAYagAAAAEA4pf0hx32YCBu7sqBmBKatZ5GH2Tc5qslnywkMG69XN5IrE9mNYm2v6Q6Nr8f5yCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "7d51afc3-6036-4c56-ae38-c8f517dddb57", new DateTime(2023, 12, 12, 11, 19, 52, 676, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 12, 12, 11, 19, 52, 676, DateTimeKind.Local).AddTicks(2968), true, "AQAAAAIAAYagAAAAEDUsscQ70EFBzPCZiTh3dqzu6Tb0OiN/yvmzNe+ByMm+ubRNsXjnzuwFbI0u4aDy6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "db80025e-4df9-48b2-80ed-35350a5b97a0", new DateTime(2023, 12, 12, 11, 19, 52, 871, DateTimeKind.Local).AddTicks(3695), new DateTime(2023, 12, 12, 11, 19, 52, 871, DateTimeKind.Local).AddTicks(3626), true, "AQAAAAIAAYagAAAAEKoteWf5z1ZikrdmVCtd8U4G1g4tGJBqH9gJJ6D/ksICsJ6F+e6mABXsQEMMw3GDpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "b63ed854-55af-466d-9917-55a23dfb3260", new DateTime(2023, 12, 12, 11, 19, 52, 611, DateTimeKind.Local).AddTicks(4633), new DateTime(2023, 12, 12, 11, 19, 52, 611, DateTimeKind.Local).AddTicks(4594), true, "AQAAAAIAAYagAAAAEImIPeNWXfl/efUcQrPZ9emJMoQzrAmqquqWf7wxbtp013542RX77p2WALYfUSnFmA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "1ca10fb2-b68d-439a-b364-c150ffe09a0d", new DateTime(2023, 12, 12, 11, 19, 52, 806, DateTimeKind.Local).AddTicks(759), new DateTime(2023, 12, 12, 11, 19, 52, 806, DateTimeKind.Local).AddTicks(738), true, "AQAAAAIAAYagAAAAEML4NDVXROYOY/y/y7SWDaFQSGUkh1ZZ75XF0yyj5PpMrp2VqncrQAUf4k+uUCy8Qg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "3857625f-89c2-44a0-acbb-a52cf48459db", new DateTime(2023, 12, 12, 11, 19, 52, 480, DateTimeKind.Local).AddTicks(6194), true, "AQAAAAIAAYagAAAAEB+m1cDZ7HwIRPGJI/aerPgWapf7123OWOofWEYqpdpJaqmppNKGCIlhTg5OOrB/DA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "73de7bf7-b052-42a5-8828-5dd1af51b558", new DateTime(2023, 12, 12, 11, 19, 52, 545, DateTimeKind.Local).AddTicks(9414), true, "AQAAAAIAAYagAAAAECD95lxhVu5fJBmasar3TcwH0Vr75U8hLxHWUXBykar205E6QrLGC4J73C/yuEs8zg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "b27d526b-8ef3-4609-9971-c1ce16b29b1a", new DateTime(2023, 12, 12, 11, 19, 52, 414, DateTimeKind.Local).AddTicks(2424), true, "AQAAAAIAAYagAAAAEDgB/uq2DfC80EodeqvQrbG4MC8mKcxV6ZZLdASZ4cwDyZmwGDk1R/bHgRJDufZQrQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1732), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1809), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1818), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1821), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1827), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2732), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2660), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2665), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2670), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2675), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2689), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2692), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2533), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2538), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2587), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2625), new DateTime(2023, 12, 12, 11, 19, 52, 939, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.CreateIndex(
                name: "IX_CompatablePartPart_PartsId",
                table: "CompatablePartPart",
                column: "PartsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompatablePartPart");

            migrationBuilder.CreateTable(
                name: "CompatiblePartPart",
                columns: table => new
                {
                    CompatablePartsId = table.Column<int>(type: "int", nullable: false),
                    PartsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatiblePartPart", x => new { x.CompatablePartsId, x.PartsId });
                    table.ForeignKey(
                        name: "FK_CompatiblePartPart_CompatableParts_CompatablePartsId",
                        column: x => x.CompatablePartsId,
                        principalTable: "CompatableParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompatiblePartPart_Parts_PartsId",
                        column: x => x.PartsId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "89545dcf-33ae-4b29-9bdd-60439a5d3e55", new DateTime(2023, 12, 6, 18, 21, 38, 206, DateTimeKind.Local).AddTicks(7357), new DateTime(2023, 12, 6, 18, 21, 38, 206, DateTimeKind.Local).AddTicks(7327), false, "AQAAAAIAAYagAAAAEIPalvOG8A/FfU0jcw8CHCHqEz8VqdwG8ZbxUzDbVAJ+SgRmrN3NmUuZTV1Eo+y+0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "f4aac8ef-7dbd-4e31-a5bb-164c44635976", new DateTime(2023, 12, 6, 18, 21, 38, 127, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 12, 6, 18, 21, 38, 127, DateTimeKind.Local).AddTicks(9928), false, "AQAAAAIAAYagAAAAEKb7KYnNyvwlyTkbvPKHElimX/O5iyZxoDKml66OdKdVl7K8rWey1kGBWpaEMkiWsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "0bb385f9-57c7-4654-8331-7e111438c6f1", new DateTime(2023, 12, 6, 18, 21, 38, 351, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 12, 6, 18, 21, 38, 351, DateTimeKind.Local).AddTicks(2124), false, "AQAAAAIAAYagAAAAEKhj5+HhvLAcMxceFjEWZQ7CqW87PzLzaOvyMEa2oay5muKAXhOhLDHXInQlwxi3zQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "11490ed6-7822-41e3-9a4c-586c6304f1f5", new DateTime(2023, 12, 6, 18, 21, 38, 46, DateTimeKind.Local).AddTicks(6741), new DateTime(2023, 12, 6, 18, 21, 38, 46, DateTimeKind.Local).AddTicks(6656), false, "AQAAAAIAAYagAAAAED6iS56o+4+CLd1KXML1P3cj10UsuwPQpzEBRHlDWxQLt/Eidny9wn+Qnran54NP6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "a6db2b6e-dae0-499c-a622-a8f8ab120149", new DateTime(2023, 12, 6, 18, 21, 38, 283, DateTimeKind.Local).AddTicks(9886), new DateTime(2023, 12, 6, 18, 21, 38, 283, DateTimeKind.Local).AddTicks(9847), false, "AQAAAAIAAYagAAAAEI+MFjMoF4+G0CIhLmpjZDdDAL5LDyP5tV6RkU08Qn92WpmwVsnwBexvskGNS9CC7A==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "b291706b-992f-4737-9c1e-ab1aa05ff7d5", new DateTime(2023, 12, 6, 18, 21, 37, 886, DateTimeKind.Local).AddTicks(6489), false, "AQAAAAIAAYagAAAAECMl+PLrY5lpWweVmY8wWCbzpBqo8XIAnkYhPDpNnEpVoImddThsCTIdNrf2wlvA9Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "cd6e8127-15ed-40e8-bf1c-2b60ac76ed5a", new DateTime(2023, 12, 6, 18, 21, 37, 968, DateTimeKind.Local).AddTicks(3152), false, "AQAAAAIAAYagAAAAEJ9Tgth/JoZGA8QkKIxfm7x0sEiJb5F+QP8KrP+iMSfPYBOw7narteiADsEDHBHlPg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "EmailConfirmed", "PasswordHash" },
                values: new object[] { "49e83ba8-9755-477f-8d4f-8bef59d87adf", new DateTime(2023, 12, 6, 18, 21, 37, 797, DateTimeKind.Local).AddTicks(4541), false, "AQAAAAIAAYagAAAAEBuLKSybYzVOHH2NSuU5VfHZbXDC1o+N2AV7+4f6i4h+U7CgDdgOBxhYsxrJeOw7cA==" });

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

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6031), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6034), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6037), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6040), new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6041) });

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 6, 18, 21, 38, 412, DateTimeKind.Local).AddTicks(6385));

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

            migrationBuilder.CreateIndex(
                name: "IX_CompatiblePartPart_PartsId",
                table: "CompatiblePartPart",
                column: "PartsId");
        }
    }
}
