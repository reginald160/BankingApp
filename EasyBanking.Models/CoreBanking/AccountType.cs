using System;
using System.Collections.Generic;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
    public class AccountType : AdminBaseModel
    {
        public AccountTypeDescription AccountTypeDescription  { get; set; }
    }
}
