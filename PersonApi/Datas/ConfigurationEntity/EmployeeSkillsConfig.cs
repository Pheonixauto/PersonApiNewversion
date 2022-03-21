using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeSkillsConfig : IEntityTypeConfiguration<InforEmployeeSkill>
    {
        public void Configure(EntityTypeBuilder<InforEmployeeSkill> builder)
        {
            builder.HasData(
                new InforEmployeeSkill
                {
                    EmployId = 1,
                    SkillId = 1,
                    Rating = 4
                },
                new InforEmployeeSkill
                {
                    EmployId = 2,
                    SkillId = 2,
                    Rating = 5
                },
                new InforEmployeeSkill
                {
                    EmployId = 1,
                    SkillId = 2,
                    Rating = 5
                },
                 new InforEmployeeSkill
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
