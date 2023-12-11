using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderPartModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompatiblePartPart");

            migrationBuilder.RenameColumn(
                name: "QuantityDelivered",
                table: "PartOrders",
                newName: "Quantity");

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
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "6cb93501-9852-4e6a-8c24-f311d86c8e07", new DateTime(2023, 12, 9, 12, 32, 12, 858, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 12, 9, 12, 32, 12, 858, DateTimeKind.Local).AddTicks(8568), "AQAAAAIAAYagAAAAECBwFX0f7vbsZrlsFv6g4s4sEhu6Olr+kMF4hfZa0dk5n697KDpbW3iOkhhiPlS6pg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "c3e50c6c-4b90-47e6-b152-b0d7bc4a3328", new DateTime(2023, 12, 9, 12, 32, 12, 790, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 12, 9, 12, 32, 12, 790, DateTimeKind.Local).AddTicks(7638), "AQAAAAIAAYagAAAAEKAoRaDv3JX60FhoUfUpuEoAx4EIjqjomnj35/mO12fS8zCVBoPcg4WmRiyeqxvZKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f9bdf2b0-f28b-43db-b592-fd1dd7475b6e", new DateTime(2023, 12, 9, 12, 32, 12, 994, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 12, 9, 12, 32, 12, 994, DateTimeKind.Local).AddTicks(5569), "AQAAAAIAAYagAAAAEFF1BL71QzMKKLBNcS9Kjok9s15OGrUuRGGJ9HBKG6IEgA9OvG4e3u2VM/6QyvzLyg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "df6d4a60-c253-4aaf-af85-ffe534d4e612", new DateTime(2023, 12, 9, 12, 32, 12, 727, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 12, 9, 12, 32, 12, 727, DateTimeKind.Local).AddTicks(9641), "AQAAAAIAAYagAAAAEGBdIm/8YRbjn14QEBsKGbt1Bf0y6/nw7ubK/yGzETKNWZ8TAfwvBBUoxGcUV4NwTg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f9e4e923-c436-45dc-bf4a-1ea413da6f29", new DateTime(2023, 12, 9, 12, 32, 12, 930, DateTimeKind.Local).AddTicks(5318), new DateTime(2023, 12, 9, 12, 32, 12, 930, DateTimeKind.Local).AddTicks(5242), "AQAAAAIAAYagAAAAEHmJ8IBKzcwfrj+Wfz4gxea2mdkSAEL4d5P4CzXHux5VAeR9u4pVgLuzMe9KcG1kdA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "453a7acc-a718-4f9c-864a-830e03f9dda6", new DateTime(2023, 12, 9, 12, 32, 12, 597, DateTimeKind.Local).AddTicks(7781), "AQAAAAIAAYagAAAAEMlIHCQZ8Fo1DDwnxsap1b6afensmtOLiLHv1R/jjJHR6cvVRFeiBueJaxOaUWfg7Q==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "31d290f6-bdff-429f-a64b-e99e53ae765b", new DateTime(2023, 12, 9, 12, 32, 12, 662, DateTimeKind.Local).AddTicks(5928), "AQAAAAIAAYagAAAAEJocpz9apcHKYJIpxoACwZpV82qjqSKDBgpUUDpln1oy3xWsIpjaQmUWyJv+zLD0bg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "1a132e0c-2510-4183-b708-0de7ce24638d", new DateTime(2023, 12, 9, 12, 32, 12, 535, DateTimeKind.Local).AddTicks(958), "AQAAAAIAAYagAAAAEPXIZPkaXrxGBRDMes5TnMsDi6EZ9AEXFQJWyQdiEITYexcxvpqaiovCO4ugmesPBw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9413), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9521), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9524), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9527), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9530), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9533), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9538), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9541), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9543), new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 59, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(562), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(566), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "PartOrders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(569), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(484), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(488), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(491), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(494), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(497), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(499), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(502), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(505), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(510), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(513), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "PartsInStock",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(522), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(415), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(456), new DateTime(2023, 12, 9, 12, 32, 13, 60, DateTimeKind.Local).AddTicks(457) });

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

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "PartOrders",
                newName: "QuantityDelivered");

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
