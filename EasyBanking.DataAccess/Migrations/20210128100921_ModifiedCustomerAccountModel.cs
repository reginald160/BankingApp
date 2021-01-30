using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class ModifiedCustomerAccountModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAccounts_Accounts_AccountId",
                table: "CustomersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAccounts_Customers_CustomerId",
                table: "CustomersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomersAccounts_AccountId",
                table: "CustomersAccounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "CustomersAccounts",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AccountId",
                table: "CustomersAccounts",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<decimal>(
                name: "AccountBalance",
                table: "CustomersAccounts",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "AccountStatus",
                table: "CustomersAccounts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AccountTypeId",
                table: "CustomersAccounts",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SavingsInterestRateId",
                table: "CustomersAccounts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAccounts_AccountTypeId",
                table: "CustomersAccounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAccounts_SavingsInterestRateId",
                table: "CustomersAccounts",
                column: "SavingsInterestRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAccounts_AccountTypes_AccountTypeId",
                table: "CustomersAccounts",
                column: "AccountTypeId",
                principalTable: "AccountTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAccounts_Customers_CustomerId",
                table: "CustomersAccounts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAccounts_SavingsInterestRates_SavingsInterestRateId",
                table: "CustomersAccounts",
                column: "SavingsInterestRateId",
                principalTable: "SavingsInterestRates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAccounts_AccountTypes_AccountTypeId",
                table: "CustomersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAccounts_Customers_CustomerId",
                table: "CustomersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomersAccounts_SavingsInterestRates_SavingsInterestRateId",
                table: "CustomersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomersAccounts_AccountTypeId",
                table: "CustomersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomersAccounts_SavingsInterestRateId",
                table: "CustomersAccounts");

            migrationBuilder.DropColumn(
                name: "AccountBalance",
                table: "CustomersAccounts");

            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "CustomersAccounts");

            migrationBuilder.DropColumn(
                name: "AccountTypeId",
                table: "CustomersAccounts");

            migrationBuilder.DropColumn(
                name: "SavingsInterestRateId",
                table: "CustomersAccounts");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "CustomersAccounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AccountId",
                table: "CustomersAccounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAccounts_AccountId",
                table: "CustomersAccounts",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAccounts_Accounts_AccountId",
                table: "CustomersAccounts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomersAccounts_Customers_CustomerId",
                table: "CustomersAccounts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
