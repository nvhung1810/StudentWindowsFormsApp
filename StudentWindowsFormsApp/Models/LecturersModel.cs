using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    internal class LecturersModel
    {
        public int IdLecturers { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int IdFaculty { get; set; }
        public string Degree { get; set; }
        public string Specialization { get; set; }
    }
}
