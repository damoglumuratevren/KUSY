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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).HasMaxLength(30);
            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.Description).HasMaxLength(300);


            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.CreatedById).IsRequired();
            builder.Property(o => o.ModifiedById).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.Note).HasMaxLength(500);
            builder.ToTable("Roles");
            builder.HasData(new Role
            {
                Id = 1,
                Name="Admin",
                Description="Admin rolu",
                IsActive=true,
                IsDeleted=false,
                CreatedById=1,
                ModifiedById=1, 
                CreatedDate=DateTime.Now,   
                ModifiedDate=DateTime.Now,
                Note="İnitialCreate"
            },new Role
            {
                Id = 2,
                Name = "Öğretim görevlisi",
                Description = "Öğretim görevlisi",
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Note = "İnitialCreate"
            });

            
        }
    }
}
