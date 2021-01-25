using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class Added_DesignitionTo_Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberSequences",
                keyColumn: "Id",
                keyValue: new Guid("bd5d96c2-586a-425c-9c15-9f18ab4b24e5"));

            migrationBuilder.AlterColumn<int>(
                name: "Designation",
                table: "Employees",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<bool>(
                name: "ActivityStatus",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "Id", "Deleted", "LastNumber", "Module", "NumberSequenceName", "Prefix" },
                values: new object[] { new Guid("c06ff54b-c717-4be1-b717-88afa6c51863"), false, 0, "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberSequences",
                keyColumn: "Id",
                keyValue: new Guid("c06ff54b-c717-4be1-b717-88afa6c51863"));

            migrationBuilder.DropColumn(
                name: "ActivityStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "Designation",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "Id", "Deleted", "LastNumber", "Module", "NumberSequenceName", "Prefix" },
                values: new object[] { new Guid("bd5d96c2-586a-425c-9c15-9f18ab4b24e5"), false, 0, "", "", "" });
        }
    }
}
