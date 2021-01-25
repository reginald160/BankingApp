using EasyBanking.DataAccess.Data;
using EasyBanking.Models;
using EasyBanking.Models.CoreBanking;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountStatus> AccountStatuses { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerAccount> CustomersAccounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FailedTransactionError> FailedTransactionErrors { get; set; }
        public DbSet<FailedTransactionErrorType> FailedTransactionErrorTypes { get; set; }
        public DbSet<LoginAccount> LoginAccounts { get; set; }
        public DbSet<LoginErrorLog> LoginErrorLogs { get; set; }
        public DbSet<NumberSequence> NumberSequences { get; set; }

        public DbSet<OverDraftLog> OverDraftLogs { get; set; }
        public DbSet<SavingsInterestRate> SavingsInterestRates { get; set; }
        public DbSet<TransactionLog> TransactionLogs { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<UserLogins> UserLogin { get; set; }
        public DbSet<UserSecurityAnswer> UserSecurityAnswers { get; set; }
        public DbSet<UserSecurityQuestion> UserSecurityQuestions { get; set; }
    }
}
