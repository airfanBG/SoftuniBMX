using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class PartEntitymodifiedCompatiblePartAddedAndPartsSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Parts");

            migrationBuilder.CreateTable(
                name: "CompatableParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false, comment: "The name of the compatible part"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "Type of the part")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompatableParts", x => x.Id);
                });

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
                values: new object[] { "57096d2c-9b8b-4eb7-a51f-deaf74204b89", new DateTime(2023, 11, 27, 15, 18, 25, 166, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 11, 27, 15, 18, 25, 166, DateTimeKind.Local).AddTicks(3034), "AQAAAAIAAYagAAAAENjax/w7J9FdqjGvC8amUvj4XAw4AgZaeOrUEoVe1aJ7deO8gl3bViTicpP073bwvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "51688af4-6ab8-4003-8861-cfe3b8474f70", new DateTime(2023, 11, 27, 15, 18, 25, 103, DateTimeKind.Local).AddTicks(9453), new DateTime(2023, 11, 27, 15, 18, 25, 103, DateTimeKind.Local).AddTicks(9438), "AQAAAAIAAYagAAAAEDwV8dt0cZT/M4HT7hiiUxcIeldeiyoRklrohw7p8PnfIs6ie5xFUSlsgoBf1fMUIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "82b1f7ea-3de7-43f6-9be8-bd2231bc5670", new DateTime(2023, 11, 27, 15, 18, 25, 323, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 11, 27, 15, 18, 25, 323, DateTimeKind.Local).AddTicks(2546), "AQAAAAIAAYagAAAAEJcwWW09JqMfM++nTbqaGrYGC3VqEURyxwRe0coUTE8KnQIyoR8RduIXyGb5pSD0Tw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "1ccfed56-1f63-488c-a0a8-f141e8b0978d", new DateTime(2023, 11, 27, 15, 18, 25, 42, DateTimeKind.Local).AddTicks(6462), new DateTime(2023, 11, 27, 15, 18, 25, 42, DateTimeKind.Local).AddTicks(6443), "AQAAAAIAAYagAAAAEB43pNMCyLF6UeZRFO7YtXCWKD7kq7cZ3Z6Q1Qig6QGTxgpZf5lQisn2EQGmxCqSLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "09e7ea67-49bf-4b30-b30a-c4922f3b50b8", new DateTime(2023, 11, 27, 15, 18, 25, 238, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 11, 27, 15, 18, 25, 238, DateTimeKind.Local).AddTicks(2196), "AQAAAAIAAYagAAAAEJjBDEFfrg5Mn1IdNpmJnW/ZnEQgtD0qXtXklOqrYB+e+dsxWlaIX9jYK2tsREr+Pg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "7dc0f25f-22c5-4aa4-b335-02fd9977d6fd", new DateTime(2023, 11, 27, 15, 18, 24, 909, DateTimeKind.Local).AddTicks(4184), "AQAAAAIAAYagAAAAEBxAMgDdWR4R/yTNjhoJE3lYeEsI+/PolIhKd0pAXqw9uYMO1hx+KTwMFfhPyXFWuQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "e3f920d7-8946-46c0-9e2c-78872230bd90", new DateTime(2023, 11, 27, 15, 18, 24, 977, DateTimeKind.Local).AddTicks(5815), "AQAAAAIAAYagAAAAEIiT0XSEkqSb7Y40lDCqvlfsKsmtuyHIa/jRixcLCvwuWraLS2gyFL0AjHdIWzahbg==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "3339f46f-3683-4587-8048-b43889f20856", new DateTime(2023, 11, 27, 15, 18, 24, 843, DateTimeKind.Local).AddTicks(4677), "AQAAAAIAAYagAAAAEFTbOpaByZwAt5o5TFJcJWtl8qhgY0+eL4Mu4+j4xY/djuCZwS2r9G4L4j+Nb9Wd2w==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(427), new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Description", "Name", "Quantity" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(919), "Best frame in the road!", "Frame Road", 2.0 });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated", "Description", "Name", "OEMNumber", "Quantity", "SalePrice" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(929), "Best frame in the montain", "Frame Montain", "oemtest2", 4.0, 90.00m });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateCreated", "Description", "Name", "OEMNumber", "Quantity", "SalePrice" },
                values: new object[] { 1, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(958), "Best frame in the road for womens", "Frame Road woman", "oemtest2", 3.0, 80.00m });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "IsDeleted", "Name", "OEMNumber", "Quantity", "SalePrice", "Type", "VATCategoryId" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(962), null, null, "Best wheels ever!", false, "Wheel of the Year for road", "oemtest", 50.0, 75.00m, 1, 1 },
                    { 5, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(966), null, null, "Best wheels for a montain!", false, "Wheel of the Year for montain", "oemtest", 40.0, 85.00m, 2, 1 },
                    { 6, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(970), null, null, "Best wheels for a road!", false, "Road wheel best seler", "oemtest", 50.0, 65.00m, 3, 1 },
                    { 7, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(975), null, null, "Worst shift - have only one!", false, "Shift", "oemtest", 9.0, 250.00m, 1, 1 },
                    { 8, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(979), null, null, "Best shifts for a montain!", false, "Montain Shifts", "oemtest", 19.0, 350.00m, 2, 1 },
                    { 9, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(983), null, null, "Best shifts for a road!", false, "Road Shifts", "oemtest", 29.0, 400.00m, 3, 1 },
                    { 10, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(988), null, null, "Better shifts for a road!", false, "Road better Shifts", "oemtest9", 21.0, 410.00m, 3, 1 },
                    { 11, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(992), null, null, "Budget shifts for a road!", false, "Road budget Shifts", "oemtest91", 21.0, 290.00m, 3, 1 },
                    { 12, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(996), null, null, "Cheap standard shift!", false, "Shift", "oemtest21", 9.0, 220.00m, 1, 1 },
                    { 13, 3, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1000), null, null, "Budget shifts for a montain!", false, "Montain Shifts", "oemtest98", 19.0, 280.00m, 2, 1 },
                    { 14, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1003), null, null, "Budget wheels ever!", false, "Budget wheel for road", "oemtest34", 50.0, 65.00m, 1, 1 },
                    { 15, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1007), null, null, "Budget wheel for a montain!", false, "Budget wheel for a montain", "oemtest56", 40.0, 75.00m, 2, 1 },
                    { 16, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1017), null, null, "The cheapest wheel for a road!", false, "The cheapest road wheel", "oemtest", 50.0, 55.00m, 3, 1 },
                    { 17, 2, new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1031), null, null, "The best  titanium wheel for a road!", false, "Road titanium wheel", "oemtest567", 50.0, 95.00m, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1237), new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1287), new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1333), new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1334) });

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

            migrationBuilder.DropTable(
                name: "CompatableParts");

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Parts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "Measuring unit of the part");

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
                columns: new[] { "DateCreated", "Description", "Name", "Quantity", "Unit" },
                values: new object[] { new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8725), "Best frame in the world!", "Frame OG", 3.0, "count" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateCreated", "Description", "Name", "OEMNumber", "Quantity", "SalePrice", "Unit" },
                values: new object[] { 2, new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8755), "Best wheels ever!", "Wheel of the Year", "oemtest", 50.0, 75.00m, "count" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateCreated", "Description", "Name", "OEMNumber", "Quantity", "SalePrice", "Unit" },
                values: new object[] { 3, new DateTime(2023, 11, 20, 10, 43, 46, 87, DateTimeKind.Local).AddTicks(8761), "Worst shift - have only one!", "Shift", "oemtest", 9.0, 250.00m, "count" });

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
    }
}
