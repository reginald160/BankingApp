using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public  class SavingsInterestRate : AdminBaseModel
    {
        public decimal InterestRateValue { get; set; }
        public string InterestDescription { get; set; }
    }
}
