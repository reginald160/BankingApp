using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class Added_DesignitionTo_Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberSequences",
                keyColumn: "Id",
                keyValue: new Guid("c06ff54b-c717-4be1-b717-88afa6c51863"));

            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "Id", "Deleted", "LastNumber", "Module", "NumberSequenceName", "Prefix" },
                values: new object[] { new Guid("eb55adfb-2114-4edd-bdc9-0e0fd2f54c2a"), false, 0, "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberSequences",
                keyColumn: "Id",
                keyValue: new Guid("eb55adfb-2114-4edd-bdc9-0e0fd2f54c2a"));

            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "Id", "Deleted", "LastNumber", "Module", "NumberSequenceName", "Prefix" },
                values: new object[] { new Guid("c06ff54b-c717-4be1-b717-88afa6c51863"), false, 0, "", "", "" });
        }
    }
}
