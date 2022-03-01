using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeSkillsConfig : IEntityTypeConfiguration<InformationEmployee_Skill>
    {
        public void Configure(EntityTypeBuilder<InformationEmployee_Skill> builder)
        {
            builder.HasData(
                new InformationEmployee_Skill
                {
                    EmployId = 2,
                    SkillId = 1,
                    Rating = 4
                },
                new InformationEmployee_Skill
                {
                    EmployId = 2,
                    SkillId = 2,
                    Rating = 5
                },
                new InformationEmployee_Skill
                {
                    EmployId = 1,
                    SkillId = 2,
                    Rating = 5
                }
                );
        }
    }
}
