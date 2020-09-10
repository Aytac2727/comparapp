using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparAcademy
{
    class Lessons
    {
        public string LessonName { get; set; }
        public List <Teacher> TeacherList { get; set; }
        public List<Student> StudentList { get; set; }
        private static int lesId = 1;


        public Lessons(string LessonName)
        {
            TeacherList = new List<Teacher>();
            StudentList = new List<Student>();
            this.LessonName = LessonName;
            lesId++;
        }



    }
}
