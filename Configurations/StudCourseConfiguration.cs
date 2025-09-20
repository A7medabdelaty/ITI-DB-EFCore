using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_DB.Configurations
{
    public class StudCourseConfiguration : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> builder)
        {
            builder.HasKey(sc => new { sc.StId, sc.CrsId });

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StudCourses)
                   .HasForeignKey(sc => sc.CrsId);

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.StudCourses)
                   .HasForeignKey(sc => sc.StId);
        }
    }
}
