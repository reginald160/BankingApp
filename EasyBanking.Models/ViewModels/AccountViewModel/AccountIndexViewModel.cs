using EasyBanking.Models.CoreBanking;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Models.ViewModels.AccountViewModel
{
    public class AccountIndexViewModel : AdminBaseViewModel
    {
        public Guid? AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
  
        public long AccountNumber { get; set; }

        public string AccountName { get; set; }

        public string AccounttypeTitle { get; set; }


    }
}
