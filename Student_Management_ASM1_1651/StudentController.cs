using System;

namespace Student_Management_ASM1_1651
{
    class StudentController
    {
        private StudentDatabase database;
        private StudentView view;

        public StudentController(StudentDatabase database, StudentView view)
        {
            this.database = database;
            this.view = view;
        }

        public void AddStudent(string name, int age, string email)
        {
            var student = new Student { Name = name, Age = age, Email = email };
            database.AddStudent(student);
            Console.WriteLine("Added student successfully!");
        }

        public void RemoveStudent(Student student)
        {
            database.RemoveStudent(student);
            var students = database.GetStudents();
            view.DisplayStudents(students);
        }
        public string RemoveStudentByName(string name)
        {
            var student = database.GetStudentByName(name);
            if (student != null)
            {
                database.RemoveStudent(student);
                return "Deleted student successfully!";
            }
            return "Student does not exist";

        }
        public string FindStudent(string name)
        {
            var student = database.GetStudentByName(name);
            if (student != null)
            {
                return $"Student Name: {student.Name}, Student Age: {student.Age}, Student Email: {student.Email}";
            }
            return "Student does not exist";
        }

        public void ShowAllStudents()
        {
            var students = database.GetStudents();
            view.DisplayStudents(students);
        }
    }
}
