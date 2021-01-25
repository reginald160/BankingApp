using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
   public  class TransactionLog : AdminBaseModel
    {
        [Display(Name ="Transaction Date")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Transaction Amount")]
        public DateTime TransactionAmount { get; set; }

        public Guid TransactionTypeId { get; set; }

        [ForeignKey("TransactionTypeId")]
        public virtual TransactionType TransactionType { get; set; }

        [Display(Name = "New Balance")]
        public decimal NewBalance { get; set; }

        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        public Guid CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public Guid EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee  Employee { get; set; }

        public Guid UserLoginId { get; set; }

        [ForeignKey("UserLoginId")]
        public virtual UserLogins UserLogin { get; set; }


    }
}
