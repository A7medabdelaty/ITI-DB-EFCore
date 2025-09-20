using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITI_DB.Configurations
{
    public class InsCourseConfiguration : IEntityTypeConfiguration<InsCourse>
    {
        public void Configure(EntityTypeBuilder<InsCourse> builder)
        {
            builder.HasKey(ic => new { ic.InsId, ic.CrsId });

            builder.Property(ic => ic.Evaluation).HasMaxLength(50);

            builder.HasOne(ic => ic.Instructor)
                   .WithMany(i => i.InsCourses)
                   .HasForeignKey(ic => ic.InsId);

            builder.HasOne(ic => ic.Course)
                   .WithMany(c => c.InsCourses)
                   .HasForeignKey(ic => ic.CrsId);
        }
    }
}
