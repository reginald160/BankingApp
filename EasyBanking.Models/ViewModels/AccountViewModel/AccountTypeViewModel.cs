using System;
using System.Collections.Generic;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.AccountViewModel
{
	public class AccountTypeViewModel : AdminBaseViewModel
	{
		public string Title { get; set; }
		public string AccountCode { get; set; }
		public AccountTypeDescription AccountTypeDescription { get; set; }
	}
}
