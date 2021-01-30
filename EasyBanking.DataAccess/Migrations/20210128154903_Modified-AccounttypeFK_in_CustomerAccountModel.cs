using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class ModifiedAccounttypeFK_in_CustomerAccountModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "CustomersAccounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "CustomersAccounts",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
