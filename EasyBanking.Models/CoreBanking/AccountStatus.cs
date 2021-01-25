
using System;
using System.Collections.Generic;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
    public class AccountStatus : AdminBaseModel
    {
        public AccountStatusDescription AccountStatusDescription { get; set; }
       
    }
}
