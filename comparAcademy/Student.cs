using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparAcademy
{
    class Student
    {
        
        public string FullName { get ; set; }
        public int Id { get; private set ; }
        public string Email { get; set ; }
        public int PhoneNumber { get; set; }

        private static int stuId = 1;

        public Student (string FullName)
        {
            this.FullName = FullName;
            this.Email = Email;
            Id = stuId;
            stuId++;
        }

        public Student (int PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

    }
}
