using System;
using System.Collections.Generic;
using System.Text;
namespace SchoolData_Nuget
{
    struct Student
    {
        public string Name;
        public string ClassAndSection;
        public string GetName()
        {
            return Name;
        }
        public string GetClassAndSection()
        {
            return ClassAndSection;
        }
    }
    static class StudentData
    {
        private static List<Student> students = new List<Student>();
        public static void AddStudent()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class And Section");
            string cls = Console.ReadLine();
            Student s = new Student();
            s.Name = name;
            s.ClassAndSection = cls;
            students.Add(s);
        }
        public static List<Student> GetStudentList()
        {
            return students;
        }
    }

}