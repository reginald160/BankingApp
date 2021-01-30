using EasyBanking.Models.CoreBanking;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.IRepository
{
	public interface IAccountServices
	{
		// AcountType methods
		Task CreateAccountTypeAsync(AccountType newAccountType);
		IEnumerable<AccountType> GetAllAccountTypes();
		IEnumerable<SelectListItem> GetAccountTypedropDown();
		AccountType GetAccountType(Guid id);
		Task UpdateAccountType(AccountType accountType);
		Task DeleteAccountType(Guid id);

// CustomerAccount methods
		IEnumerable<CustomerAccount> GetAllCustomeraccount();
		IEnumerable<SelectListItem> GetCustomerAccountdropDown();
		CustomerAccount GetCustomerAccount(Guid id);
		Task UpdateCustomerAccount(CustomerAccount customerAccount);
		Task DeleteCustomerAccount(Guid id);
		CustomerAccount GetCustomerAccount(long accountnumber);

		Task Save();
	}
}
