using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Class {  get; set; }
        public int Gpa { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
