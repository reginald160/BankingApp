using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.ViewModels.InterestRateViewModels
{
    public class SavingsInterestRateViewModel : AdminBaseViewModel
    {
        [Display(Name = "Interest Value"), DataType(DataType.Currency)]
        public decimal InterestRateValue { get; set; }

        [Display(Name = "Interest Description"), Required]
        public string InterestDescription { get; set; }
    }
}
