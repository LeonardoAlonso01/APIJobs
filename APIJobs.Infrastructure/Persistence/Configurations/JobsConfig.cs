using APIJobs.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIJobs.Infrastructure.Persistence.Configurations
{
    public class JobsConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder
                .ToTable("Jobs")
                .HasKey(c => c.Id);

            builder.
                Property(j => j.Id)
                .IsRequired();

            builder.
                Property(j => j.Title);

            builder.
                Property(j => j.Description);

            builder.
                Property(j => j.Location);

            builder.
                Property(j => j.Salary);

        }
    }
}
