using KUSY.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSY.Data.Concrete.EntityFremework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();


            builder.Property(c => c.FirstName).HasMaxLength(50);
            builder.Property(c => c.FirstName).IsRequired();


            builder.Property(c => c.LastName).HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired();

            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(c => c.PasswordHash).IsRequired();
            builder.Property(c => c.PasswordHash).HasColumnType("VARBINARY(500)");

            builder.Property(c => c.Username).HasMaxLength(100);
            builder.Property(c => c.Username).IsRequired();
            builder.HasIndex(c => c.Username).IsUnique();


            builder.Property(c => c.Picture).HasMaxLength(50);
            builder.Property(c => c.Picture).IsRequired();


            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Description).IsRequired();


            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.CreatedById).IsRequired();
            builder.Property(o => o.ModifiedById).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.Note).HasMaxLength(500);
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Murat",
                LastName = "DAMOĞLU",
                Email = "damoglu.muratevren@hotmail.com",
                Username = "damoglu.muratevren",
                Picture = "default.png",
                PasswordHash = Encoding.ASCII.GetBytes("098f6bcd4621d373cade4e832627b4f6"),
                Description = "test",
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,                
                Note = "İnitialCreate"
            }, new User
            {
                Id = 2,
                RoleId = 2,
                FirstName = "Evren",
                LastName = "DAMOĞLU",
                Email = "damoglu.muratevren@gmail.com",
                Username = "damoglu.evren",
                Picture = "default.png",
                Description = "test",
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                PasswordHash = Encoding.ASCII.GetBytes("098f6bcd4621d373cade4e832627b4f6"),
                Note = "İnitialCreate"
            }); 
        }
    }
}
