
using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITI_DB.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.DeptId);

            builder.Property(d => d.DeptName).HasMaxLength(50);
            builder.Property(d => d.DeptDescription).HasMaxLength(200);
            builder.Property(d => d.DeptLocation).HasMaxLength(100);

            builder.HasOne(d => d.Manager)
                   .WithOne(i => i.ManageDepartment)
                   .HasForeignKey<Department>(d => d.ManagerId);

            builder.HasMany(d => d.Instructors)
                   .WithOne(i => i.Department)
                   .HasForeignKey(i => i.DeptId);
        }
    }
}