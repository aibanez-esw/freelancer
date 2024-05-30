using Domain.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.EntityFramework.Users.Configuration
{
    public class FreelancerConfiguration : UserConfiguration<Freelancer>
    {
        public override void Configure(EntityTypeBuilder<Freelancer> builder)
        {
            base.Configure(builder);
            builder.ToTable("Freelancer").HasKey(f => f.Uuid);
            builder.Property(c => c.Expertise).IsRequired().HasMaxLength(100);
            builder.OwnsOne(c => c.ContactInformation);
        }
    }
}
