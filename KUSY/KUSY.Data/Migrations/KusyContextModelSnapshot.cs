﻿// <auto-generated />
using System;
using KUSY.Data.Concrete.EntityFremework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KUSY.Data.Migrations
{
    [DbContext(typeof(KusyContext))]
    partial class KusyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KUSY.Entities.Concrete.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CoursePeriyod")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacultyCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseName")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseCode = "CSI101",
                            CourseName = "Introduction to Computer Science",
                            CoursePeriyod = "1.Dönem",
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9164),
                            FacultyCode = "CSI",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9165),
                            Note = "İnitialCreate",
                            UserID = 2
                        },
                        new
                        {
                            Id = 2,
                            CourseCode = "CSI102",
                            CourseName = "Algorithms",
                            CoursePeriyod = "2.Dönem",
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9169),
                            FacultyCode = "CSI",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9170),
                            Note = "İnitialCreate",
                            UserID = 2
                        });
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.CourseStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("GradeAverage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudents", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(2847),
                            GradeAverage = 0m,
                            IsActive = true,
                            IsDeleted = false,
                            IsPassed = true,
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(2848),
                            Note = "İnitialCreate",
                            StudentId = 1
                        });
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7420),
                            Description = "Admin rolu",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7421),
                            Name = "Admin",
                            Note = "İnitialCreate"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7425),
                            Description = "Öğretim görevlisi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7426),
                            Name = "Öğretim görevlisi",
                            Note = "İnitialCreate"
                        });
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("GraduationTime")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGraduate")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("RegistrationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("StudentCode")
                        .IsUnique();

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6185),
                            Email = "test@test.com.tr",
                            FirstName = "kadir",
                            GraduationTime = new DateTime(2023, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6180),
                            IsActive = true,
                            IsDeleted = false,
                            IsGraduate = false,
                            LastName = "Doğlu",
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6186),
                            Note = "İnitialCreate",
                            PhoneNumber = "5061111111",
                            RegistrationTime = new DateTime(2018, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6176),
                            StudentCode = "202206100001",
                            Thumbnail = "default.png"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6192),
                            Email = "test1@test.com.tr",
                            FirstName = "Burak",
                            GraduationTime = new DateTime(2023, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6190),
                            IsActive = true,
                            IsDeleted = false,
                            IsGraduate = false,
                            LastName = "Doğluoğlu",
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6193),
                            Note = "İnitialCreate",
                            PhoneNumber = "5051111111",
                            RegistrationTime = new DateTime(2018, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6190),
                            StudentCode = "202206100002",
                            Thumbnail = "default.png"
                        });
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1568),
                            Description = "test",
                            Email = "damoglu.muratevren@hotmail.com",
                            FirstName = "Murat",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "DAMOĞLU",
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1568),
                            Note = "İnitialCreate",
                            PasswordHash = new byte[] { 48, 57, 56, 102, 54, 98, 99, 100, 52, 54, 50, 49, 100, 51, 55, 51, 99, 97, 100, 101, 52, 101, 56, 51, 50, 54, 50, 55, 98, 52, 102, 54 },
                            Picture = "default.png",
                            RoleId = 1,
                            Username = "damoglu.muratevren"
                        },
                        new
                        {
                            Id = 2,
                            CreatedById = 1,
                            CreatedDate = new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1573),
                            Description = "test",
                            Email = "damoglu.muratevren@gmail.com",
                            FirstName = "Evren",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "DAMOĞLU",
                            ModifiedById = 1,
                            ModifiedDate = new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1574),
                            Note = "İnitialCreate",
                            PasswordHash = new byte[] { 48, 57, 56, 102, 54, 98, 99, 100, 52, 54, 50, 49, 100, 51, 55, 51, 99, 97, 100, 101, 52, 101, 56, 51, 50, 54, 50, 55, 98, 52, 102, 54 },
                            Picture = "default.png",
                            RoleId = 2,
                            Username = "damoglu.evren"
                        });
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Course", b =>
                {
                    b.HasOne("KUSY.Entities.Concrete.User", "User")
                        .WithMany("Courses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.CourseStudent", b =>
                {
                    b.HasOne("KUSY.Entities.Concrete.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KUSY.Entities.Concrete.Student", "Student")
                        .WithMany("CourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.User", b =>
                {
                    b.HasOne("KUSY.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Course", b =>
                {
                    b.Navigation("CourseStudents");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.Student", b =>
                {
                    b.Navigation("CourseStudents");
                });

            modelBuilder.Entity("KUSY.Entities.Concrete.User", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
