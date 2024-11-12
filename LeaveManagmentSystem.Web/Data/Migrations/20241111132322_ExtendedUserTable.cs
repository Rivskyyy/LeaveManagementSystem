using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagmentSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baad8b8e-d915-4148-9b29-bcac127b62b4", new DateOnly(2000, 12, 12), "Default", "Admin", "AQAAAAIAAYagAAAAEAbKTKHTgfJynCzzqrNunxyN1TyZNUHe4FVLP/2dkXVNsFlD61e5SQLwAf5F8dyCyQ==", "ea6580aa-85c5-44e3-bc49-d9db5c7aa2d9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca89511a-f9ce-45af-8d7e-a2a3cf47cf8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f917fde-8b66-432e-955b-52ad3562c7ac", "AQAAAAIAAYagAAAAEDm2Lut6BOORcRv/i8+qqPS6eXoMbOxCUQeTLYPFggZTjYAW812x7Q3o1qlJrjIB5A==", "0d34e5ee-e811-4363-9411-9cbf79e881b3" });
        }
    }
}
