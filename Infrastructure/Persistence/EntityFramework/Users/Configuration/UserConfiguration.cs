using Domain.Users.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.EntityFramework.Users.Configuration
{
    public class UserConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : User
    {
        private const string UuidColumnName = "uuid";
        private const string UsernameColumnName = "username";
        private const string PasswordColumnName = "password";
        private const string EmailColumnName = "email";
        private const string RoleColumnName = "role";

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(u => u.Uuid);
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Role).IsRequired();
        }
    }
}
