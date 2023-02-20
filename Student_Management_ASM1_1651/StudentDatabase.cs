using System.Collections.Generic;
using System.Linq;

namespace Student_Management_ASM1_1651
{
    class StudentDatabase
    {
        private List<Student> students = new List<Student>();
        private static StudentDatabase instance;
        public static StudentDatabase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDatabase();
                }
                return instance;
            }
        }
        private StudentDatabase()
        {

        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudentByName(string name)
        {
            return students.FirstOrDefault(s => s.Name == name);
        }
    }
}
