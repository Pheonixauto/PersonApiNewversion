using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class SkillConfig : IEntityTypeConfiguration<InforSkill>
    {
        public void Configure(EntityTypeBuilder<InforSkill> builder)
        {
            builder.HasData(
                 new InforSkill
                 {
                     Id = 1,
                     Name = "Java",

                 },
                new InforSkill
                {
                    Id = 2,
                    Name = "CSharp",

                },
                new InforSkill
                {
                    Id = 3,
                    Name = "JavaScript"
                }
                );
        }
    }
}
