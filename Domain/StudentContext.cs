using Microsoft.EntityFrameworkCore;
using System;

namespace Domain
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=NapredneStudenti; Trusted_Connection=True;");
            optionsBuilder.LogTo(Console.WriteLine);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudyProgram>().ToTable("TStudyProgram");
            modelBuilder.Entity<StudyProgram>().HasKey(s => s.SpId);

            modelBuilder.Entity<Student>().HasOne(s => s.StudyProgram).WithMany().HasForeignKey(s => s.SpId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Student>().Property(s => s.FirstName).IsRequired();

            modelBuilder.Entity<Student>().HasMany(s => s.EnrolledCourses).WithMany(c => c.EnrolledStudents);
            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<Exam>().HasKey(e => new { e.StudentId, e.CourseId, e.Date });

            modelBuilder.Entity<Exam>().HasOne(e => e.Student).WithMany(s => s.Exams).HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Exam>().HasOne(e => e.Course).WithMany(c => c.Exams).HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Exam>().ToTable("Exam");

            modelBuilder.Entity<Student>().OwnsMany(s => s.Transactions).WithOwner(t => t.Student);

            //modelBuilder.Entity<Transaction>().ToTable("Transactions"); owned

            modelBuilder.Entity<Student>().HasBaseType<Person>().ToTable("Students");
            modelBuilder.Entity<Teacher>().HasBaseType<Person>().ToTable("Teachers");


        }
    }
}
