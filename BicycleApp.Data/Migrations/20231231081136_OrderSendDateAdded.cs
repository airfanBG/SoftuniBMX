using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderSendDateAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateSended",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                comment: "Date of the order sended");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a221418-0812-4b4f-8f3a-49c414f863a2", "AQAAAAIAAYagAAAAEHj1W9T08zsSgKUS1TPwE5ZtUUzesAr8Houk/5xUu3yLzZRrgtENo3ussVoYPfn5aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f9ad160-23e2-4168-823e-9e28277fbc94", "AQAAAAIAAYagAAAAEP4OQEhS2JjjN1fdg8LPNV9W38s4KwGzXal2RIaRLFmvj2x7YZ2r6Xc+X1s3v6hcGQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dcfbbca-074d-43d8-a22e-f9998253eac8", "AQAAAAIAAYagAAAAEH9KRP0I2kePXvcbXAgqfaD2kFDPn+5JUVf8SslHJRlLcRO9DfM9FR+pyStfQLZ5eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99b51f1a-0fb5-4f87-ac81-887f9b0365a9", "AQAAAAIAAYagAAAAEL4qOsKAl+XP8U1wvN6bXrrmgAdPGzI16vlg6BI1lVVGFwgrypnqJwazT44qT57Y9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eba94708-a9b7-49df-9980-80dc044cf40e", "AQAAAAIAAYagAAAAEEKBXGk2OgRE8x0KjoBRkhnXxezi2KmGY9kLuJ5zKGPomch1hbnP8MXbwx24osbjgw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "425e4116-9bab-4f2d-9cc7-f7a8344ad890", "AQAAAAIAAYagAAAAENacTntPDvR7KlhsjPxllXva2YDX3qIHyh8Qu7z8kUr2g8DqUp9yytuLeyTpMQv0Bw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35c0f3f0-21f2-4b01-abe0-8701c033dff5", "AQAAAAIAAYagAAAAEA+J7eI+tzQBa/bnmbchw1ul+/Nr9WfGLPR3Klz9uqj3z6/bJAftdq7aQQ8eLyljbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff3854d7-abda-45f7-a4e0-7e20961d2177", "AQAAAAIAAYagAAAAEMY7ZeN5ck9PQ33WAk9ZWJHUpFyCse1RUa4DUQGaDab9QtZMlmSJTn0dagM/Squ0UA==" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateSended",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateSended",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateSended",
                table: "Orders");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c9e1a9c-9970-4af3-9fcc-5e37525294e7", "AQAAAAIAAYagAAAAEBNurX3lplkdMG7rtxZj1t7/IoUurDd7pyfZBvk/NvuOfXSJZB+oPE7eJWgSJ1xh6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76e95c52-d8ac-483b-8a2c-dbbea718ba76", "AQAAAAIAAYagAAAAEGx52aeL/A+akeXOnu5E4lEjTP7FpaGUArZGqFr0C9V4cOofbCxyS/zh6ScAUexbDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e779b37c-4e4e-4867-aa3f-c9d342fb4dc9", "AQAAAAIAAYagAAAAEFIB4jjDGbj864zAaoR87GyxUmwNAMS/Ngx0FGQNEm8O+8Oc291Q44nEgeXutytfKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7dbebd73-03be-4bfe-8432-8c1edc11b011", "AQAAAAIAAYagAAAAEBQY5bXwLFdlNyYTncg0P9d2FwdzREKBGUoMhhndDvDcbZZ4odruxPA2iJryUFCDrA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8e85a0a-12bc-4ea3-9f63-05369666eb86", "AQAAAAIAAYagAAAAEMJUgSQmvGo9WEepqx2hFiT8liEN54H9rDmvKdcuhh76237HAuj2qwYAwJxzw5YbDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "105756f4-2ccf-4a1f-a155-3bfad70ff538", "AQAAAAIAAYagAAAAEPDOJZTRebeLYRkuDdiuy2EgJColBNGyxaSdMb6d3GzGzwIKs02B/maluYNUHhVnew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "813ec0f0-d8dd-4517-a7aa-29d95b9c2af8", "AQAAAAIAAYagAAAAEEilbZ+hThkBow305Z+G6q9HSvn0GHQnpU7Bz5QNQVDkabFdhLY5EPqDfPtSRrqFdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8a361a9-9ed2-4fef-b634-e439b8cd1516", "AQAAAAIAAYagAAAAEFcfl5jytQtn1/5pXk8B4WwHfVSqtTBjdPAkRLeYcobu1DHNLlI650BJJfECYGJ6Ew==" });
        }
    }
}
