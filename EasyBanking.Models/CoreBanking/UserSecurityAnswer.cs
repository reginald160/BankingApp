using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EasyBanking.Models.CoreBanking
{
    public class UserSecurityAnswer : AdminBaseModel
    {
        public string Answer { get; set; }
        public Guid UserSecurityQuestionId { get; set; }

        [ForeignKey("UserSecurityQuestionId")]
        public virtual UserSecurityQuestion Question { get; set; }

        public Guid UserLoginId { get; set; }

        [ForeignKey("UserLoginId")]
        public virtual UserLogins UserLogin { get; set; }
    
    }
}
