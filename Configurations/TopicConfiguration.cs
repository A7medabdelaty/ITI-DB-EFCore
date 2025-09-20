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
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>

    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(t => t.TopicId);

            builder.Property(t => t.TopicName).HasMaxLength(50);

            builder.HasMany(t => t.Courses)
                   .WithOne(c => c.Topic)
                   .HasForeignKey(c => c.TopId);
        }
    }
}
