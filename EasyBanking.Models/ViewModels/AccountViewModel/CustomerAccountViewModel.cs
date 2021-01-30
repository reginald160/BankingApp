using EasyBanking.Models.CoreBanking;
using System;
using System.Collections.Generic;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.ViewModels.AccountViewModel
{
	public class CustomerAccountViewModel : AdminBaseViewModel
	{
		
		public string CustomerName { get; set; }
		public long AccountNumber { get; set; }
		public Guid AccountTypeId { get; set; }
		public Guid SavingsInterestRateId { get; set; }
		public string ImagePath { get; set; }
		public DateTime DOB { get; set; }
		public string Email { get; set; }
		public Gender Gender { get; set; }
		//public virtual Account Account { get; set; }

		public Guid CustomerId { get; set; }
		//public  Customer Customer { get; set; }
	
		//public long AccountNumber { get; set; }
		//public AccountStatusDescription AccountStatus { get; set; }
		//public decimal AccountBalance { get; set; }
	}
}
