using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeLearningConfig : IEntityTypeConfiguration<InformationEmployee_Learning>
    {
        public void Configure(EntityTypeBuilder<InformationEmployee_Learning> builder)
        {

            builder.HasData(
                     new InformationEmployee_Learning
                     {
                         EmployeeId = 1,
                         StudyId = 1,
                         Major = " Công Nghệ Thông Tin",
                         Qualification = "Đại học"
                     },
                      new InformationEmployee_Learning
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
