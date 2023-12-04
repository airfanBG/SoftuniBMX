using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategorySeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "bda69e76-c7f8-44c4-a3cf-29e8cf91f698", new DateTime(2023, 12, 3, 12, 46, 29, 245, DateTimeKind.Local).AddTicks(3184), new DateTime(2023, 12, 3, 12, 46, 29, 245, DateTimeKind.Local).AddTicks(3141), "AQAAAAIAAYagAAAAEEsoGdqTrlDDkZF25IkLgtvWa1I6980WZd3W0ZihbnuHQ5SPLcl2fnGj1oBd7k5c2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "9b028b03-f7a3-4c88-b30d-ad3ab7a2d3c4", new DateTime(2023, 12, 3, 12, 46, 29, 169, DateTimeKind.Local).AddTicks(2654), new DateTime(2023, 12, 3, 12, 46, 29, 169, DateTimeKind.Local).AddTicks(2616), "AQAAAAIAAYagAAAAEGKlT4HQi9svbQ3Tgt77/QIEvwmdDSQEqii/nMt3DCW8UVFKKwKPz2mZYwxyZ5O56g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "10255097-e35e-4c0f-b984-b531c0441bb7", new DateTime(2023, 12, 3, 12, 46, 29, 410, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 12, 3, 12, 46, 29, 410, DateTimeKind.Local).AddTicks(2797), "AQAAAAIAAYagAAAAEGzXp9aOnsVvVrrBR9qcIOMM5zMJrNKJFn7GDYUllD0nEYjr6SG37R4273+aWWdvkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "0e7646aa-7cbd-42fa-861e-e23c33844aff", new DateTime(2023, 12, 3, 12, 46, 29, 92, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 12, 3, 12, 46, 29, 92, DateTimeKind.Local).AddTicks(2984), "AQAAAAIAAYagAAAAEAV68zwxKptBMunUcYHG5Zy4/IJr53uDJMtfZBKkg1oXiXtMKJpza2OJBOjBpYtl2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "baecb5b5-8c9e-4ba0-b6fe-5e7a62f6b389", new DateTime(2023, 12, 3, 12, 46, 29, 333, DateTimeKind.Local).AddTicks(5400), new DateTime(2023, 12, 3, 12, 46, 29, 333, DateTimeKind.Local).AddTicks(5270), "AQAAAAIAAYagAAAAEDwpL04EZt/AA8DQTKe29JwnSN062h1gi6jOJPzOy5EtEgl6SNl6u+ZLvUVPYRpWnw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "8c32acc2-51a6-4cc9-859c-64044bdeb2ca", new DateTime(2023, 12, 3, 12, 46, 28, 930, DateTimeKind.Local).AddTicks(7487), "AQAAAAIAAYagAAAAEK35A5SxEro0JteXZ9whD4JXr+Iz6fXXmqpJAa+POy6eyq97SnMgn1PCSJ95WDrj5w==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "66bf009b-76d8-417a-bd3d-bf3ae2843ea4", new DateTime(2023, 12, 3, 12, 46, 29, 12, DateTimeKind.Local).AddTicks(8348), "AQAAAAIAAYagAAAAEFctUVH+bis88uUyacGoK0GvIDYZzOycVw/g33fJ+0KTZKgxL0T+9SPJygYZo+g3dw==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "621cb756-f40f-4ca2-900a-c2f06d487e97", new DateTime(2023, 12, 3, 12, 46, 28, 848, DateTimeKind.Local).AddTicks(5379), "AQAAAAIAAYagAAAAEIo3v24qDQhLY83KvWlbejQRo0CKj6miCDOuWvVzn0I4pcxlWLDNHOV/7gHIjAkSzw==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                keyValues: new object[] { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb" },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6267), "Acsessories" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6439), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6491), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6532), new DateTime(2023, 12, 3, 12, 46, 29, 484, DateTimeKind.Local).AddTicks(6533) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "DatetimeAsigned",
                value: new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(6988));

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
                columns: new[] { "DateCreated", "Name" },
                values: new object[] { new DateTime(2023, 12, 1, 15, 12, 40, 924, DateTimeKind.Local).AddTicks(7661), "Shift" });

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
    }
}
