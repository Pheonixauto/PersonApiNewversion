using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeLearningConfig : IEntityTypeConfiguration<InforEmployeeLearning>
    {
        public void Configure(EntityTypeBuilder<InforEmployeeLearning> builder)
        {

            builder.HasData(
                     new InforEmployeeLearning
                     {
                         EmployeeId = 1,
                         StudyId = 1,
                         Major = " Công Nghệ Thông Tin",
                         Qualification = "Đại học"
                     },
                      new InforEmployeeLearning
                      {
                          EmployeeId = 1,
                          StudyId = 2,
                          Major = " Cơ Khí",
                          Qualification = "Đại học"
                      }
                );
        }
    }
}
