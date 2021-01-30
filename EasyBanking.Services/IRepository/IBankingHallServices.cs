using EasyBanking.Models.CoreBanking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.IRepository
{
    public interface IBankingHallServices
    {
        Task CreateSavingsInterestRate(SavingsInterestRate savingsInterest);
        Task Payment(CustomerAccount account);
    }
}
