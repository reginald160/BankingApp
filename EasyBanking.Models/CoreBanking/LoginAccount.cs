using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
   public   class LoginAccount : AdminBaseModel
    {
        public Guid UserLoginId { get; set; }

        [ForeignKey("UserLoginId")]
        public virtual UserLogins UserLogin { get; set; }

        public Guid AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
