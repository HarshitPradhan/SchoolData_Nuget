using System;
using System.Collections.Generic;
using System.Text;
namespace SchoolData_Nuget
{
    class SchoolData
    {
        public static void Do()
        {
            while (true)
            {
                Console.WriteLine("Choose Options");
                Console.WriteLine("1.Add Student 2.Add Teacher 3.Add Subject 4.Display Students List 5.Display Teachers List 6.Display Subjects List 7.Exit");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    StudentData.AddStudent();
                    Console.WriteLine("Student Added Successfully");
                }
                else if (op == 2)
                {
                    TeacherData.AddTeacher();
                    Console.WriteLine("Teacher Added Successfully");
                }
                else if (op == 3)
                {
                    SubjectData.AddSubject();
                    Console.WriteLine("Subject Added Successfully");
                }
                else if (op == 4)
                {
                    Console.WriteLine("Students Data");
                    List<Student> stu = StudentData.GetStudentList();
                    if (stu.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Student s in stu)
                            Console.WriteLine("Name of the student: " + s.GetName() + "\t Class And Section: " + s.GetClassAndSection());
                }
                else if (op == 5)
                {
                    Console.WriteLine("Teachers Data");
                    List<Teacher> te = TeacherData.GetTeacherList();
                    if (te.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Teacher s in te)
                            Console.WriteLine("Name of the teacher: " + s.GetName() + "\t Class And Section: " + s.GetClassAndSection());
                }
                else if (op == 6)
                {
                    Console.WriteLine("Subjects Data");
                    List<Subject> sub = SubjectData.GetSubjectList();
                    if (sub.Count == 0)
                        Console.WriteLine("No data");
                    else
                        foreach (Subject s in sub)
                            Console.WriteLine("Name of the subject: " + s.GetName() + "\t Class And Section: " + s.GetSubjectCode());
                }
                else
                    break;
            }
        }
    }
}