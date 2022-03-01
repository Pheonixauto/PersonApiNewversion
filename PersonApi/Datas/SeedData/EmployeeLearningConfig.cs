using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeLearningConfig : IEntityTypeConfiguration<InformationEmployeeLearning>
    {
        public void Configure(EntityTypeBuilder<InformationEmployeeLearning> builder)
        {

            builder.HasData(
                     new InformationEmployeeLearning
                     {
                         EmployeeId = 1,
                         StudyId = 1,
                         Major = " Công Nghệ Thông Tin",
                         Qualification = "Đại học"
                     },
                      new InformationEmployeeLearning
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
