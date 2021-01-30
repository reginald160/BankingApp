using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static EasyBanking.Models.CoreEnum;

namespace EasyBanking.Models.CoreBanking
{
	public class AccountType : AdminBaseModel
	{	
		[Required]
		[NotMapped]
		public string Name { get; set; }
		[Required]
		[NotMapped]
		public string Code { get; set; }

		[Required]
		public string Title { get; set; }
		[Required]
		public string AccountCode { get; set; }
		[Required]
		public AccountTypeDescription AccountTypeDescription  { get; set; }

	}
}
