using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeSkillsConfig : IEntityTypeConfiguration<InformationEmployeeSkill>
    {
        public void Configure(EntityTypeBuilder<InformationEmployeeSkill> builder)
        {
            builder.HasData(
                new InformationEmployeeSkill
                {
                    EmployId = 1,
                    SkillId = 1,
                    Rating = 4
                },
                new InformationEmployeeSkill
                {
                    EmployId = 2,
                    SkillId = 2,
                    Rating = 5
                },
                new InformationEmployeeSkill
                {
                    EmployId = 1,
                    SkillId = 2,
                    Rating = 5
                },
                 new InformationEmployeeSkill
                 {
                     EmployId = 1,
                     SkillId = 3,
                     Rating = 5
                 }
                 //new InformationEmployeeSkill
                 //{
                 //    EmployId = 1,
                 //    SkillId = 1,
                 //    Rating = 5
                 //}

                );
        }
    }
}
