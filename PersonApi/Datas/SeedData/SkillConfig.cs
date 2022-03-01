using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class SkillConfig : IEntityTypeConfiguration<InformationSkill>
    {
        public void Configure(EntityTypeBuilder<InformationSkill> builder)
        {
            builder.HasData(
                 new InformationSkill
                 {
                     Id = 1,
                     Name = "Java",

                 },
                new InformationSkill
                {
                    Id = 2,
                    Name = "CSharp",

                },
                new InformationSkill
                {
                    Id = 3,
                    Name = "JavaScript"
                }
                );
        }
    }
}
