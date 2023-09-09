using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.IRepository;

namespace WebAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly APIDBContext _context;

        private IGenericRepository<Department> _department;
        private IGenericRepository<Employee> _employee;
        private IGenericRepository<User> _user;

        public UnitOfWork(APIDBContext context)
        {
            _context = context;
        }
        public IGenericRepository<Department> Department => _department ??= new GenericRepository<Department>(_context);
       

        public IGenericRepository<Employee> Employee => _employee ??= new GenericRepository<Employee>(_context);

        public IGenericRepository<User> User => _user ??= new GenericRepository<User>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
