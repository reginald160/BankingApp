using EasyBanking.DataAccess;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Services.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.Repository
{
    public class BankingHallServices : IBankingHallServices
    {
        private readonly ApplicationDbContext _context;

        public BankingHallServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateSavingsInterestRate(SavingsInterestRate savingsInterest)
        {
            await _context.SavingsInterestRates.AddAsync(savingsInterest);
            await _context.SaveChangesAsync();
        }

        public Task Payment(CustomerAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
