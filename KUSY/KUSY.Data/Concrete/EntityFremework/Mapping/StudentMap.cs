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
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName).HasMaxLength(50);
            builder.Property(c => c.FirstName).IsRequired();


            builder.Property(c => c.LastName).HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired();


            builder.Property(c => c.StudentCode).HasMaxLength(20);
            builder.Property(c => c.StudentCode).IsRequired();
            builder.HasIndex(c => c.StudentCode).IsUnique();



            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(c => c.PhoneNumber).HasMaxLength(10);
            builder.Property(c => c.PhoneNumber).IsRequired();


            builder.Property(c => c.RegistrationTime).IsRequired();
            builder.Property(c => c.GraduationTime).IsRequired();
            builder.Property(c => c.IsGraduate).IsRequired();


            builder.Property(c => c.Thumbnail).HasMaxLength(50);
            builder.Property(c => c.Thumbnail).IsRequired();

            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.CreatedById).IsRequired();
            builder.Property(o => o.ModifiedById).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.Note).HasMaxLength(500);
            builder.ToTable("Students");
            builder.HasData(new Student
            {
                Id = 1,
                FirstName = "kadir",
                LastName = "Doğlu",
                StudentCode = "202206100001",
                Email = "test@test.com.tr",
                PhoneNumber = "5061111111",
                Thumbnail = "default.png",
                RegistrationTime = DateTime.Now.AddYears(-4),
                GraduationTime = DateTime.Now.AddYears(1),
                IsGraduate=false,
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Note = "İnitialCreate"
            },new Student
            {
                Id = 2,
                FirstName = "Burak",
                LastName = "Doğluoğlu",
                StudentCode = "202206100002",
                Email = "test1@test.com.tr",
                PhoneNumber = "5051111111",
                Thumbnail = "default.png",
                RegistrationTime = DateTime.Now.AddYears(-4),
                GraduationTime = DateTime.Now.AddYears(1),
                IsGraduate = false,
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Note = "İnitialCreate"

            }) ;
        }
    }
}
