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
    public class CourseStudentMap : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.IsPassed).IsRequired();

            builder.Property(c => c.GradeAverage).IsRequired();


            builder.Property(o => o.CreatedDate).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.IsDeleted).IsRequired();
            builder.Property(o => o.IsActive).IsRequired();
            builder.Property(o => o.CreatedById).IsRequired();
            builder.Property(o => o.ModifiedById).IsRequired();
            builder.Property(o => o.ModifiedDate).IsRequired();
            builder.Property(o => o.Note).HasMaxLength(500);
            builder.HasOne<Course>(c => c.Course).WithMany(x => x.CourseStudents).HasForeignKey(c=>c.CourseId);
            builder.HasOne<Student>(c => c.Student).WithMany(s => s.CourseStudents).HasForeignKey(c => c.StudentId);
            builder.ToTable("CourseStudents");
            builder.HasData(new CourseStudent
            {
                Id = 1,
                IsPassed = true,
                GradeAverage = 0,
                CourseId = 1,
                StudentId = 1,
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
