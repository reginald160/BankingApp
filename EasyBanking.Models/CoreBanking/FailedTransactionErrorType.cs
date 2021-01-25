using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public class FailedTransactionErrorType : AdminBaseModel
    {
        [Display(Name = "Failed Transaction description")]
        public string FailedTransDecription { get; set; }
    }
}
