using EasyBanking.Models.CoreBanking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyBanking.Services.IRepository
{
    public interface ICustomerServices /*: IGenericServices<Customer>*/
    {
        Task CreateAsync(Customer NewCustomer);
        Customer GetById(Guid customerId);
        IEnumerable<Customer> GetAllCustomer();
        Task UpdateAsync(Customer customer);
        Task UpdateAsync(Guid id);
        Task Delete(Guid customerId);
        Task Restore(Guid customerId);
        IEnumerable<SelectListItem> GetAllAccoutofficer();
        IEnumerable<SelectListItem> GetAllManager();
    }
}
