using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D151121ER_exam_prep
{
    static class Menu
    {
        public static int Choise { get; set; }

        public static int MainMenu()
        {           
            Console.WriteLine("1. Create an Entity.");
            Console.WriteLine("2. Delete an Entity.");
            Console.WriteLine("3. Update an Entity.");
            Console.WriteLine("4. Get Entity Details.");
            Console.WriteLine("5. Get the List of entities.");
            Console.WriteLine("6. Quit the app");
            Choise = int.Parse(Console.ReadLine());
            return Choise;
        }
        public static int AddMenu()
        {
            Console.WriteLine("1. Add a student.");
            Console.WriteLine("2. Add a course.");
            Console.WriteLine("3. Back.");
            Choise = int.Parse(Console.ReadLine());
            return Choise;
        }
        public static int DeleteMenu()
        {
            Console.WriteLine("1. Delete a student.");
            Console.WriteLine("2. Delete a course.");
            Console.WriteLine("3. Back.");
            Choise = int.Parse(Console.ReadLine());
            return Choise;
        }
        public static int UpdateMenu()
        {
            Console.WriteLine("1. Update student name.");
            Console.WriteLine("2. Update course name.");
            Console.WriteLine("3. Back.");
            Choise = int.Parse(Console.ReadLine());
            return Choise;
        }
        public static int PrintMenu()
        {
            Console.WriteLine("1. Print student details.");
            Console.WriteLine("2. Print course details.");
            Console.WriteLine("3. Back.");
            Choise = int.Parse(Console.ReadLine());
            return Choise;
        }
    }
}
