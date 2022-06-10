using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KUSY.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistrationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GraduationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsGraduate = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoursePeriyod = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    ModifiedById = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedById", "ModifiedDate", "Name", "Note" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7420), "Admin rolu", true, false, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7421), "Admin", "İnitialCreate" },
                    { 2, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7425), "Öğretim görevlisi", true, false, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(7426), "Öğretim görevlisi", "İnitialCreate" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Email", "FirstName", "GraduationTime", "IsActive", "IsDeleted", "IsGraduate", "LastName", "ModifiedById", "ModifiedDate", "Note", "PhoneNumber", "RegistrationTime", "StudentCode", "Thumbnail" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6185), "test@test.com.tr", "kadir", new DateTime(2023, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6180), true, false, false, "Doğlu", 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6186), "İnitialCreate", "5061111111", new DateTime(2018, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6176), "202206100001", "default.png" },
                    { 2, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6192), "test1@test.com.tr", "Burak", new DateTime(2023, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6190), true, false, false, "Doğluoğlu", 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6193), "İnitialCreate", "5051111111", new DateTime(2018, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(6190), "202206100002", "default.png" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedById", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 1, 1, new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1568), "test", "damoglu.muratevren@hotmail.com", "Murat", true, false, "DAMOĞLU", 1, new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1568), "İnitialCreate", new byte[] { 48, 57, 56, 102, 54, 98, 99, 100, 52, 54, 50, 49, 100, 51, 55, 51, 99, 97, 100, 101, 52, 101, 56, 51, 50, 54, 50, 55, 98, 52, 102, 54 }, "default.png", 1, "damoglu.muratevren" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "Description", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedById", "ModifiedDate", "Note", "PasswordHash", "Picture", "RoleId", "Username" },
                values: new object[] { 2, 1, new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1573), "test", "damoglu.muratevren@gmail.com", "Evren", true, false, "DAMOĞLU", 1, new DateTime(2022, 6, 10, 23, 38, 13, 355, DateTimeKind.Local).AddTicks(1574), "İnitialCreate", new byte[] { 48, 57, 56, 102, 54, 98, 99, 100, 52, 54, 50, 49, 100, 51, 55, 51, 99, 97, 100, 101, 52, 101, 56, 51, 50, 54, 50, 55, 98, 52, 102, 54 }, "default.png", 2, "damoglu.evren" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "CoursePeriyod", "CreatedById", "CreatedDate", "FacultyCode", "IsActive", "IsDeleted", "ModifiedById", "ModifiedDate", "Note", "UserID" },
                values: new object[] { 1, "CSI101", "Introduction to Computer Science", "1.Dönem", 1, new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9164), "CSI", true, false, 1, new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9165), "İnitialCreate", 2 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseName", "CoursePeriyod", "CreatedById", "CreatedDate", "FacultyCode", "IsActive", "IsDeleted", "ModifiedById", "ModifiedDate", "Note", "UserID" },
                values: new object[] { 2, "CSI102", "Algorithms", "2.Dönem", 1, new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9169), "CSI", true, false, 1, new DateTime(2022, 6, 10, 23, 38, 13, 353, DateTimeKind.Local).AddTicks(9170), "İnitialCreate", 2 });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "Id", "CourseId", "CreatedById", "CreatedDate", "GradeAverage", "IsActive", "IsDeleted", "IsPassed", "ModifiedById", "ModifiedDate", "Note", "StudentId" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(2847), 0m, true, false, true, 1, new DateTime(2022, 6, 10, 23, 38, 13, 354, DateTimeKind.Local).AddTicks(2848), "İnitialCreate", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseName",
                table: "Courses",
                column: "CourseName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserID",
                table: "Courses",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseId",
                table: "CourseStudents",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCode",
                table: "Students",
                column: "StudentCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
