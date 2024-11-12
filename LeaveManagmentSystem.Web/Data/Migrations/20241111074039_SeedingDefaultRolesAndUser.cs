using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34cead93-0c51-4f32-81bf-862146329086", null, "Employee", "EMPLOYEE" },
                    { "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8", null, "Administrator", "ADMINISTRATOR" },
                    { "a959a7bd-d272-43b2-bfe3-20da89081dc3", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e", 0, "3f917fde-8b66-432e-955b-52ad3562c7ac", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDm2Lut6BOORcRv/i8+qqPS6eXoMbOxCUQeTLYPFggZTjYAW812x7Q3o1qlJrjIB5A==", null, false, "0d34e5ee-e811-4363-9411-9cbf79e881b3", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8", "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34cead93-0c51-4f32-81bf-862146329086");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a959a7bd-d272-43b2-bfe3-20da89081dc3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8", "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4d3ecb7-1ea0-4e40-bc5a-fdc516bfbad8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e");
        }
    }
}
