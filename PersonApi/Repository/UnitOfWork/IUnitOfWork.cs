using PersonApi.Repository.Repositories;

namespace PersonApi.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        int Complete();
    }
}
