using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
   public class LoginErrorLog : AdminBaseModel
    {
        public LoginErrorLog()
        {
            FailedTransErrorTime = DateTime.UtcNow;
        }
        [Display(Name = "Failed Transaction Erro time")]
        public DateTime FailedTransErrorTime { get; set; }
        public string FailedTransactionErrorXML { get; set; }

    }
}
