﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BicycleApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BikesStandartModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of standart bike."),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entity"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the entity"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of deletion of the entity"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the department: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikesStandartModels", x => x.Id);
                });

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
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "The name of the department"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entity"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the entity"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of deletion of the entity"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the department: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                },
                comment: "Table of all departments in the database");

            migrationBuilder.CreateTable(
                name: "PartCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Name of the category"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Url of the general image for this category"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the category"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the category"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the category"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the category: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartCategories", x => x.Id);
                },
                comment: "Table of all categories for a part in the database");

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "The name of the status"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the status"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the status"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the status"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "State of the status: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                },
                comment: "Table with all the statuses for the orders");

            migrationBuilder.CreateTable(
                name: "Supliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the firm"),
                    VATNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Unique VAT number of the suplier"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Main address of the suplier"),
                    PhoneNumeber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, comment: "Main phone number of the supplier"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Main email of the suplier"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The category name of the suplied part"),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the main person for contact with the suplier"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entry"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the entry"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the entry"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the entry: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supliers", x => x.Id);
                },
                comment: "Table of all supliers in the database");

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the town"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the town entry"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the town entry"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the town entry"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                },
                comment: "Table of all towns registered in the database");

            migrationBuilder.CreateTable(
                name: "VATCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VATPercent = table.Column<decimal>(type: "decimal(6,2)", nullable: false, comment: "Current percent of the VAT for this category parts"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the category"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the category"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the category"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the category: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VATCategories", x => x.Id);
                },
                comment: "Table of all vat categories in the database");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartsInStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OemPartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Unic number of the part"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entry"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the entry"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the entry"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the entry: Active/Inactive"),
                    SuplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsInStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartsInStock_Supliers_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Supliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DelivaryAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    District = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Block = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    Apartment = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StrNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelivaryAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DelivaryAddresses_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the part"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Full description of the part"),
                    Intend = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Intention of the part"),
                    OEMNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Unique number of the part from the manifacturer"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "Type of the part"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Id of the category of the part"),
                    Quantity = table.Column<double>(type: "float(2)", nullable: false, comment: "Current quantity of the part in the database"),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Sale price of the part before VAT"),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Discount for part"),
                    VATCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Id of the current vat category of the part"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entry in tha database"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the entry in the database"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the entry from the database"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the part: Deleted/Not deleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parts_PartCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "PartCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parts_VATCategories_VATCategoryId",
                        column: x => x.VATCategoryId,
                        principalTable: "VATCategories",
                        principalColumn: "Id");
                },
                comment: "Table of all the parts in the database");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "The first name of the user"),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, comment: "The last name of the user"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the account: Active/Inactive"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the account"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of account data"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the account"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DelivaryAddressId = table.Column<int>(type: "int", nullable: true, comment: "The default address of the client for deliveries"),
                    TownId = table.Column<int>(type: "int", nullable: true, comment: "The Id of the default town for this client"),
                    IBAN = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true, comment: "IBAN of the client"),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true, comment: "The amount of the deposited money in this client account"),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Current position of the employee in the company"),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of hire of the employee"),
                    DateOfLeave = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of termination of the employee"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true, comment: "Id of the current department of the employee"),
                    IsManeger = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_DelivaryAddresses_DelivaryAddressId",
                        column: x => x.DelivaryAddressId,
                        principalTable: "DelivaryAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Towns_TownId",
                        column: x => x.TownId,
                        principalTable: "Towns",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BikeModelsParts",
                columns: table => new
                {
                    BikeModelId = table.Column<int>(type: "int", nullable: false),
                    PartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeModelsParts", x => new { x.PartId, x.BikeModelId });
                    table.ForeignKey(
                        name: "FK_BikeModelsParts_BikesStandartModels_BikeModelId",
                        column: x => x.BikeModelId,
                        principalTable: "BikesStandartModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BikeModelsParts_Parts_BikeModelId",
                        column: x => x.BikeModelId,
                        principalTable: "Parts",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Delivaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part"),
                    QuantityDelivered = table.Column<double>(type: "float(2)", nullable: false, comment: "Quantity delivered of the current part"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Additional info for the current delivary"),
                    DateDelivered = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entry"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the entry"),
                    SuplierId = table.Column<int>(type: "int", nullable: false, comment: "Id of the suplier for this delivary"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of deletion of the entity"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the department: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Delivaries_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Delivaries_Supliers_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Supliers",
                        principalColumn: "Id");
                },
                comment: "Table of all delivaries of all parts in the database");

            migrationBuilder.CreateTable(
                name: "ImagesParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the image"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Url of the image"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entity"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the entity"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of deletion of the entity"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the department: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesParts_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                },
                comment: "Table with the location of all images of all parts in tha database");

            migrationBuilder.CreateTable(
                name: "PartOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Quantity delivered of the current part"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Additional info for the current order"),
                    SuplierId = table.Column<int>(type: "int", nullable: false, comment: "Id of the suplier for this delivary"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entry"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the entry"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the entry"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the entry: Active/Inactive"),
                    PartId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartOrders_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartOrders_Parts_PartId1",
                        column: x => x.PartId1,
                        principalTable: "Parts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PartOrders_Supliers_SuplierId",
                        column: x => x.SuplierId,
                        principalTable: "Supliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Table of all orders of parts in the database");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part"),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Title of the comment"),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false, comment: "Description of the comment"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the entity"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the last update of the entity"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of deletion of the entity"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the department: Active/Inactive")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                },
                comment: "Table of all comments for all parts in the database");

            migrationBuilder.CreateTable(
                name: "ImagesClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the image"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Url of the image"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Id of the client")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesClients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesClients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "Table with the location of all images of all clients in tha database");

            migrationBuilder.CreateTable(
                name: "ImagesEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the image"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Url of the image"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Id of the client"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagesEmployees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                },
                comment: "Table with the location of all images of all employees in tha database");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Id of the client of this order"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "All information of the ordered parts from the client, as a string"),
                    SaleAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The amount of the order before discount and tax"),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The amount of the discoint"),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The amount of the VAT"),
                    FinalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The final amount of the order after discount and tax"),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The amount paid from this order"),
                    UnpaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The amount not paid from this order"),
                    StatusId = table.Column<int>(type: "int", nullable: false, comment: "Id of the current status of the order"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the order"),
                    DateFinish = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the completion of the order"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the order"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the order"),
<<<<<<<< HEAD:BicycleApp.Data/Migrations/20240101142728_Initial.cs
                    DateSended = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the order sended"),
========
>>>>>>>> UI-K:BicycleApp.Data/Migrations/20231227174452_Initial.cs
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the order deleted: Yes/No")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                },
                comment: "Table of all orders from clients in the database");

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    ClientId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Id of the client who has rated the current part"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part who has the client rated"),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "The last rating for the part given by the client"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the order"),
                    DateFinish = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the completion of the order"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the order"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the order"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the order deleted: Yes/No")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => new { x.PartId, x.ClientId });
                    table.ForeignKey(
                        name: "FK_Rates_AspNetUsers_ClientId",
                        column: x => x.ClientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rates_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                },
                comment: "Table of all the ratings for all the part in the database");

            migrationBuilder.CreateTable(
                name: "OrdersPartsEmployees",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Id of the order from the client"),
                    UniqueKeyForSerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Separate unique products by serial number in one order"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part"),
                    SerialNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false, comment: "Unique serial number of the order"),
                    PartName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Name of the part"),
                    PartQuantity = table.Column<double>(type: "float(2)", nullable: false, comment: "Quantity of the part"),
                    PartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Price of the part"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "Id of the emplyee asigned to this order"),
                    DatetimeAsigned = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time of asigned task to the employee"),
                    StartDatetime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time of start of the task from the employee"),
                    EndDatetime = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date and time of finish of the task from the employee"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Description of the task"),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false, comment: "Status of the task: Completed/Not completed"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the creation of the order"),
                    DateFinish = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the completion of the order"),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of last update of the order"),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of the deletion of the order"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Is the order deleted: Yes/No")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersPartsEmployees", x => new { x.OrderId, x.PartId, x.UniqueKeyForSerialNumber });
                    table.ForeignKey(
                        name: "FK_OrdersPartsEmployees_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdersPartsEmployees_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrdersPartsEmployees_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                },
                comment: "Table conecting all the parts in an order with the employee responsible for the mounting");

            migrationBuilder.CreateTable(
                name: "OrdersPartsEmployeesInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id of information for manufacturing part.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionForWorker = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Id of the order from the quality control"),
                    ProductionТime = table.Column<TimeSpan>(type: "time", nullable: false, comment: "Timespan for production on part."),
                    OrderId = table.Column<int>(type: "int", nullable: false, comment: "Id of the order from the client"),
                    UniqueKeyForSerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Separate unique products by serial number in one order"),
                    PartId = table.Column<int>(type: "int", nullable: false, comment: "Id of the part")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersPartsEmployeesInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersPartsEmployeesInfos_OrdersPartsEmployees_OrderId_PartId_UniqueKeyForSerialNumber",
                        columns: x => new { x.OrderId, x.PartId, x.UniqueKeyForSerialNumber },
                        principalTable: "OrdersPartsEmployees",
                        principalColumns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "566110d3-06fe-4ca2-b34b-9334a842c88f", null, "accessoriesworker", "ACCESSORIESWORKER" },
                    { "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", null, "user", "USER" },
                    { "a9618213-7ba0-48cf-81d4-00cd16910ec7", null, "wheelworker", "WHEELWORKER" },
                    { "ac558b05-a97b-42c8-bd62-dbd33f36d795", null, "qualitycontrol", "QUALITYCONTROL" },
                    { "f0d2cbfa-cdca-4936-9d85-f9a697d39f2b", null, "manager", "MANAGER" },
                    { "fa8f997a-4e15-475f-a028-87a9b6e6be56", null, "frameworker", "FRAMEWORKER" }
                });

            migrationBuilder.InsertData(
                table: "BikesStandartModels",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "Description", "ImageUrl", "IsDeleted", "ModelName", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Slow Initial Rendering: Since the data is fetched from the server before rendering, initial load times can be slow, resulting in a less-than-ideal user experience.", "https://yuchormanski.free.bg/bikes/bike-1.webp", false, "Bike 1", 575m },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Loading States: Users may experience an in-between or loading state, as they wait for the data to be rendered on the page.", "https://yuchormanski.free.bg/bikes/bike-2.webp", false, "Bike 2", 365m },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Lack of Interactivity: There isn’t much opportunity for interactivity with the user until the data has been fully loaded and rendered on the page.", "https://yuchormanski.free.bg/bikes/bike-3.webp", false, "Bike 3", 455m }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Administration" },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Workshop" }
                });

            migrationBuilder.InsertData(
                table: "PartCategories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "test", false, "Frame" },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "test", false, "Wheel" },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "test", false, "Acsessories" }
                });

            migrationBuilder.InsertData(
                table: "PartsInStock",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "OemPartNumber", "SuplierId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest1", null },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest2", null },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest3", null },
                    { 4, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest4", null },
                    { 5, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest5", null },
                    { 6, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest6", null },
                    { 7, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest7", null },
                    { 8, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest8", null },
                    { 9, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest9", null },
                    { 10, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest10", null },
                    { 11, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest11", null },
                    { 12, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest12", null },
                    { 13, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "oemtest13", null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Pending approval" },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Approved order" },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Frame management" },
                    { 4, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Wheel management" },
                    { 5, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Shift management" },
                    { 6, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Quality control" },
<<<<<<<< HEAD:BicycleApp.Data/Migrations/20240101142728_Initial.cs
                    { 7, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Sended order" }
========
                    { 7, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Send order" }
>>>>>>>> UI-K:BicycleApp.Data/Migrations/20231227174452_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "Supliers",
                columns: new[] { "Id", "Address", "CategoryName", "ContactName", "DateCreated", "DateDeleted", "DateUpdated", "Email", "IsDeleted", "Name", "PhoneNumeber", "VATNumber" },
                values: new object[,]
                {
                    { 1, "Sofia, center", "Frame", "Pesh Peshev", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), "text@test.bg", false, "X Ltd", "1234567890", "123456789" },
                    { 2, "Sofia, east", "Wheel", "Pesho Peshev", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), "text2@test.bg", false, "XX Ltd", "1234567899", "123456788" },
                    { 3, "Sofia, west", "Acsessories", "Ivan Peshev", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), "text3@test.bg", false, "XXX Ltd", "1234567897", "123456787" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "Sofia" },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Varna" },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, false, "Burgas" }
                });

            migrationBuilder.InsertData(
                table: "VATCategories",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "VATPercent" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, 20.00m });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateOfHire", "DateOfLeave", "DateUpdated", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsDeleted", "IsManeger", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BicycleApp.Data/Migrations/20240101142728_Initial.cs
                    { "17063948-8fdc-417e-8fb7-2ae6bf572f94", 0, "03901d67-e598-4a9c-8199-8ff320b3fcfe", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "todorov@b-free.com", true, "Todor", false, false, "Todorov", false, null, "TODOROV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEEsxaqlGMju79wMIhVw69/EWgxtDwXC6w8TYORBUOj5TPwDNkJQJuB+GzIo/zN2O6Q==", "1234567890", false, "Wheelworker", "TODOROV@B-FREE.COM", false, "todorov@b-free.com" },
                    { "21003785-a275-4139-ae20-af6a6cf8fea8", 0, "9bd9cfce-93f4-4982-a4fc-c2cfc41ba0dc", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "marinov@b-free.com", true, "Marin", false, false, "Marinov", false, null, "MARINOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEAfJJGMusjxq44NsFdV+AeEqcXT1WZfcGDqF4bg1W+OabiNva9CTnNnrxOF1ZPLXXQ==", "1234567890", false, "FrameWorker", "MARINOV@B-FREE.COM", false, "marinov@b-free.com" },
                    { "29f06920-d2ad-43d8-b362-e2b94d7a7502", 0, "ea01a7bb-e73f-4752-be72-b83206a812e6", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "atanasov@b-free.com", true, "Atanas", false, false, "Atanasov", false, null, "ATANASOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEHDLnUmBxzvcK97oFVnb/PzKMUeo8BxlvP//KtD0I8njProaAu0WyXVDTemtHAvzow==", "1234567890", false, "Qualitycontrol", "ATANASOV@B-FREE.COM", false, "atanasov@b-free.com" },
                    { "406e8cf1-acaa-44a8-afec-585ff64bed34", 0, "2cbab459-3032-481d-a6f5-a4e476248b5e", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 1, "Employee", "manager@b-free.com", true, "Kalin", false, true, "Kalinov", false, null, "MANAGER@B-FREE.COM", null, "AQAAAAIAAYagAAAAENidGSIdLSZ1874PzzVPlcU76i7sFHldl8qs3vzhtS6KkJ9pMv5+mCsacOsdIJDlIg==", "1234567890", false, "manager", "MANAGER@B-FREE.COM", false, "manager@b-free.com" },
                    { "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", 0, "e7505017-31f2-4b39-954e-866e44bc67eb", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "ivanov@b-free.com", true, "Ivan", false, false, "Ivanov", false, null, "IVANOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEHSjYEzpJImDAlc3l4ZR5aRukFpKnMv/Atu7qA2O28Z1/WoZuZY+DqVA1be8Yhv9Jw==", "1234567890", false, "Accessoriesworker", "IVANOV@B-FREE.COM", false, "ivanov@b-free.com" }
========
                    { "17063948-8fdc-417e-8fb7-2ae6bf572f94", 0, "2c9e1a9c-9970-4af3-9fcc-5e37525294e7", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "todorov@b-free.com", true, "Todor", false, false, "Todorov", false, null, "TODOROV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEBNurX3lplkdMG7rtxZj1t7/IoUurDd7pyfZBvk/NvuOfXSJZB+oPE7eJWgSJ1xh6A==", "1234567890", false, "Wheelworker", "TODOROV@B-FREE.COM", false, "todorov@b-free.com" },
                    { "21003785-a275-4139-ae20-af6a6cf8fea8", 0, "e779b37c-4e4e-4867-aa3f-c9d342fb4dc9", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "marinov@b-free.com", true, "Marin", false, false, "Marinov", false, null, "MARINOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEFIB4jjDGbj864zAaoR87GyxUmwNAMS/Ngx0FGQNEm8O+8Oc291Q44nEgeXutytfKA==", "1234567890", false, "FrameWorker", "MARINOV@B-FREE.COM", false, "marinov@b-free.com" },
                    { "29f06920-d2ad-43d8-b362-e2b94d7a7502", 0, "7dbebd73-03be-4bfe-8432-8c1edc11b011", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "atanasov@b-free.com", true, "Atanas", false, false, "Atanasov", false, null, "ATANASOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEBQY5bXwLFdlNyYTncg0P9d2FwdzREKBGUoMhhndDvDcbZZ4odruxPA2iJryUFCDrA==", "1234567890", false, "Qualitycontrol", "ATANASOV@B-FREE.COM", false, "atanasov@b-free.com" },
                    { "406e8cf1-acaa-44a8-afec-585ff64bed34", 0, "b8e85a0a-12bc-4ea3-9f63-05369666eb86", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 1, "Employee", "manager@b-free.com", true, "Kalin", false, true, "Kalinov", false, null, "MANAGER@B-FREE.COM", null, "AQAAAAIAAYagAAAAEMJUgSQmvGo9WEepqx2hFiT8liEN54H9rDmvKdcuhh76237HAuj2qwYAwJxzw5YbDQ==", "1234567890", false, "manager", "MANAGER@B-FREE.COM", false, "manager@b-free.com" },
                    { "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", 0, "105756f4-2ccf-4a1f-a155-3bfad70ff538", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Employee", "ivanov@b-free.com", true, "Ivan", false, false, "Ivanov", false, null, "IVANOV@B-FREE.COM", null, "AQAAAAIAAYagAAAAEPDOJZTRebeLYRkuDdiuy2EgJColBNGyxaSdMb6d3GzGzwIKs02B/maluYNUHhVnew==", "1234567890", false, "Accessoriesworker", "IVANOV@B-FREE.COM", false, "ivanov@b-free.com" }
>>>>>>>> UI-K:BicycleApp.Data/Migrations/20231227174452_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "DelivaryAddresses",
                columns: new[] { "Id", "Apartment", "Block", "Country", "District", "Floor", "PostCode", "StrNumber", "Street", "TownId" },
                values: new object[,]
                {
                    { 1, null, "20", "Bulgaria", null, null, "1000", "1", "Mladost", 1 },
                    { 2, null, "20", "Bulgaria", "Somewhere over the rainbow", 3, "4000", "13", "Gadost", 2 },
                    { 3, null, null, "Bulgaria", "Near to earth core", 3, "1236", "123", "Ovcha mogila", 3 }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "Discount", "Intend", "IsDeleted", "Name", "OEMNumber", "Quantity", "SalePrice", "Type", "VATCategoryId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best frame in the road!", 10.00m, "For road usage", false, "Frame Road", "oemtest1", 32.0, 100.00m, 1, 1 },
                    { 2, 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best frame in the montain", 0.00m, "For montain usage", false, "Frame Montain", "oemtest2", 43.0, 90.00m, 2, 1 },
                    { 3, 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best frame in the road for womens", 0.00m, "For road usage in women bikes", false, "Frame Road woman", "oemtest3", 32.0, 80.00m, 3, 1 },
                    { 4, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best wheels ever!", 0.00m, "Best wheels for a road usage", false, "Wheel of the Year for road", "oemtest4", 50.0, 75.00m, 1, 1 },
                    { 5, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best wheels for a montain!", 0.00m, "Best wheels for a montain usage", false, "Wheel of the Year for montain", "oemtest5", 40.0, 85.00m, 2, 1 },
                    { 6, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best wheels for a road!", 0.00m, "Best seler for a road usage", false, "Road wheel best seler", "oemtest6", 50.0, 65.00m, 3, 1 },
                    { 7, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Worst shift - have only one!", 0.00m, "Base shift - have only one", false, "Shift", "oemtest7", 29.0, 250.00m, 1, 1 },
                    { 8, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best shifts for a montain!", 0.00m, "Best shift for a montain usage", false, "Montain Shifts", "oemtest8", 19.0, 350.00m, 2, 1 },
                    { 9, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Best shifts for a road!", 0.00m, "Best shift for a road usage", false, "Road Shifts", "oemtest9", 29.0, 400.00m, 3, 1 },
                    { 10, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Better shifts for a road!", 0.00m, "Better shift for a road usage", false, "Road better Shifts", "oemtest10", 21.0, 410.00m, 3, 1 },
                    { 11, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget shifts for a road!", 0.00m, "Budget shift for a road usage", false, "Road budget Shifts", "oemtest11", 21.0, 290.00m, 3, 1 },
                    { 12, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Cheap standard shift!", 0.00m, "Cheap standard shift for a road usage", false, "Shift", "oemtest12", 29.0, 220.00m, 1, 1 },
                    { 13, 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget shifts for a montain!", 0.00m, "Budget shift for a montain usage", false, "Montain Shifts", "oemtest13", 19.0, 280.00m, 2, 1 },
                    { 14, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget wheel ever!", 0.00m, "Budget wheel for a road usage", false, "Budget wheel for road", "oemtest14", 50.0, 65.00m, 1, 1 },
                    { 15, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Budget wheel for a montain!", 0.00m, "Budget wheel for a montain usage", false, "Budget wheel for a montain", "oemtest15", 40.0, 75.00m, 2, 1 },
                    { 16, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "The cheapest wheel for a road!", 0.00m, "The cheapest wheel for a road usage", false, "The cheapest road wheel", "oemtest16", 50.0, 55.00m, 3, 1 },
                    { 17, 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "The best titanium wheel for a road!", 0.00m, "The best titanium wheel for a road usage", false, "Road titanium wheel", "oemtest17", 50.0, 95.00m, 3, 1 },
                    { 18, 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "PartWithHightValueOfDiscountThanSellPrice", 110.00m, "", false, "InvalidPart", "oemtest1", 32.0, 100.00m, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a9618213-7ba0-48cf-81d4-00cd16910ec7", "17063948-8fdc-417e-8fb7-2ae6bf572f94" },
                    { "fa8f997a-4e15-475f-a028-87a9b6e6be56", "21003785-a275-4139-ae20-af6a6cf8fea8" },
                    { "ac558b05-a97b-42c8-bd62-dbd33f36d795", "29f06920-d2ad-43d8-b362-e2b94d7a7502" },
                    { "f0d2cbfa-cdca-4936-9d85-f9a697d39f2b", "406e8cf1-acaa-44a8-afec-585ff64bed34" },
                    { "566110d3-06fe-4ca2-b34b-9334a842c88f", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "DateCreated", "DateDeleted", "DateUpdated", "DelivaryAddressId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IBAN", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TownId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BicycleApp.Data/Migrations/20240101142728_Initial.cs
                    { "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", 0, 50.00m, "d0c01788-7748-4b93-8ebc-05fe982c66f0", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Client", "joro@test.bg", true, "Georgi", "BG0012345678910111212", false, "Georgiev", false, null, "JORO@TEST.BG", null, "AQAAAAIAAYagAAAAEHWsleb9BQEfcxxdVPo3SIQn4/1gLMuk/cjiUkmgOpyNw5K6pQNIaUT5HEtp26HmxQ==", "1234567890", false, "JORO@TEST.BG", 2, false, "joro@test.bg" },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 0, 1246.00m, "6e23cf4e-54fd-4ddf-a003-78040f4ada49", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 3, "Client", "powerranger@test.bg", true, "Dimityr", "BG0012345678910111212", false, "Dimitrov", false, null, "POWERRANGER@TEST.BG", null, "AQAAAAIAAYagAAAAEPBBOKlAK5hrgucSBkUKDksK8sklEMxLvveLbUIX4K7jfQt8j9IXC6ymq31sS9Qm8g==", "1234567890", false, "POWERRANGER@TEST.BG", 3, false, "powerranger@test.bg" },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 0, 1000.00m, "641a158d-3579-4271-9219-c34e81299d54", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 1, "Client", "client@test.bg", true, "Ivan", "BG0012345678910111212", false, "Ivanov", false, null, "CLIENT@TEST.BG", null, "AQAAAAIAAYagAAAAEKvQHFrOaddoSIkDJf0i2/x9oq923dPwcQ1M0aA9H1r91CYcRZZNAAu4TKBvV9e2Vg==", "1234567890", false, "CLIENT@TEST.BG", 1, false, "client@test.bg" }
========
                    { "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", 0, 50.00m, "76e95c52-d8ac-483b-8a2c-dbbea718ba76", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 2, "Client", "joro@test.bg", true, "Georgi", "BG0012345678910111212", false, "Georgiev", false, null, "JORO@TEST.BG", null, "AQAAAAIAAYagAAAAEGx52aeL/A+akeXOnu5E4lEjTP7FpaGUArZGqFr0C9V4cOofbCxyS/zh6ScAUexbDQ==", "1234567890", false, "JORO@TEST.BG", 2, false, "joro@test.bg" },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 0, 1246.00m, "813ec0f0-d8dd-4517-a7aa-29d95b9c2af8", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 3, "Client", "powerranger@test.bg", true, "Dimityr", "BG0012345678910111212", false, "Dimitrov", false, null, "POWERRANGER@TEST.BG", null, "AQAAAAIAAYagAAAAEEilbZ+hThkBow305Z+G6q9HSvn0GHQnpU7Bz5QNQVDkabFdhLY5EPqDfPtSRrqFdA==", "1234567890", false, "POWERRANGER@TEST.BG", 3, false, "powerranger@test.bg" },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 0, 1000.00m, "e8a361a9-9ed2-4fef-b634-e439b8cd1516", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, 1, "Client", "client@test.bg", true, "Ivan", "BG0012345678910111212", false, "Ivanov", false, null, "CLIENT@TEST.BG", null, "AQAAAAIAAYagAAAAEFcfl5jytQtn1/5pXk8B4WwHfVSqtTBjdPAkRLeYcobu1DHNLlI650BJJfECYGJ6Ew==", "1234567890", false, "CLIENT@TEST.BG", 1, false, "client@test.bg" }
>>>>>>>> UI-K:BicycleApp.Data/Migrations/20231227174452_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "BikeModelsParts",
                columns: new[] { "BikeModelId", "PartId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 3, 5 },
                    { 1, 9 },
                    { 2, 12 },
                    { 3, 13 },
                    { 2, 14 }
                });

            migrationBuilder.InsertData(
                table: "Delivaries",
                columns: new[] { "Id", "DateDeleted", "DateDelivered", "DateUpdated", "IsDeleted", "Note", "PartId", "QuantityDelivered", "SuplierId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text", 1, 2.0, 1 },
                    { 2, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text2", 4, 2.0, 2 },
                    { 3, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text2", 7, 1.0, 3 },
                    { 4, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text4", 1, 4.0, 1 },
                    { 5, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text5", 4, 4.0, 2 },
                    { 6, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text6", 7, 2.0, 3 },
                    { 7, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text7", 1, 3.0, 1 },
                    { 8, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text8", 4, 5.0, 2 },
                    { 9, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), false, "text9", 7, 4.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "ImagesEmployees",
                columns: new[] { "Id", "ImageName", "ImageUrl", "IsDeleted", "UserId" },
                values: new object[] { 1, "image", "test", false, "21003785-a275-4139-ae20-af6a6cf8fea8" });

            migrationBuilder.InsertData(
                table: "ImagesParts",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "ImageName", "ImageUrl", "IsDeleted", "PartId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Frame Road", "https://yuchormanski.free.bg/bikes/frame1.webp", false, 1 },
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

            migrationBuilder.InsertData(
                table: "PartOrders",
                columns: new[] { "Id", "DateCreated", "DateDeleted", "DateUpdated", "IsDeleted", "Note", "PartId", "PartId1", "Quantity", "SuplierId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "text", 1, null, 2, 1 },
                    { 2, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "text2", 4, null, 2, 2 },
                    { 3, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 11, 10, 0, 0, DateTimeKind.Unspecified), false, "text2", 7, null, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f" },
                    { "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", "99d3ca6f-2067-4316-a5d7-934c93789521" },
                    { "6ac1cb3c-2457-4aff-8fa2-c7052ebcea9e", "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateUpdated", "Description", "IsDeleted", "PartId", "Title" },
                values: new object[] { 1, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, "Test Description", false, 1, "Test Title" });

            migrationBuilder.InsertData(
                table: "ImagesClients",
                columns: new[] { "Id", "ImageName", "ImageUrl", "UserId" },
                values: new object[] { 1, "image", "test", "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd" });

            migrationBuilder.InsertData(
                table: "Orders",
<<<<<<<< HEAD:BicycleApp.Data/Migrations/20240101142728_Initial.cs
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateFinish", "DateSended", "DateUpdated", "Description", "Discount", "FinalAmount", "IsDeleted", "PaidAmount", "SaleAmount", "StatusId", "UnpaidAmount", "VAT" },
                values: new object[,]
                {
                    { 1, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "", 0m, 750.00m, false, 0m, 625.00m, 2, 750.00m, 125.00m },
                    { 2, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test2", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 3, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test3", 0m, 950.00m, false, 0m, 825.00m, 1, 750.00m, 125.00m },
                    { 4, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test4", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 5, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test5", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 6, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test6", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m },
                    { 7, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test7", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 8, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test8", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 9, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test9", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m },
                    { 10, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "Passed quality control", 0m, 425.00m, false, 0m, 354.17m, 6, 0m, 70.83m }
========
                columns: new[] { "Id", "ClientId", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "Description", "Discount", "FinalAmount", "IsDeleted", "PaidAmount", "SaleAmount", "StatusId", "UnpaidAmount", "VAT" },
                values: new object[,]
                {
                    { 1, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "", 0m, 750.00m, false, 0m, 625.00m, 1, 750.00m, 125.00m },
                    { 2, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test2", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 3, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test3", 0m, 950.00m, false, 0m, 825.00m, 1, 750.00m, 125.00m },
                    { 4, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test4", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 5, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test5", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 6, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test6", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m },
                    { 7, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test7", 0m, 650.00m, false, 0m, 525.00m, 1, 750.00m, 125.00m },
                    { 8, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test8", 0m, 850.00m, false, 0m, 725.00m, 1, 850.00m, 125.00m },
                    { 9, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "test9", 0m, 850.00m, false, 0m, 525.00m, 1, 650.00m, 125.00m },
                    { 10, "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), null, null, null, "Passed quality control", 0m, 425.00m, false, 0m, 354.17m, 1, 0m, 70.83m }
>>>>>>>> UI-K:BicycleApp.Data/Migrations/20231227174452_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "Rates",
                columns: new[] { "ClientId", "PartId", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "IsDeleted", "Rating" },
                values: new object[,]
                {
                    { "17ce735d-6713-4d0a-8fcb-e4a71ee86f6f", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 6 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 6 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 6 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 4 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 5 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 },
                    { "99d3ca6f-2067-4316-a5d7-934c93789521", 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 2 },
                    { "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd", 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployees",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber", "DateCreated", "DateDeleted", "DateFinish", "DateUpdated", "DatetimeAsigned", "Description", "EmployeeId", "EndDatetime", "IsCompleted", "IsDeleted", "PartName", "PartPrice", "PartQuantity", "SerialNumber", "StartDatetime" },
                values: new object[,]
                {
                    { 1, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), "test", "21003785-a275-4139-ae20-af6a6cf8fea8", null, false, false, "Frame OG", 100.00m, 1.0, "BID12345678", null },
                    { 1, 2, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), "test", "17063948-8fdc-417e-8fb7-2ae6bf572f94", null, false, false, "Wheel of the YearG", 75.00m, 2.0, "BID12345678", null },
                    { 1, 3, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 10, 10, 10, 10, 0, 0, DateTimeKind.Unspecified), "test", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", null, false, false, "Shift", 250.00m, 1.0, "BID12345678", null },
                    { 2, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345679", null },
                    { 2, 4, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for road", 75.00m, 1.0, "BID12345679", null },
                    { 2, 12, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Shift", 220.00m, 1.0, "BID12345679", null },
                    { 3, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 3, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 3, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 4, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 4, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 4, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 5, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 5, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 5, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 6, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 6, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 6, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 7, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 7, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 7, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 8, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 8, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 8, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 9, 1, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Frame OG", 100.00m, 1.0, "BID12345680", null },
                    { 9, 5, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Wheel of the Year for montain", 85.00m, 1.0, "BID12345680", null },
                    { 9, 11, "7d47ca5c-ef3a-4bc0-a8af-f024464e27eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "test", null, null, false, false, "Road budget Shifts", 290.00m, 1.0, "BID12345680", null },
                    { 10, 1, "231b3632-b31c-4711-8f67-fe42b36642b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 12, 16, 15, 48, 13, 0, DateTimeKind.Unspecified), "test", "21003785-a275-4139-ae20-af6a6cf8fea8", new DateTime(2023, 12, 16, 16, 53, 13, 0, DateTimeKind.Unspecified), true, false, "Frame OG", 100.00m, 1.0, "BIDPASQC123", new DateTime(2023, 12, 16, 16, 48, 13, 0, DateTimeKind.Unspecified) },
                    { 10, 2, "231b3632-b31c-4711-8f67-fe42b36642b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 12, 16, 15, 48, 13, 0, DateTimeKind.Unspecified), "test", "17063948-8fdc-417e-8fb7-2ae6bf572f94", new DateTime(2023, 12, 17, 9, 15, 13, 0, DateTimeKind.Unspecified), true, false, "Wheel of the YearG", 75.00m, 1.0, "BIDPASQC123", new DateTime(2023, 12, 17, 9, 10, 13, 0, DateTimeKind.Unspecified) },
                    { 10, 3, "231b3632-b31c-4711-8f67-fe42b36642b5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(2023, 12, 16, 15, 48, 13, 0, DateTimeKind.Unspecified), "test", "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91", new DateTime(2023, 12, 17, 10, 30, 13, 0, DateTimeKind.Unspecified), true, false, "Shift", 250.00m, 1.0, "BIDPASQC123", new DateTime(2023, 12, 17, 10, 15, 13, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "Id", "DescriptionForWorker", "OrderId", "PartId", "ProductionТime", "UniqueKeyForSerialNumber" },
                values: new object[,]
                {
                    { 1, null, 10, 1, new TimeSpan(0, 0, 5, 0, 0), "231b3632-b31c-4711-8f67-fe42b36642b5" },
                    { 2, null, 10, 2, new TimeSpan(0, 0, 5, 0, 0), "231b3632-b31c-4711-8f67-fe42b36642b5" },
                    { 3, null, 10, 3, new TimeSpan(0, 0, 15, 0, 0), "231b3632-b31c-4711-8f67-fe42b36642b5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DelivaryAddressId",
                table: "AspNetUsers",
                column: "DelivaryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TownId",
                table: "AspNetUsers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BikeModelsParts_BikeModelId",
                table: "BikeModelsParts",
                column: "BikeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClientId",
                table: "Comments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PartId",
                table: "Comments",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_CompatablePartPart_PartsId",
                table: "CompatablePartPart",
                column: "PartsId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivaries_PartId",
                table: "Delivaries",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Delivaries_SuplierId",
                table: "Delivaries",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_DelivaryAddresses_TownId",
                table: "DelivaryAddresses",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesClients_UserId",
                table: "ImagesClients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesEmployees_UserId",
                table: "ImagesEmployees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesParts_PartId",
                table: "ImagesParts",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPartsEmployees_EmployeeId",
                table: "OrdersPartsEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPartsEmployees_PartId",
                table: "OrdersPartsEmployees",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersPartsEmployeesInfos_OrderId_PartId_UniqueKeyForSerialNumber",
                table: "OrdersPartsEmployeesInfos",
                columns: new[] { "OrderId", "PartId", "UniqueKeyForSerialNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_PartOrders_PartId",
                table: "PartOrders",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_PartOrders_PartId1",
                table: "PartOrders",
                column: "PartId1");

            migrationBuilder.CreateIndex(
                name: "IX_PartOrders_SuplierId",
                table: "PartOrders",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_CategoryId",
                table: "Parts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Parts_VATCategoryId",
                table: "Parts",
                column: "VATCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PartsInStock_SuplierId",
                table: "PartsInStock",
                column: "SuplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ClientId",
                table: "Rates",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BikeModelsParts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CompatablePartPart");

            migrationBuilder.DropTable(
                name: "Delivaries");

            migrationBuilder.DropTable(
                name: "ImagesClients");

            migrationBuilder.DropTable(
                name: "ImagesEmployees");

            migrationBuilder.DropTable(
                name: "ImagesParts");

            migrationBuilder.DropTable(
                name: "OrdersPartsEmployeesInfos");

            migrationBuilder.DropTable(
                name: "PartOrders");

            migrationBuilder.DropTable(
                name: "PartsInStock");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BikesStandartModels");

            migrationBuilder.DropTable(
                name: "CompatableParts");

            migrationBuilder.DropTable(
                name: "OrdersPartsEmployees");

            migrationBuilder.DropTable(
                name: "Supliers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "PartCategories");

            migrationBuilder.DropTable(
                name: "VATCategories");

            migrationBuilder.DropTable(
                name: "DelivaryAddresses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
