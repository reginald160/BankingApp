using EasyBanking.DataAccess;
using EasyBanking.Services.IRepository;
using EasyBanking.Services.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyBanking.Services.CoreUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            employee = new EmployeeServices(_context);
            CoreServices = new CoreService(_context);
            customer = new CustomerServices(_context);

        }

        public IEmployeeServices employee { get; private set; }
        public ICustomerServices customer { get; private set; }

        public ICoreServices CoreServices { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
