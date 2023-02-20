using System;
using System.Collections.Generic;

namespace Student_Management_ASM1_1651
{
    class StudentView
    {
        public void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
            }
        }
    }
}
