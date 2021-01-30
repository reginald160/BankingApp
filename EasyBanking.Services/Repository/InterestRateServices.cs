using EasyBanking.DataAccess;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Services.IRepository;
using EasyBanking.Utility.CoreHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.Repository
{
    public class InterestRateServices :GenericServices<SavingsInterestRate> , IInterestrateServices
    {
        private readonly ApplicationDbContext _context;
        public InterestRateServices(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetSavingsIntRateForDropDown()
        {
            return _context.SavingsInterestRates.Where( s => s.Deleted != Universe.Deleted).Select(i => new SelectListItem()
            {
                Text = i.InterestDescription,
                Value = i.Id.ToString()
            });
        }

        public async Task Update(SavingsInterestRate savingsInterestRate)
        {
            var objFromDb = _context.SavingsInterestRates.Where(s => s.Id == savingsInterestRate.Id && s.Deleted != Universe.Deleted).FirstOrDefault();
            _context.SavingsInterestRates.Update(savingsInterestRate);
            await _context.SaveChangesAsync();

            _context.SaveChanges();
        }

        public async Task Delete(Guid id)
        {
            var interestRate = _context.SavingsInterestRates.Where(s => s.Id ==id ).FirstOrDefault();
            interestRate.Deleted = Universe.Deleted;
            _context.Update(interestRate);
            await _context.SaveChangesAsync();
        }
        public async Task Restore(Guid id)
        {
            var interestRate = _context.SavingsInterestRates.Where(s => s.Id == id).FirstOrDefault();
            interestRate.Deleted = !Universe.Deleted;
            _context.Update(interestRate);
            await _context.SaveChangesAsync();
        }
    }
}
