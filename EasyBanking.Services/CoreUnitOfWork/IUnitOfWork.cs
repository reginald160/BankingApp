using EasyBanking.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Services.CoreUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeServices employee { get; }
        ICustomerServices customer { get; }
        ICoreServices CoreServices { get; }
        
    }
}
