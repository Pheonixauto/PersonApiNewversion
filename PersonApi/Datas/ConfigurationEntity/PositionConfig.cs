using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Entities;
using PersonApi.Models;

namespace PersonApi.Datas.ConfigurationEntity
{
    public class PositionConfig : IEntityTypeConfiguration<InforPosition>
    {
        public void Configure(EntityTypeBuilder<InforPosition> builder)
        {
           
                
            //builder.HasOne<InformationEmployee>(p => p.InformationEmployee)
            //      .WithOne(s => s.InformationPosition)
            //      .HasForeignKey<InformationEmployee>(fk => fk.PositionId);

            builder.HasData(
                new InforPosition
                {
                    Id = 1,
                    Name = "Trưởng phòng",
               
                  
                });
        }
    }

}