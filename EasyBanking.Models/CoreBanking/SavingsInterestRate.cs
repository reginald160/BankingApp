using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public  class SavingsInterestRate : AdminBaseModel
    {
        [Display(Name ="Interest Value")]
        public decimal InterestRateValue { get; set; }

        [Display(Name = "Interest Description")]
        public string InterestDescription { get; set; }
    }
}
