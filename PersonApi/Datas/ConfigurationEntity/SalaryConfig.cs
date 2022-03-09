using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class SalaryConfig : IEntityTypeConfiguration<InformationSalary>
    {
        public void Configure(EntityTypeBuilder<InformationSalary> builder)
        {
            builder.HasData(
                 new InformationSalary
                 {
                     Id = 1,
                     Salary = 500,
                     DateTime = new DateTime(2022, 01, 01),
                     Tax = 10,
                     EmployeeId = 1

                 },
                new InformationSalary
                {
                    Id = 2,
                    Salary = 1000,
                    DateTime = new DateTime(2022, 02, 01),
                    Tax = 15,
                    EmployeeId = 1

                },
                new InformationSalary
                {
                    Id = 3,
                    Salary = 1500,
                    DateTime = new DateTime(2022, 03, 01),
                    Tax = 16,
                    EmployeeId = 1
                }
                );
        }
   
    }
}
