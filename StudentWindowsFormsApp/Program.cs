﻿using StudentWindowsFormsApp.Views;
using StudentWindowsFormsApp.Views.Class;
using StudentWindowsFormsApp.Views.Faculty;
using StudentWindowsFormsApp.Views.Scores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentsForm());
        }
    }
}
