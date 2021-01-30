using EasyBanking.DataAccess;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Services.IRepository;
using EasyBanking.Utility.CoreHelpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EasyBanking.Services.Repository
{
    public class CustomerServices : /*GenericServices<Customer>,*/ ICustomerServices
    {
        private readonly ApplicationDbContext _context;
        public CustomerServices(ApplicationDbContext context) /*: base(db)*/
        {
            _context = context;
        }
        public async Task CreateAsync(Customer newCustomer)
        {
            newCustomer.IsNewRecord = Universe.NewRecord;
            newCustomer.AccountNumber = LogicHelper.AccountNumberGenerator();
            await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
        }
        public Customer GetById(Guid customerId) =>
            _context.Customers.Where(e => e.Id == customerId).FirstOrDefault();


        public async Task Delete(Guid customerId)
        {
            var customer = GetById(customerId);
            customer.Deleted = Universe.Deleted;
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }
        public async Task Restore(Guid customerId)
        {
            var customer = GetById(customerId);
            customer.Deleted = !Universe.Deleted;
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Customer> GetAll() => _context.Customers.AsNoTracking().OrderBy(c => c.FullName);

        public async Task UpdateAsync(Customer customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id)
        {
            var customer = GetById(id);
            _context.Update(customer);
            await _context.SaveChangesAsync();
        }
        public IEnumerable<SelectListItem> GetAllAccoutofficer()
        {
            var allAccountOfficer = _context.Employees.Where(a => a.Designation == Models.CoreEnum.Designition.AccountOfficer).Select(a => new SelectListItem
            {
                Text = a.FullName,
                Value = a.Id.ToString()
            });
            return allAccountOfficer;
        }

        public IEnumerable<SelectListItem> GetAllManager()
        {
            var allManager = _context.Employees.Where(a => a.Designation == Models.CoreEnum.Designition.Manager).Select(m => new SelectListItem
            {
                Text = m.FullName,
                Value = m.Id.ToString()
            });
            return allManager;
        }
        public IEnumerable<Customer> GetAllCustomer() => _context.Customers.AsNoTracking().OrderBy(c => c.FullName);
    }
   

}  

