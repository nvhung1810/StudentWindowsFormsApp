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
                dataGridViewStudent.DataSource = new BindingList<Student>(students);
                dataGridViewStudent.AutoGenerateColumns = true;
                dataGridViewStudent.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void buttonSaveStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FullName = textBoxFullName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd"),
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                Class = textBoxClass.Text,
                Gender = textBoxGender.Text,
                Gpa = int.Parse(textBoxMathScores.Text),
                Phone = int.Parse(textBoxEnglishBox.Text),
            };

            try
            {
                bool res = await studentController.AddStudentAsync(student);

                if (res)
                {
                    List<Student> students = await studentController.GetAllStudentAsync();
                    dataGridViewStudent.DataSource = new BindingList<Student>(students);
                    MessageBox.Show("Tạo thông tin sinh viên thành công");
                    ClearInput();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add student faild");
            }
        }

        private void ClearInput()
        {
            textBoxFullName.Clear();
            dateTimePickerDateOfBirth.Value = DateTime.Today;
            textBoxGender.Clear();
            textBoxAddress.Clear();
            textBoxClass.Clear();
            textBoxMathScores.Clear();
            textBoxEnglishBox.Clear();
            textBoxEmail.Clear();
        }

        private async void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
            string id = selectedRow.Cells["IdStudent"].Value.ToString();

            bool res = await studentController.DeleteStudentAsync(int.Parse(id));

            if (res)
            {
                List<Student> students = await studentController.GetAllStudentAsync();
                dataGridViewStudent.DataSource = new BindingList<Student>(students);
                MessageBox.Show("Xóa thông tin sinh viên thành công");
                ClearInput();
            }
            else
            {
                MessageBox.Show("Xóa thông tin sinh viên thất bại");
            }
        }

        private async void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
            string id = selectedRow.Cells["IdStudent"].Value.ToString();


            Student student = new Student
            {
                IdStudent = int.Parse(id),
                FullName = textBoxFullName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd"),
                Gender = textBoxGender.Text,
                Address = textBoxAddress.Text,
                Class = textBoxClass.Text,
                Gpa = int.Parse(textBoxMathScores.Text),
                Phone = int.Parse(textBoxEnglishBox.Text),
                Email = textBoxEmail.Text,
            };

            try
            {
                bool res = await studentController.UpdateStudentAsync(student);

                if (res)
                {
                    List<Student> students = await studentController.GetAllStudentAsync();
                    dataGridViewStudent.DataSource = new BindingList<Student>(students);
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                    ClearInput();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Update student faield");
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
                FillStudentDetails(selectedRow);
            }
        }

        private void FillStudentDetails(DataGridViewRow selectedRow)
        {
            textBoxFullName.Text = selectedRow.Cells["FullName"].Value?.ToString();
            dateTimePickerDateOfBirth.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
            textBoxGender.Text = selectedRow.Cells["Gender"].Value?.ToString();
            textBoxAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
            textBoxClass.Text = selectedRow.Cells["Class"].Value?.ToString();
            textBoxMathScores.Text = selectedRow.Cells["Gpa"].Value?.ToString();
            textBoxEnglishBox.Text = selectedRow.Cells["Phone"].Value?.ToString();
            textBoxEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
        }

        private async void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            string fullNameSearch = textBoxSearchStudent.Text;
            try
            {
                List<Student> students = await studentController.SearchStudentsByFullNameAsync(fullNameSearch);
                dataGridViewStudent.DataSource = new BindingList<Student>(students);
                dataGridViewStudent.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
