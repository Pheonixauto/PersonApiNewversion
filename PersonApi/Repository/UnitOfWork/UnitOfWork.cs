using Microsoft.EntityFrameworkCore;
using PersonApi.Datas;
using PersonApi.Repository.Repositories;
using PersonApi.Repository.Repositories.Implement;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbcontext;
        public IEmployeeRepository EmployeeRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public ISkillRepository SkillRepository { get; }
        public ILearningRepository LearningRepository { get; }
        public IRelativeRepository RelativeRepository { get; }
        public ISalaryRepository SalaryRepository { get; }
        public IEmployeeSkillRepository EmployeeSkillRepository { get; }

        public UnitOfWork(DatabaseContext dbcontext,
                          IEmployeeRepository employeeRepository,
                          IDepartmentRepository departmentRepository,
                          ISkillRepository skillRepository,
                          ILearningRepository learningRepository,
                          IRelativeRepository relativeRepository,
                          ISalaryRepository salaryRepository,
                          IEmployeeSkillRepository employeeSkillRepository)
        {
            _dbcontext = dbcontext;
            EmployeeRepository = employeeRepository;
            DepartmentRepository = departmentRepository;
            SkillRepository = skillRepository;
            LearningRepository = learningRepository;
            RelativeRepository = relativeRepository;
            SalaryRepository = salaryRepository;
            EmployeeSkillRepository = employeeSkillRepository;
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
