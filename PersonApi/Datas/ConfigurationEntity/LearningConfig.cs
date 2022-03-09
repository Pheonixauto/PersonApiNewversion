using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class LearningConfig : IEntityTypeConfiguration<InformationLearning>
    {
        public void Configure(EntityTypeBuilder<InformationLearning> builder)
        {
            builder.HasData(
                new InformationLearning
                {
                    Id = 1,
                    UniversityName = "Đại Học Bách Khoa Hà Nội",

                },
                new InformationLearning
                {
                    Id = 2,
                    UniversityName = "Đại Học Quốc Gia Hà Nội",
                }
                );
        }
    }
}
