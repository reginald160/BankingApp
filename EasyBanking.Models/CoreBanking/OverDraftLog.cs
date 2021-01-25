using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public class OverDraftLog : AdminBaseModel
    {
        public DateTime OverDraftDate { get; set; }
        public decimal OverDraftAmount { get; set; }
        public string OverDraftTransactionXML { get; set; }

        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
