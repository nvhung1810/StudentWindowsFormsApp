using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp.Views
{
    public partial class StudentsForm : Form
    {
        private readonly StudentController studentController;

        public StudentsForm()
        {
            InitializeComponent();
            studentController = new StudentController();
        }

        private async void StudentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = await studentController.GetAllStudentAsync();

                foreach (var student in students)
                {
                    Console.WriteLine($"Id: {student.Id}, FullName: {student.FullName}");
                }

                // Bind the list to the DataGridView
                dataGridViewStudent.DataSource = new BindingList<Student>(students);

                // Ensure columns are generated
                dataGridViewStudent.AutoGenerateColumns = true;
                dataGridViewStudent.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
      
    }
}
