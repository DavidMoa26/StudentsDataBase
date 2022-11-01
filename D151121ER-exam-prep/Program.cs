using D151121ER_exam_prep;
using D151121ER_exam_prep.Models;
using Microsoft.EntityFrameworkCore;



using (var context = new SchoolContext())
{
    int id;
    while (Menu.MainMenu() != 6)
    {
        switch (Menu.Choise)
        {
            case 1:
                switch (Menu.AddMenu())
                {
                    case 1:
                        Console.WriteLine("Enter student name : ");
                        context.Students.Add(new Student() { Name = Console.ReadLine()});
                        context.SaveChanges();
                        break;
                    case 2:
                        Console.WriteLine("Enter course name : ");
                        context.Courses.Add(new Course() { CourseName = Console.ReadLine() });
                        context.SaveChanges();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Out of range , please try again");
                        Menu.AddMenu();
                        break;
                }
                break;
            case 2:
                switch (Menu.DeleteMenu())
                {
                    case 1:
                        Console.WriteLine("Enter student id : ");
                        id = int.Parse(Console.ReadLine());
                        var CreateToRemoveStudent = context.Students.SingleOrDefault(x => x.StudentId == id);
                        context.Students.Remove(CreateToRemoveStudent);
                        context.SaveChanges();
                        break;
                    case 2:
                        Console.WriteLine("Enter course id : ");
                        id = int.Parse(Console.ReadLine());
                        var CreateToRemoveCourse = context.Courses.SingleOrDefault(x => x.CourseId == id);
                        context.Courses.Remove(CreateToRemoveCourse);
                        context.SaveChanges();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Out of range , please try again");
                        Menu.DeleteMenu();
                        break;
                }
                break;
            case 3:
                switch (Menu.UpdateMenu())
                {
                    case 1:
                        Console.WriteLine("Enter student id : ");
                        int StudentId = int.Parse(Console.ReadLine());                       
                        Console.WriteLine("Enter the new student name : ");
                        context.Students.Find(StudentId).Name=Console.ReadLine();
                        context.SaveChanges();

                        break;
                    case 2:
                        Console.WriteLine("Enter course id : ");
                        int CourseId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the new student name : ");
                        context.Courses.Find(CourseId).CourseName = Console.ReadLine();
                        context.SaveChanges();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Out of range , please try again");
                        Menu.UpdateMenu();
                        break;
                }
                break;
            case 4:
                switch (Menu.PrintMenu())
                {
                    case 1:
                        Console.WriteLine("Enter student id : ");
                        Console.WriteLine(context.Students.Find(int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Enter course id : ");
                        Console.WriteLine(context.Courses.Find(int.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Out of range , please try again");
                        Menu.DeleteMenu();
                        break;
                }
                break;
            case 5:
                var students = context.Students.ToList();
                var courses = context.Courses.ToList();
                Console.WriteLine("Students : ");
                students.ForEach(student => Console.WriteLine(student));
                Console.WriteLine("Courses : ");
                courses.ForEach(course => Console.WriteLine(course));
                break;
            case 6:
                    break;
            default:
                Console.WriteLine("Out of range , please try again");
                break;
        }
    }
}




