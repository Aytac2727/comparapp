using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Groups group = new Groups();
            string userInput;
            int input;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please select one of the bellow\n");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add student's email");
                Console.WriteLine("3.Add student's phone");
                Console.WriteLine("4.Show student's information and add group");
                Console.WriteLine("5.Add Teacher");
                Console.WriteLine("6.Add Teacher's email");
                Console.WriteLine("7.Add teacher's phone");
                Console.WriteLine("8. Add teacher's info");

                Console.Write(">>>>>>>>");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out input))
                {
                    switch (input)
                    {
                        case 1:
                            group.AddStudent();
                            break;
                        case 2:
                            group.AddStudentEmail();
                            break;
                        case 3:
                            group.AddStudentPhone();
                            break;
                        case 4: 
                            group.AddStudentInfo();
                            break;
                        case 5:
                            group.AddTeacher();
                            break;
                        case 6:
                            group.AddTeacherEmail();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warning:Please write numeric number\n");
                }
            } while (userInput != "5");
        }
    }
}
