using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d813351-b533-44b2-839a-e312cde3ace9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a29f9ea-9fda-4265-a26c-64206a83120d", "8d6d8b18-681f-4c42-8ba0-cb89e10634ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a29f9ea-9fda-4265-a26c-64206a83120d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d6d8b18-681f-4c42-8ba0-cb89e10634ae");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0d813351-b533-44b2-839a-e312cde3ace9", "58c4ad7d-9b8a-4efa-92b0-bdf4c523e6e4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a29f9ea-9fda-4265-a26c-64206a83120d", "b599a936-e33e-4885-a175-d2689a72194d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8d6d8b18-681f-4c42-8ba0-cb89e10634ae", 0, "c38e01f9-7d19-492e-94e3-7aa0f914a2b4", new DateTime(2022, 9, 23, 16, 16, 17, 306, DateTimeKind.Local).AddTicks(2951), "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBNlJkTh+ejp/FUtrEgQQsgF+ABZMnnk7bx42zqU0o2CoO97FFXcMU7i9DGP9uPtPQ==", null, false, "e71f5abb-9bc4-4969-b055-f94b3495ebfc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2a29f9ea-9fda-4265-a26c-64206a83120d", "8d6d8b18-681f-4c42-8ba0-cb89e10634ae" });
        }
    }
}
