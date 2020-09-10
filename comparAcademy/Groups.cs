using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparAcademy
{
    class Groups
    {
        public List<Student> StudentList;
        public List<Teacher> TeacherList;
        public List<Lessons> LessonList;
        public Groups()
        {
            StudentList = new List<Student>();
            LessonList = new List<Lessons>();
            Lessons programming = new Lessons("Programming");
            Lessons designe = new Lessons("Designe");
            LessonList.Add(designe);
            LessonList.Add(programming);

        }



        public void AddStudent()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's name:");
            string name = Console.ReadLine();
           
            if (name.Length > 2)
            {
                Student stu = new Student(name);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nStudent was addded successfully");
            }
        }

        public void AddStudentEmail()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's email:");
            string email = Console.ReadLine();

            if (email.Contains("@"))
            {
                Student stu = new Student(email);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEmail was addded successfully");
            }else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, write true email!");
            }
        }


        public void AddStudentPhone()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's phone number:");
            int phone = Int32.Parse(Console.ReadLine());
                Student stu = new Student(phone);
                StudentList.Add(stu);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPhone was addded successfully");
         
        }

        public void AddTeacher()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write teacher's name:");
            string name = Console.ReadLine();

            if (name.Length > 2)
            {
                Teacher tea = new Teacher(name);
                TeacherList.Add(tea);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTeacher was addded successfully");
            }
        }


        public void AddTeacherEmail()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's name:");
            string email = Console.ReadLine();

            if (email.Contains("@"))
            {
                Teacher tea = new Teacher(email);
                TeacherList.Add(tea);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTeacher's email was addded successfully");
            }
        }

        public void AddTeacherPhone()
        {
            Console.WriteLine("\n*********************");
            Console.Write("Please write student's name:");
            int phone  = Int32.Parse(Console.ReadLine());

                Teacher tea = new Teacher(phone);
                TeacherList.Add(tea);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nTeacher's phone was addded successfully");
            
        }
        public void AddStudentInfo()
        {
            if (StudentList.Count > 0)
            {
                Student selectedStudent = null;
                foreach (Student stu in StudentList)
                {
                    Console.WriteLine("Id:{0},Name:{1}, Email:{2},Phone: {3}", stu.Id, stu.FullName,stu.Email,stu.PhoneNumber);
                }
            Start:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please,Select student's by Id: ");
                string stuId = Console.ReadLine();
                int id;
                bool correctId = false;
                if (int.TryParse(stuId, out id))
                {
                    
                    foreach (Student stu in StudentList)
                    {
                        if (stu.Id == id)
                        {
                            correctId = true;
                            selectedStudent = stu;
                            break;
                        }
                    }
                   
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nWaring: Please,don't input a word");
                    goto Start;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWaring: Student not found");
            }

        }

    }
}
