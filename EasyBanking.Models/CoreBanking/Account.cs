using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public class Account : AdminBaseModel
    {
        public decimal CurrentBallance { get; set; }
        public Guid AccountTypeId { get; set; }

        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }

        public Guid AccountStatusId { get; set; }

        [ForeignKey("AccountStatusId")]
        public virtual AccountStatus AccountStatus { get; set; }

        public Guid SavingsInterestRateId { get; set; }

        [ForeignKey("SavingsInterestRateId")]
        public virtual SavingsInterestRate SavingsInterestRate { get; set; }


    }
}
