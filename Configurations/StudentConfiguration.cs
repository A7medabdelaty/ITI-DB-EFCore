

using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITI_DB.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s=>s.StId);

            builder.Property(s => s.StFname).HasMaxLength(50);
            builder.Property(s=>s.StLname).HasMaxLength(50);
            builder.Property(s => s.StAddress).HasMaxLength(100);

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DeptId);

        }
    }
}
