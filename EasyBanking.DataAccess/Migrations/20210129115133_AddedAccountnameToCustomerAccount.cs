using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class AddedAccountnameToCustomerAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountName",
                table: "CustomersAccounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountName",
                table: "CustomersAccounts");
        }
    }
}
