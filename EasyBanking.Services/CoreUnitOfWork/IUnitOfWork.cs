using EasyBanking.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.CoreUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeServices employee { get; }
        ICustomerServices customer { get; }
        ICoreServices CoreServices { get; }
        IAccountServices accountServices { get; }
        IBankingHallServices bankingHallServices { get; }
        IInterestrateServices interestRateServices { get; }
        Task Save();

    }
}
