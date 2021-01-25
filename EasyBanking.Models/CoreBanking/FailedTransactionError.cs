using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
   public  class FailedTransactionError : AdminBaseModel
    {
        public FailedTransactionError()
        {
            FailedTransErrorTime = DateTime.UtcNow;
        }

        [Display(Name = "Failed Transaction Erro time")]
        public DateTime FailedTransErrorTime { get; set; }
        [Display(Name = "Error type")]
        public Guid FailedTransactionErrorTypeId { get; set; }

        [ForeignKey("FailedTransactionErrorTypeId")]

        public virtual FailedTransactionErrorType FailedTransactionErrorType { get; set; }

        public string FailedTransactionErrorXML { get; set; }
    }
}
