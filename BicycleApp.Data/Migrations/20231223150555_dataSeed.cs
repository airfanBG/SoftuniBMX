using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class dataSeed : Migration
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2aa75e7-432d-42be-8c83-a98579e697ff", "AQAAAAIAAYagAAAAEPpOBdBAh8j4KajsflrgaputLS524aCec8dII+GnbemGUOpV9PItHSfRIggRmro+3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d8f448c0-4563-40a4-8a48-e5d3dc453623", "AQAAAAIAAYagAAAAEN70kMAtjzVpoV3cf17onWexQ2ZXkZM/FQq8rEkHXaS+Fk0Gc8aNqZXEKG+sjti9Lw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a059d27-3ffb-4784-9878-9a6991be6bec", "AQAAAAIAAYagAAAAEHXm2ckVW9NNc9acROhRkQvnUNGqwVjdKY12ahqfG+jgA6vhrWqdIWR7gy6qYnNNgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76fe9dff-6db8-4899-aad3-84fd45c91e07", "AQAAAAIAAYagAAAAEMNkFZfuUlZLBlpoj+Iyq8oHmj34HHVE3fD8q2ikVm2wZ3TXA1n6HiSQREPkx0k6oA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4c550ca-fe74-4dde-b4ed-ca5890908fe2", "AQAAAAIAAYagAAAAENhyISjFGh8iTrTchtTSyld6cAjpmxyG5pOgrOftyCtmLEDK/kcU2RO4k8qlo2o1aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "925fd055-0246-4b7a-b2bd-a7e2d3fb5937", "AQAAAAIAAYagAAAAELYyIww4o1hXO8gamDcwXXNNL0O8/Cp+A0sgLN2lLM3vFXv1hbcdu2O+JB+ecAhnJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0673bba6-dfc2-425b-afa3-47b79fc10ed8", "AQAAAAIAAYagAAAAEMmfqz4odU4s7xRuAS4jjLmmjV8yjI7jV1s92Q8T9QYTYh8o2br4yZjD9EdQ0Ri95g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ada7c923-f7a5-46dd-a4eb-b385eb684a8f", "AQAAAAIAAYagAAAAEG0+nJ0mBc6MsYjnZ5F5hdvAZTVoh8A21qBF6POXrdJTRP3nGbGixTjFoVPlrT0lvQ==" });

            migrationBuilder.UpdateData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImageName", "ImageUrl" },
                values: new object[] { new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), "Frame Road", "https://yuchormanski.free.bg/bikes/frame1.webp" });

            migrationBuilder.InsertData(
                table: "ImagesParts",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ImageName", "ImageUrl", "IsDeleted", "PartId" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Frame Montain", "https://yuchormanski.free.bg/bikes/frame2.webp", false, 2 },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Frame Road woman", "https://yuchormanski.free.bg/bikes/frame3.webp", false, 3 },
                    { 4, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Wheel of the Year for road", "https://yuchormanski.free.bg/bikes/wheel1.webp", false, 4 },
                    { 5, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Wheel of the Year for montain", "https://yuchormanski.free.bg/bikes/wheel2.webp", false, 5 },
                    { 6, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Road wheel best", "https://yuchormanski.free.bg/bikes/wheel3.webp", false, 6 },
                    { 7, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Shift", "https://yuchormanski.free.bg/bikes/sprocket1.webp", false, 7 },
                    { 8, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Montain Shift", "https://yuchormanski.free.bg/bikes/sprocket2.webp", false, 8 },
                    { 9, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Road Shifts", "https://yuchormanski.free.bg/bikes/sprocket3.webp", false, 9 },
                    { 10, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Road better Shifts", "https://yuchormanski.free.bg/bikes/sprocket4.webp", false, 10 },
                    { 11, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Road budget Shift", "https://yuchormanski.free.bg/bikes/sprocket6.webp", false, 11 },
                    { 12, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Shift", "https://yuchormanski.free.bg/bikes/sprocket5.webp", false, 12 },
                    { 13, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Montain Shift", "https://yuchormanski.free.bg/bikes/sprocket7.webp", false, 13 },
                    { 14, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget wheel for road", "https://yuchormanski.free.bg/bikes/wheel5.webp", false, 14 },
                    { 15, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget wheel for a montain", "https://yuchormanski.free.bg/bikes/wheel8.webp", false, 15 },
                    { 16, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "The cheapest road wheel", "https://yuchormanski.free.bg/bikes/wheel6.webp", false, 16 },
                    { 17, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Road titanium wheel", "https://yuchormanski.free.bg/bikes/wheel7.webp", false, 17 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 17);

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
                values: new object[] { "2188ba65-2ea6-413b-8b7d-37e1a75d743f", "AQAAAAIAAYagAAAAECtugVjXzQJQa9jKEJM+U+xj3Q8ZB2EYst//YIIoBXo7KCI36Yhb85JYm8BcYa/laA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "218e72b1-3adb-4b43-bd3e-8a1b7b791d15", "AQAAAAIAAYagAAAAEOa9Va02RMh6kAnZTjuHAfqiXXVdutGiwzd4gpBUdVtf1DT0vMxuyLKhygjWcQJt2Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21003785-a275-4139-ae20-af6a6cf8fea8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c300b898-d540-4cd7-891a-55f49b9a4618", "AQAAAAIAAYagAAAAEOPnIAsR/M/XoW78HqDSiP752RPJZUVHC68jKiyBGKiSuh43RRhW+viKxo3lz/rzRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29f06920-d2ad-43d8-b362-e2b94d7a7502",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b969229-592b-4fea-8c13-56a23f796840", "AQAAAAIAAYagAAAAEFg4dEKshYJOxU3RcFVQQzZnNs3Fid/iDG8PkGPN9YdcoEhY6rnfaA3idW1aOtwKuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "406e8cf1-acaa-44a8-afec-585ff64bed34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4fa08c8-fd38-485c-bef1-d8b821581d99", "AQAAAAIAAYagAAAAEPfnfAO1AEyhJCJsDiINBnxx7z6H5qg6W3nNP5CVfJ53hYYOoHUVphdddsAyCbGlkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc9aecbf-b86c-492c-ba90-8ca327c15569", "AQAAAAIAAYagAAAAEKAPB6fSP4TUM45qgp/3ZuCU/uORX+ZAroGJBw1hNLWiwPz+ZPzf+Keee+NhcEnrrw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99d3ca6f-2067-4316-a5d7-934c93789521",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ead155c-0024-48b0-9f7f-c0fc2a4184b8", "AQAAAAIAAYagAAAAEC4aEg6UP7z5zSm8wWLCskRgRy3ElLrFiI3Rgtv0FFzDEj/vwp+9sseT39rwZNgj4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b327f332-bb4f-4e79-82ec-0211c4a1c80a", "AQAAAAIAAYagAAAAEA2mCrvCEpNSrkaLt2BOk3DCsgnXjC50IXoVR33zPzakPJVwtfrPeRxH0EIXZjfPDg==" });

            migrationBuilder.UpdateData(
                table: "ImagesParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "ImageName", "ImageUrl" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "image", "test" });
        }
    }
}
