using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.BankingHallViewModels
{
    public class CashierViewModel: AdminBaseViewModel
    {
        public Guid AccountTypeId { get; set; }
        public Guid? CustomerId { get; set; }

        public Guid? SavingsInterestRateId { get; set; }

        public long AccountNumber { get; set; }

        public string AccountName { get; set; }


        [DataType(DataType.Currency)]
        public decimal AccountBalance { get; set; }
     
        public TransactionCategory TransactionType { get; set; }

      
        public decimal CashPanel { get; set; }

        public Guid TempId { get; set; }

    }
}
