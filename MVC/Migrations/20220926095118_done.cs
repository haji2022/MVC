using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    public partial class done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18f453ce-f203-4b20-934f-b6477da312c0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c29fcfb-f7df-4e0b-99e9-3066c8d1df5b", "09564331-7481-4f79-9e93-f9fb18edead2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c29fcfb-f7df-4e0b-99e9-3066c8d1df5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09564331-7481-4f79-9e93-f9fb18edead2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55be49b8-e634-41cb-affb-c6f63b461f3a", "b0a74be5-ec09-4562-a0c9-db7a9fc0417c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3ece90b-96bc-4311-a4fe-e1d2b156bd56", "f7baf3aa-ce51-4c76-927d-cbb216ba87a4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7a4ff6c0-dc31-458b-a442-bb1239fe4b31", 0, "65da8c65-db35-48de-a335-1a3a66ad60fa", new DateTime(2022, 9, 26, 11, 51, 17, 339, DateTimeKind.Local).AddTicks(194), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELqOFgHgMqZIZZ8IQE6PdUT/QYP7fRNNAESqCd7dGdjuzBmjU/LrGWDwnSwJPOcVJg==", null, false, "dc877ac1-eb33-49ff-9ba7-4d490628c00b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3ece90b-96bc-4311-a4fe-e1d2b156bd56", "7a4ff6c0-dc31-458b-a442-bb1239fe4b31" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55be49b8-e634-41cb-affb-c6f63b461f3a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3ece90b-96bc-4311-a4fe-e1d2b156bd56", "7a4ff6c0-dc31-458b-a442-bb1239fe4b31" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3ece90b-96bc-4311-a4fe-e1d2b156bd56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a4ff6c0-dc31-458b-a442-bb1239fe4b31");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18f453ce-f203-4b20-934f-b6477da312c0", "425291db-51d6-4488-8484-0b970727cf02", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c29fcfb-f7df-4e0b-99e9-3066c8d1df5b", "ba01c6dc-7d7b-4814-85ad-a3b732233aad", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "09564331-7481-4f79-9e93-f9fb18edead2", 0, "80c913bd-6971-4980-ae65-37a6b7dba0e1", new DateTime(2022, 9, 24, 2, 20, 1, 937, DateTimeKind.Local).AddTicks(3437), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKjwQssUf9of2GdP6P54x9JQCg5MIzK2VHd4hVQwrpe7VVxfMiL6DKMMJU2EaQXFWQ==", null, false, "f5f907e5-6f36-4475-b83c-fd293810d1ab", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c29fcfb-f7df-4e0b-99e9-3066c8d1df5b", "09564331-7481-4f79-9e93-f9fb18edead2" });
        }
    }
}
