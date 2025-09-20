using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ITI_DB.Configurations
{
    public class InstructorConfiguration: IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.InsId);

            builder.Property(i => i.InsName).HasMaxLength(50);
            builder.Property(i => i.InsDegree).HasMaxLength(50);
        }
    }
}
