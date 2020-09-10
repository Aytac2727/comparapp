using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparAcademy
{
    class Teacher
    {
        public string TeacherName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Id { get; set; }
        public List <Student> StudentList { get; set; }
        public List<Lessons>LessonsList { get; set; }
        private static int stuId = 1;

        public Teacher(string TeacherName)
        {
            LessonsList = new List<Lessons>();
            StudentList = new List<Student>();
            this.TeacherName = TeacherName;
            this.Email = Email;
            Id = stuId;
            stuId++;
        }

        public Teacher (int Phone)
        {
            this.Phone = Phone;
        }



    }
}
