using EasyBanking.DataAccess;
using EasyBanking.Models.CoreBanking;
using EasyBanking.Services.IRepository;
using EasyBanking.Services.ServiceHelpers;
using EasyBanking.Utility.CoreHelpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.Repository
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly ApplicationDbContext _context;
     
   
        public EmployeeServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Employee newEmployee)
        {

            newEmployee.IsNewRecord = Universe.NewRecord;
            await _context.Employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();
        }
        public Employee GetById(Guid employeeId) =>
            _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();


        public async Task Delete(Guid employeeId)
        {   
            var employee = GetById(employeeId);
            employee.Deleted = Universe.Deleted;
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }
         public async Task Restore(Guid employeeId)
        {
            var employee = GetById(employeeId);
            employee.Deleted = !Universe.Deleted;
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }
       
        public IEnumerable<Employee> GetAll() => _context.Employees.AsNoTracking().OrderBy(emp => emp.FullName);

        public async Task UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id)
        {
            var employee = GetById(id);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAllEmployee() =>  _context.Employees.AsNoTracking().OrderBy(emp => emp.FullName);

        public Employee GetByIdExludeImageUrl(Guid employeeId)
        {
            {
               return  _context.Employees.AsNoTracking().Where(e => e.Id == employeeId).FirstOrDefault();

            }
        }
    }
}
