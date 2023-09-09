using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Department> Department { get; }
        IGenericRepository<Employee> Employee { get; }
        IGenericRepository<User> User { get; }


        Task Save();
    }
}
