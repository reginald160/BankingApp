using EasyBanking.Models.CoreBanking;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.IRepository
{
    public interface IInterestrateServices : IGenericServices<SavingsInterestRate>
    {
        IEnumerable<SelectListItem> GetSavingsIntRateForDropDown();
        Task Update(SavingsInterestRate savingsInterestRate);
        Task Delete(Guid id);
        Task Restore(Guid id);
    }
}
