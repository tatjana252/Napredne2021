using DataAccessLayer;
using DataAccessLayer.Implementations;
using DataAccessLayer.UnitOfWork;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //using StudentContext context = new StudentContext();

            //Student s1 = new()
            //{
            //    //StudentId = 1,
            //    FirstName = "Pera", 
            //    LastName = "Peric", 
            //    EnrollmentYear = 2018,
            //    EnrollmentNumber = 1,
            //    Gpa = 9.8
            //};
            //Student s2 = new()
            //{
            //    //StudentId = 2,
            //    FirstName = "Mika",
            //    LastName = "Mikic",
            //    EnrollmentYear = 2017,
            //    EnrollmentNumber = 100,
            //    Gpa = 8.7
            //};
            //Student s3 = new()
            //{
            //    //StudentId = 3,
            //    FirstName = "Zika",
            //    LastName = "Zikic",
            //    EnrollmentYear = 2018,
            //    EnrollmentNumber = 1004,
            //    Gpa = 7.7
            //};
            ////context.Students.Add(s1);
            ////context.Add(s2);
            ////context.Add(s3);
            ////context.SaveChanges();
            ////Student students = context.Students.Where(s => s.EnrollmentYear == 2018).FirstOrDefault();
            ////List<Student> students = context.Students.OrderByDescending(s => s.Gpa).ToList();
            ////Console.WriteLine(students);
            ////students.ForEach(s => Console.WriteLine(s));
            //Student student = context.Students.Find(3);
            ////student.FirstName += "Izmenjeno";
            ////context.Remove(student);
            //context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            //context.SaveChanges();


            //using StudentContext context = new StudentContext();
            ////StudyProgram sp2 = new StudyProgram { Name = "Menadzment" };
            ////context.Add(sp1);
            ////context.Add(sp2);
            ////context.SaveChanges();

            //context.StudyPrograms.ToList().ForEach(sp => Console.WriteLine(sp));

            ////StudyProgram sp1 = new StudyProgram { Name = "Isit" };
            //StudyProgram sp1 = context.StudyPrograms.Single(sp => sp.Name == "Isit");
            //Student s1 = new()
            //{
            //    //StudentId = 1,
            //    FirstName = "Pera",
            //    LastName = "Peric",
            //    EnrollmentYear = 2018,
            //    EnrollmentNumber = 1,
            //    Gpa = 9.8,
            //    StudyProgram = sp1
            //};
            //context.Add(s1);
            //context.SaveChanges();

            //Student s2 = new()
            //{
            //    //StudentId = 2,
            //    FirstName = "Mika",
            //    LastName = "Mikic",
            //    EnrollmentYear = 2017,
            //    EnrollmentNumber = 100,
            //    Gpa = 8.7,
            //    SpId = 1
            //};
            //Student s3 = new()
            //{
            //    //StudentId = 3,
            //    FirstName = "Zika",
            //    LastName = "Zikic",
            //    EnrollmentYear = 2018,
            //    EnrollmentNumber = 1004,
            //    Gpa = 7.7,
            //    SpId = 2
            //};
            //context.Add(s2);
            //context.Add(s3);
            //context.SaveChanges();

            //select * from student;

            // context.Students.ToList().ForEach(s => Console.WriteLine(s));
            // context.Students.Where(s => s.StudyProgram.Name == "Isit").ToList().ForEach(s => Console.WriteLine(s));

            //string query= context.Students.Include(s => s.StudyProgram)
            //     .Where(s => s.StudyProgram.Name == "Isit").ToQueryString();
            // Console.WriteLine(query);
            //.ToList().ForEach(s => Console.WriteLine(s));


            //using StudentContext context = new StudentContext();

            //Course course1 = context.Courses.Single(c => c.Name == "Projektovanje softvera");
            //Console.WriteLine(context.Entry(course1).State); 



            //Course course = new Course { Id = 4, Name = "Napredne .NET tehnologije" };
            //context.Update(course);
            //Console.WriteLine(context.Entry(course).State);
            //context.Entry(course).State = EntityState.Modified;
            //context.SaveChanges();
            //context.Add(course);
            //context.SaveChanges();


            //List<Student> students = context.Students.ToList();

            //course.EnrolledStudents = new List<Student>();
            //course.EnrolledStudents.AddRange(students);

            //context.SaveChanges();

            // List<Course> courses = context.Courses.Include(c => c.EnrolledStudents).ToList();
            // Course course = courses.First();
            //course.Name = "Pro soft";
            // Console.WriteLine(context.Entry(course).State);

            //var courses1 = context.Courses
            //.Where(c => c.EnrolledStudents.Any(s => s.FirstName == "Pera"))
            //.ToList();

            //var course = context.Courses.Include(c => c.EnrolledStudents).First();

            // // var student = new Student { StudentId = 10, FirstName = "MikaPS", LastName = "MikicPS", SpId = 1 };
            // //  context.Attach(student);
            //var student = new Student
            //{
            //    PersonId = 8
            //};

            //var course = new Course
            //{
            //    Id = 1,
            //    EnrolledStudents = new List<Student>
            //    {
            //        new Student
            //        {
            //            PersonId = 1
            //        }
            //    }
            //};
            //context.Entry(course).State = EntityState.Modified;

            //context.Remove(course.EnrolledStudents[0]).State = EntityState.Deleted;
            //// course.EnrolledStudents.Add(student);

            //context.SaveChanges();



            //foreach(Course course in courses)
            //{
            //    Console.WriteLine($"Course: " + course.Name);
            //    Console.WriteLine("Enrolled students:");
            //    course.EnrolledStudents.ForEach(s => Console.WriteLine(s));  
            //    //foreach(Student s in course.EnrolledStudents)
            //    //{
            //    //    Console.WriteLine(s);
            //    //}
            //}


            //using StudentContext context = new StudentContext();
            //if (!context.Exams.Any(e => e.CourseId == 3 && e.Grade > 5 && e.StudentId == 8))
            //{
            //    Exam exam = new Exam { StudentId = 8, CourseId = 3, Grade = 8, Date = DateTime.Today };
            //    context.Add(exam);
            //    context.SaveChanges();
            //}


            //using StudentContext studentContext = new StudentContext();
            //Transaction transaction = new Transaction { StudentId = 8, TransactionType = TransactionType.Deposit, Value = 1000 };
            //studentContext.Add(transaction);
            //studentContext.SaveChanges();

            //var students = studentContext.Students.ToList();


            //using StudentContext context = new StudentContext();

            //Student s1 = new Student { FirstName = "Pera", LastName = "Peric", SpId = 1 };
            //Student s2 = new Student { FirstName = "Mika", LastName = "Mikic", SpId = 1 };
            //context.Add(s1);
            //context.Add(s2);
            //Teacher teacher = new Teacher { FirstName = "Zika", LastName = "Zikic" };
            //context.Add(teacher);
            //context.SaveChanges();


            //var persons = context.Persons.ToList();

            //foreach(var item in persons)
            //{
            //  if(item is Teacher t)
            //    {
            //        Console.WriteLine("Teacher " +t.EmploymentDate);
            //    }
            //    if (item is Student s)
            //    {
            //        Console.WriteLine("Student " + s.ToString());
            //    }
            //}



            //var students = context.Students.ToList();
            //var teachers = context.Teacher.ToList();

            //using StudentContext context = new StudentContext();
            //ICourseRepository repository1 = new CourseRepository(context);
            //IExamRepository repository2 = new ExamRepository(context);
            //IStudentRepository repository3 = new StudentRepository(context);

            //repository1.Add(new Course { Name = "Course 2" });
            //repository3.Add(new Student { FirstName = "Pera", LastName = "Peric", SpId = 1 });

            //context.SaveChanges();
            //List<Course> courses = repository.SearchBy(c => c.Id == 1);

            using StudentContext context = new StudentContext();

            IUnitOfWork unitOfWork = new UnitOfWork(context);

            unitOfWork.CourseRepository.Add(new Course { Name = "Course 3" });
            unitOfWork.Save();


        }
    }
}
