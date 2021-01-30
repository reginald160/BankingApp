using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
   public class CustomerAccount : AdminBaseModel
    {
        public Guid? AccountTypeId { get; set; }

        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }
        public Guid? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public Guid? SavingsInterestRateId { get; set; }

        [ForeignKey("SavingsInterestRateId")]
        public virtual SavingsInterestRate SavingsInterestRate { get; set; }
        public long AccountNumber { get; set; }

        public string AccountName { get; set; }
     

        public AccountStatusDescription AccountStatus { get; set; }
        [DataType(DataType.Currency)]
        public decimal AccountBalance { get; set; }
        [NotMapped]
        public TransactionCategory TransactionType { get; set; }

        [NotMapped]
        public decimal CashPanel { get; set; }

        [NotMapped]
        public Guid TempId { get; set; }



    }
}
