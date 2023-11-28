using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class PropertyAddedInPartEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                comment: "Full description of the part",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true,
                oldComment: "Full description of the part");

            migrationBuilder.AddColumn<string>(
                name: "Intend",
                table: "Parts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Intention of the part");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17063948-8fdc-417e-8fb7-2ae6bf572f94",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "d43e948e-5c83-4527-b69a-3c1a4accfd3a", new DateTime(2023, 11, 28, 9, 11, 7, 851, DateTimeKind.Local).AddTicks(4540), new DateTime(2023, 11, 28, 9, 11, 7, 851, DateTimeKind.Local).AddTicks(4535), "AQAAAAIAAYagAAAAEPCXl7VyGPCG2k3PdWx5iXfWjBpcFUFPqIQvaHOG0fLkE7CnsSa9Y9Ly5tyAZtCJqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "83170453-beb4-456c-8a62-3446be655d13", new DateTime(2023, 11, 28, 9, 11, 7, 790, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 11, 28, 9, 11, 7, 790, DateTimeKind.Local).AddTicks(4867), "AQAAAAIAAYagAAAAENgqwqG0NB9HCcl27wi5g/Wvd1CTwKmVTu4teSGUd+fnc0oFgpEVLM7MOTM//0bDnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f45fcfc9-d64b-42b0-8e4a-f935616b8009", new DateTime(2023, 11, 28, 9, 11, 7, 975, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 11, 28, 9, 11, 7, 975, DateTimeKind.Local).AddTicks(1829), "AQAAAAIAAYagAAAAELzFiy5gd3X5y5SFJxzMuAPOWDQpuwreT9+YUEZVM4a9yM47TIX/UGpbQ8cKcRjwtw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "db6d4d5e-df3c-45e4-96e8-f360330f8f69", new DateTime(2023, 11, 28, 9, 11, 7, 728, DateTimeKind.Local).AddTicks(6904), new DateTime(2023, 11, 28, 9, 11, 7, 728, DateTimeKind.Local).AddTicks(6861), "AQAAAAIAAYagAAAAEG60SKcphyjHnYvW7m2YC+APYeRdOZcTU7j6NsHGP840kKMmGFLguswYGuBrocBdNA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateOfHire", "PasswordHash" },
                values: new object[] { "f3288a84-56de-4afc-bcfa-c505af51097c", new DateTime(2023, 11, 28, 9, 11, 7, 912, DateTimeKind.Local).AddTicks(4376), new DateTime(2023, 11, 28, 9, 11, 7, 912, DateTimeKind.Local).AddTicks(4372), "AQAAAAIAAYagAAAAELDq/30v9sAQgMUvUf6uYHAEBpRj0Selz1qJ4k2sl2tkJKyCgGiwruhDv3pwyz5lhQ==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "c952d748-7b61-4bdc-aee2-d4230db25219", new DateTime(2023, 11, 28, 9, 11, 7, 595, DateTimeKind.Local).AddTicks(676), "AQAAAAIAAYagAAAAEE73Vg8HgpyIRVEsmlewLaoptmVeDv7DQNIlgybZzFicaf9YHFfyHR14typYACPvAA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "edbba8ca-ab70-4d4c-a9e6-0f0118192d84", new DateTime(2023, 11, 28, 9, 11, 7, 663, DateTimeKind.Local).AddTicks(608), "AQAAAAIAAYagAAAAEHOfuHKFU1ea1KN6ceR5rFvkWaiBxcpaJT+2LoGd8zz9XZoTqKsu2XFwoOAUiuPAVA==" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "PasswordHash" },
                values: new object[] { "9483ad26-cd91-47a8-8494-324d44004cda", new DateTime(2023, 11, 28, 9, 11, 7, 526, DateTimeKind.Local).AddTicks(4276), "AQAAAAIAAYagAAAAEJxti6KNB9riqhXP96tmyjrlsGFuzliOjNsJaZyyIQIPjk+eiy98MXIW+XS4XTOMIQ==" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "Delivaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateDelivered", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "OrdersPartsEmployees",
                keyColumns: new[] { "OrderId", "PartId" },
                keyValues: new object[] { 1, 1 },
                column: "DatetimeAsigned",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "PartCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6633), "For road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6642), "For montain usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6646), "For road usage in women bikes" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6718), "Best wheels for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6722), "Best wheels for a montain usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6727), "Best seler for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6732), "Base shift - have only one" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6735), "Best shift for a montain usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6739), "Best shift for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6743), "Better shift for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6747), "Budget shift for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6750), "Cheap standard shift for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6754), "Budget shift for a montain usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Description", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6758), "Budget wheel ever!", "Budget wheel for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6761), "Budget wheel for a montain usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6797), "The cheapest wheel for a road usage" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Description", "Intend" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6801), "The best titanium wheel for a road!", "The best titanium wheel for a road usage" });

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Supliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6985), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7021), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "VATCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7063), new DateTime(2023, 11, 28, 9, 11, 8, 37, DateTimeKind.Local).AddTicks(7064) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Intend",
                table: "Parts");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parts",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                comment: "Full description of the part",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldComment: "Full description of the part");

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
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1003), "Budget wheels ever!" });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "Description" },
                values: new object[] { new DateTime(2023, 11, 27, 15, 18, 25, 395, DateTimeKind.Local).AddTicks(1031), "The best  titanium wheel for a road!" });

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
        }
    }
}
