﻿using Microsoft.EntityFrameworkCore;
using PersonApi.Datas;
using PersonApi.Repository.Repositories;

namespace PersonApi.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbcontext;
        public IEmployeeRepository EmployeeRepository { get; }
        public UnitOfWork(DatabaseContext dbcontext, IEmployeeRepository employeeRepository)
        {
            _dbcontext = dbcontext;
            EmployeeRepository = employeeRepository;
        }

        public int Complete()
        {
            return _dbcontext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbcontext.Dispose();
            }
        }
    }
}
