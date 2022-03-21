using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class LearningConfig : IEntityTypeConfiguration<InforLearning>
    {
        public void Configure(EntityTypeBuilder<InforLearning> builder)
        {
            builder.HasData(
                new InforLearning
                {
                    Id = 1,
                    UniversityName = "Đại Học Bách Khoa Hà Nội",

                },
                new InforLearning
                {
                    Id = 2,
                    UniversityName = "Đại Học Quốc Gia Hà Nội",
                }
                );
        }
    }
}
