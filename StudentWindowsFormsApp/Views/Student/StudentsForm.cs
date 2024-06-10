using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Models;
using StudentWindowsFormsApp.Views.Class;
using StudentWindowsFormsApp.Views.Faculty;
using StudentWindowsFormsApp.Views.Scores;
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
        private readonly FacultyController facultyController;
        private readonly ClassController classController;

        public StudentsForm()
        {
            InitializeComponent();
            studentController = new StudentController();
            facultyController = new FacultyController();
            classController = new ClassController();
        }

        private async void StudentsForm_Load(object sender, EventArgs e)
        {
            FormHelper.CenterForm(this);
            try
            {
                List<Student> students = await studentController.GetAllStudentAsync();
                dataGridViewStudent.DataSource = new BindingList<Student>(students);
                dataGridViewStudent.AutoGenerateColumns = true;
                dataGridViewStudent.Refresh();
                List<ClassModel> classModels = await classController.GetAll();
                comboBoxClass.DataSource = classModels;
                comboBoxClass.DisplayMember = "Name";
                comboBoxClass.ValueMember = "IdClass";
                List<FacultyModel> facultyModels = await facultyController.GetAllFaculty();
                comboBoxFaculty.DataSource = facultyModels;
                comboBoxFaculty.DisplayMember = "Name";
                comboBoxFaculty.ValueMember = "IdFaculty";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void buttonSaveStudent_Click(object sender, EventArgs e)
        {
            int idClassSelected = (int)comboBoxClass.SelectedValue;
            int idFacultySelected = (int)comboBoxFaculty.SelectedValue;

            Student student = new Student
            {
                FullName = textBoxFullName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd"),
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                Class = textBoxClass.Text,
                Gender = textBoxGender.Text,
                Gpa = int.Parse(textBoxGpa.Text),
                Phone = int.Parse(textBoxPhone.Text),
                IdClass = idClassSelected,
                IdFaculty = idFacultySelected
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
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            textBoxClass.Clear();
            textBoxGpa.Clear();
            textBoxEmail.Clear();
            textBoxGender.Clear();
        }

        private async void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells["IdStudent"].Value.ToString());

            Console.Write(id);

            bool res = await studentController.DeleteStudentAsync(id);

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
            int idClassSelected = (int)comboBoxClass.SelectedValue;
            int idFacultySelected = (int)comboBoxFaculty.SelectedValue;


            Student student = new Student
            {
                FullName = textBoxFullName.Text,
                DateOfBirth = dateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd"),
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                Class = textBoxClass.Text,
                Gender = textBoxGender.Text,
                Gpa = int.Parse(textBoxGpa.Text),
                Phone = int.Parse(textBoxPhone.Text),
                IdClass = idClassSelected,
                IdFaculty = idFacultySelected,
                IdStudent = int.Parse(id)

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
            textBoxPhone.Text = selectedRow.Cells["Phone"].Value?.ToString();
            textBoxAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
            textBoxClass.Text = selectedRow.Cells["Class"].Value?.ToString();
            textBoxGpa.Text = selectedRow.Cells["Gpa"].Value?.ToString();
            textBoxEmail.Text = selectedRow.Cells["Email"].Value?.ToString();
            textBoxGender.Text = selectedRow.Cells["Gender"].Value?.ToString();

            var idClass = selectedRow.Cells["IdClass"].Value;
            var idFaculty = selectedRow.Cells["IdFaculty"].Value;

            if (idClass != null && idFaculty != null)
            {
                comboBoxClass.SelectedValue = idClass;
                comboBoxFaculty.SelectedValue = idFaculty;
            }
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void buttonNavigateStudent_Click(object sender, EventArgs e)
        {

        }

        private void buttonClassForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassForm classForm = new ClassForm();
            classForm.ShowDialog();
        }

        private void buttonScoresManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScoresForm scoresForm = new ScoresForm();
            scoresForm.ShowDialog();
        }

        private void buttonFacultyManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
