using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class Numbersequence_SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NumberSequences",
                columns: new[] { "Id", "Deleted", "LastNumber", "Module", "NumberSequenceName", "Prefix" },
                values: new object[] { new Guid("bd5d96c2-586a-425c-9c15-9f18ab4b24e5"), false, 0, "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NumberSequences",
                keyColumn: "Id",
                keyValue: new Guid("bd5d96c2-586a-425c-9c15-9f18ab4b24e5"));
        }
    }
}
