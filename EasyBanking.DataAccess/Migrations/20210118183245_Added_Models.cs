using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyBanking.DataAccess.Migrations
{
    public partial class Added_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "AccountStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountStatusDescription = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountTypeDescription = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    StaffCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailedTransactionErrorTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FailedTransDecription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedTransactionErrorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoginErrorLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FailedTransErrorTime = table.Column<DateTime>(nullable: false),
                    FailedTransactionErrorXML = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginErrorLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingsInterestRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InterestRateValue = table.Column<decimal>(nullable: false),
                    InterestDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingsInterestRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Transaction = table.Column<int>(nullable: false),
                    TransactionDescription = table.Column<string>(nullable: true),
                    TransactionFeeAmount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserLoginId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSecurityQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Question = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecurityQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FailedTransactionErrors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FailedTransErrorTime = table.Column<DateTime>(nullable: false),
                    FailedTransactionErrorTypeId = table.Column<Guid>(nullable: false),
                    FailedTransactionErrorXML = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FailedTransactionErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FailedTransactionErrors_FailedTransactionErrorTypes_FailedTransactionErrorTypeId",
                        column: x => x.FailedTransactionErrorTypeId,
                        principalTable: "FailedTransactionErrorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CurrentBallance = table.Column<decimal>(nullable: false),
                    AccountTypeId = table.Column<Guid>(nullable: false),
                    AccountStatusId = table.Column<Guid>(nullable: false),
                    SavingsInterestRateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountStatuses_AccountStatusId",
                        column: x => x.AccountStatusId,
                        principalTable: "AccountStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountTypes_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_SavingsInterestRates_SavingsInterestRateId",
                        column: x => x.SavingsInterestRateId,
                        principalTable: "SavingsInterestRates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DOB = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CellPhone = table.Column<string>(nullable: true),
                    BVN = table.Column<string>(nullable: true),
                    IdentificationType = table.Column<int>(nullable: false),
                    IdentificationNum = table.Column<string>(nullable: true),
                    UserLoginId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSecurityAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    UserSecurityQuestionId = table.Column<Guid>(nullable: false),
                    UserLoginId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecurityAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecurityAnswers_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSecurityAnswers_UserSecurityQuestions_UserSecurityQuestionId",
                        column: x => x.UserSecurityQuestionId,
                        principalTable: "UserSecurityQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserLoginId = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginAccounts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoginAccounts_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OverDraftLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OverDraftDate = table.Column<DateTime>(nullable: false),
                    OverDraftAmount = table.Column<decimal>(nullable: false),
                    OverDraftTransactionXML = table.Column<string>(nullable: true),
                    AccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverDraftLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OverDraftLogs_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomersAccounts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersAccounts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    TransactionAmount = table.Column<DateTime>(nullable: false),
                    TransactionTypeId = table.Column<Guid>(nullable: false),
                    NewBalance = table.Column<decimal>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    UserLoginId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_TransactionTypes_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_UserLogin_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "UserLogin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountStatusId",
                table: "Accounts",
                column: "AccountStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SavingsInterestRateId",
                table: "Accounts",
                column: "SavingsInterestRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserLoginId",
                table: "Customers",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAccounts_AccountId",
                table: "CustomersAccounts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersAccounts_CustomerId",
                table: "CustomersAccounts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_FailedTransactionErrors_FailedTransactionErrorTypeId",
                table: "FailedTransactionErrors",
                column: "FailedTransactionErrorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginAccounts_AccountId",
                table: "LoginAccounts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_LoginAccounts_UserLoginId",
                table: "LoginAccounts",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_OverDraftLogs_AccountId",
                table: "OverDraftLogs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_AccountId",
                table: "TransactionLogs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_CustomerId",
                table: "TransactionLogs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_EmployeeId",
                table: "TransactionLogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransactionTypeId",
                table: "TransactionLogs",
                column: "TransactionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_UserLoginId",
                table: "TransactionLogs",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecurityAnswers_UserLoginId",
                table: "UserSecurityAnswers",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecurityAnswers_UserSecurityQuestionId",
                table: "UserSecurityAnswers",
                column: "UserSecurityQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersAccounts");

            migrationBuilder.DropTable(
                name: "FailedTransactionErrors");

            migrationBuilder.DropTable(
                name: "LoginAccounts");

            migrationBuilder.DropTable(
                name: "LoginErrorLogs");

            migrationBuilder.DropTable(
                name: "OverDraftLogs");

            migrationBuilder.DropTable(
                name: "TransactionLogs");

            migrationBuilder.DropTable(
                name: "UserSecurityAnswers");

            migrationBuilder.DropTable(
                name: "FailedTransactionErrorTypes");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "TransactionTypes");

            migrationBuilder.DropTable(
                name: "UserSecurityQuestions");

            migrationBuilder.DropTable(
                name: "AccountStatuses");

            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "SavingsInterestRates");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
