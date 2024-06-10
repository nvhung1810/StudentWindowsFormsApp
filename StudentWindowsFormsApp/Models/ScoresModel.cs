using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWindowsFormsApp.Models
{
    internal class ScoresModel
    {
        public int IdScores { get; set; }
        public string StudentName { get; set; }
        public int Math { get; set; }
        public int BasicTechnology { get; set; }
        public int Physics { get; set; }
        public int NetTechnology {  get; set; }
        public int GeneralLaw {  get; set; }
        public int English { get; set; }
        public int ImageProcessing { get; set; }
        public int IdStudent { get; set; }
    }
}
