using PersonApi.Repository.Repositories;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        int Complete();
    }
}
