using EasyBanking.Models.CoreBanking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EasyBanking.Services.IRepository
{
    public interface IEmployeeServices
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(Guid employeeId);
        Employee GetByIdExludeImageUrl(Guid employeeId);
        IEnumerable<Employee> GetAllEmployee();
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(Guid id);
        Task Delete(Guid employeeId);
        Task Restore(Guid employeeId);
    }
}
