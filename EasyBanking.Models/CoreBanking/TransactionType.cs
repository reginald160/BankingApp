using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
    public class TransactionType : AdminBaseModel
    {
        public TransactionTypeDescription Transaction { get; set; }

        [Display(Name ="Transaction Description")]
        public string TransactionDescription { get; set; }

        [Display(Name = "Transaction Fee")]
        public string TransactionFeeAmount { get; set; }

    }
}
