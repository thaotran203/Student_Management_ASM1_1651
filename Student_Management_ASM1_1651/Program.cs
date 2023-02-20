using System;
using System.Linq;

namespace Student_Management_ASM1_1651
{
    internal class Program
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. Print all student's information");
            Console.WriteLine("3. Remove student by name");
            Console.WriteLine("4. Find student by name");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==================================");

        }
        static void Main(string[] args)
        {
            int choice = 1;
            var database = StudentDatabase.Instance;
            var view = new StudentView();
            var controller = new StudentController(database, view);

            do
            {
                DisplayMenu();
                Console.Write("Please enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter student's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter student's age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Please enter student's email: ");
                        string email = Console.ReadLine();
                        controller.AddStudent(name, age, email);
                        break;
                    case 2:
                        controller.ShowAllStudents();
                        break;
                    case 3:
                        Console.Write("Enter student' name: ");
                        string studentName = Console.ReadLine();
                        Console.WriteLine(controller.RemoveStudentByName(studentName));
                        break;
                    case 4:
                        Console.Write("Enter student' name: ");
                        string findStudentName = Console.ReadLine();
                        Console.WriteLine(controller.FindStudent(findStudentName));
                        break;
                    default:
                        Console.WriteLine("Exit the program!");
                        break;
                };
            }
            while (choice == 1 || choice == 2 || choice == 3 || choice == 4);
        }
    }
}
