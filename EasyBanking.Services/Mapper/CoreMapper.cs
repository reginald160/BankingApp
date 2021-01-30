using AutoMapper;
using EasyBanking.Models;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Models.ViewModels;
using EasyBanking.Models.ViewModels.AccountViewModel;
using EasyBanking.Models.ViewModels.BankingHallViewModels;
using EasyBanking.Models.ViewModels.CustomerViewModels;
using EasyBanking.Models.ViewModels.EmployeeViewModels;
using EasyBanking.Models.ViewModels.InterestRateViewModels;
using EasyBanking.Services.IRepository;
using EasyBanking.Utility.CoreHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Services.Mapper
{
   public  class CoreMapper : Profile
	{
		public readonly ICoreServices core;
		public CoreMapper(ICoreServices core)
		{
			this.core = core;
		}
		public CoreMapper()
		{
		   
			CreateMap<Employee, CreateEmployeeViewModel>().ReverseMap()
				.ForMember(m => m.CreatedDate, o => o.Ignore())
				.ForMember(m => m.Id, o => o.Ignore());
			//CreateMap<Employee, CustomerAccountIndexViewModel>().ReverseMap();

			CreateMap<Employee, EmployeeIndexViewModel>().ReverseMap();

			CreateMap<Employee, EmployeeEditViewModel>().ReverseMap();

			CreateMap<Employee, EmployeeProfileViewModel>().ReverseMap()
				 .ForMember(m => m.Deleted, o => o.Ignore())
				.ForMember(m => m.Id, o => o.Ignore());




			CreateMap<Customer, CreateCustomerViewModel>().ReverseMap()
			   .ForMember(m => m.CreatedDate, o => o.Ignore())
				 .ForMember(m => m.AccountNumber, o => o.Ignore())
			   .ForMember(m => m.Id, o => o.Ignore());

			CreateMap<Customer, DeleteCustomerViewModel>().ReverseMap();

			CreateMap<Customer, CustomerIndexViewModel>().ReverseMap();

			CreateMap<Customer, CustomerEditViewModel>().ReverseMap()
				.ForMember(m => m.Deleted, o => o.Ignore())
				.ForMember(m => m.Id, o => o.Ignore());

			CreateMap<AccountType, AccountTypeViewModel>().ReverseMap();

			CreateMap<AccountIndexViewModel, CustomerAccount>().ReverseMap()
				.ForMember(m => m.AccounttypeTitle, o => o.MapFrom(c => c.AccountType.Name.ToString()));

			CreateMap<CustomerAccount, CustomerAccountViewModel>().ReverseMap()
				.ForMember(m => m.Id, o => o.Ignore());
			CreateMap<CustomerAccountViewModel, Customer>().ReverseMap()
				.ForMember(m => m.CustomerId, o => o.MapFrom(c => c.Id))
				.ForMember(m => m.CustomerName, o => o.MapFrom(c => c.FullName))
				.ForMember(m => m.ImagePath, o => o.MapFrom(c => c.ImageUrl))
				.ForMember(m => m.Id, o => o.Ignore());

			CreateMap<SavingsInterestRate, SavingsInterestRateViewModel>().ReverseMap();

			CreateMap<CustomerAccount, CashierViewModel>().ReverseMap();


		}

	   
	}
}
