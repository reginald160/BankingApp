using EasyBanking.DataAccess;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Services.IRepository;
using EasyBanking.Utility.CoreHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AccountServices : IAccountServices
{
	private readonly ApplicationDbContext _context;

	public AccountServices(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task CreateAccountTypeAsync(AccountType newAccountType)
	{
		await _context.AccountTypes.AddAsync(newAccountType);
		await Save();
	}

	public async Task DeleteAccountType(Guid id)
	{
		var accountType = GetAccountType(id);
		accountType.Deleted = Universe.Deleted;
		await UpdateAccountType(accountType);
	}

	public  AccountType GetAccountType(Guid id)
	{
		 var accountType = _context.AccountTypes.Where(a => a.Id == id && a.Deleted != Universe.Deleted).FirstOrDefault();
		return accountType;
	}

	public IEnumerable<AccountType> GetAllAccountTypes()
	{
		var accountTypes = _context.AccountTypes.Where(a => a.Deleted != Universe.Deleted).ToList();

		return accountTypes;

	}

	public async Task UpdateAccountType(AccountType accountType)
	{
		 _context.AccountTypes.Update(accountType);
		await Save();
	   
	}
	public async Task Save()
	{
		await _context.SaveChangesAsync();
	}

	public IEnumerable<SelectListItem> GetAccountTypedropDown()
	{
		var accounTypeDrobdown = _context.AccountTypes.Where(a => a.Deleted != Universe.Deleted).Select(a => new SelectListItem
		{
			Text = a.Title,
			Value = a.Id.ToString()
		}).ToList();

		return accounTypeDrobdown;


	}

	public IEnumerable<CustomerAccount> GetAllCustomeraccount()
	{
		var customerAccounts = _context.CustomersAccounts.Where(a => a.Deleted != Universe.Deleted).ToList();

		return customerAccounts;
	}

	public IEnumerable<SelectListItem> GetCustomerAccountdropDown()
	{
		var customerAccounts = _context.CustomersAccounts.Where(a => a.Deleted != Universe.Deleted).Select(a => new SelectListItem
		{
			Text = a.Customer.FullName,
			Value = a.Id.ToString()
		}).ToList();

		return customerAccounts;
	}

	public CustomerAccount GetCustomerAccount(Guid id)
	{
		var customerAccount = _context.CustomersAccounts.Where(c=> c.Id == id && c.Deleted != Universe.Deleted).FirstOrDefault();

		return customerAccount;
	}

	public async Task UpdateCustomerAccount(CustomerAccount customerAccount)
	{
			_context.CustomersAccounts.Update(customerAccount);
		await Save();

	}

	public async  Task DeleteCustomerAccount(Guid id)
	{
		var customerAccount = GetAccountType(id);
		customerAccount.Deleted = Universe.Deleted;
		await UpdateAccountType(customerAccount);
	}

	public CustomerAccount GetCustomerAccount(long accountnumber)
	{
		return   _context.CustomersAccounts.Where(a => a.AccountNumber == accountnumber ).FirstOrDefault();

	}


}