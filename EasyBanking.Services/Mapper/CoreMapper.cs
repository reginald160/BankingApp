using AutoMapper;
using EasyBanking.Models;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Models.ViewModels;
using EasyBanking.Models.ViewModels.CustomerViewModels;
using EasyBanking.Models.ViewModels.EmployeeViewModels;
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
            CreateMap<Employee, DeleteEmployeeViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeIndexViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeEditViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeProfileViewModel>().ReverseMap()
                 .ForMember(m => m.Deleted, o => o.Ignore())
                .ForMember(m => m.Id, o => o.Ignore());




            CreateMap<Customer, CreateCustomerViewModel>().ReverseMap()
               .ForMember(m => m.CreatedDate, o => o.Ignore())
                .ForMember(m => m.EmployeeId, o => o.Ignore())
                 .ForMember(m => m.UserLoginId, o => o.Ignore())
                 .ForMember(m => m.ManagerId, o => o.Ignore())
               .ForMember(m => m.Id, o => o.Ignore());

            CreateMap<Customer, DeleteCustomerViewModel>().ReverseMap();

            CreateMap<Customer, CustomerIndexViewModel>().ReverseMap();

            CreateMap<Customer, CustomerEditViewModel>().ReverseMap()
                .ForMember(m => m.Deleted, o => o.Ignore())
                .ForMember(m => m.Id, o => o.Ignore());

        }

       
    }
}
