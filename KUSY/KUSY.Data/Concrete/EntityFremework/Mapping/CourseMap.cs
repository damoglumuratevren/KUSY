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
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c=>c.CourseName).HasMaxLength(100);
            builder.Property(c => c.CourseName).IsRequired();
            builder.HasIndex(c => c.CourseName).IsUnique();

            builder.Property(c => c.CourseCode).HasMaxLength(100);
            builder.Property(c => c.CourseCode).IsRequired();

            builder.Property(c => c.CoursePeriyod).HasMaxLength(10);
            builder.Property(c => c.CoursePeriyod).IsRequired();

            builder.Property(c => c.FacultyCode).HasMaxLength(10);
            builder.Property(c => c.FacultyCode).IsRequired();

            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.CreatedById).IsRequired();
            builder.Property(o => o.ModifiedById).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o=> o.Note).HasMaxLength(500);

            builder.HasOne<User>(o => o.User).WithMany(u => u.Courses).HasForeignKey(u => u.UserID);

            builder.ToTable("Courses");
            builder.HasData(new Course
            {
                Id = 1,
                CourseCode= "CSI101",
                CourseName= "Introduction to Computer Science",
                CoursePeriyod="1.Dönem",
                FacultyCode="CSI",
                UserID=2,
                IsActive = true,
                IsDeleted = false,
                CreatedById = 1,
                ModifiedById = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Note = "İnitialCreate"
            }, new Course
            {
                Id = 2,
                CourseCode = "CSI102",
                CourseName = "Algorithms",
                CoursePeriyod = "2.Dönem",
                FacultyCode = "CSI",
                UserID = 2,
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
