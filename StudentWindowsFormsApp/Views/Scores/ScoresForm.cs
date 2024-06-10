using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Models;
using StudentWindowsFormsApp.Views.Class;
using StudentWindowsFormsApp.Views.Faculty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp.Views.Scores
{
    public partial class ScoresForm : Form
    {
        private readonly ScoresController scoresController;
        private readonly StudentController studentController;
        public ScoresForm()
        {
            InitializeComponent();
            scoresController = new ScoresController();
            studentController = new StudentController();
        }

        private async void ScoresForm_Load(object sender, EventArgs e)
        {
            FormHelper.CenterForm(this);
            List<Student> students = await studentController.GetAllStudentAsync();
            comboBoxStudent.DataSource = students;
            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "IdStudent";
            LoadData();
        }

        private async void LoadData()
        {
            List<ScoresModel> scores = await scoresController.GetAll();
            dataGridView.DataSource = new BindingList<ScoresModel>(scores);
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Refresh();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            int selected = (int)comboBoxStudent.SelectedValue;

            ScoresModel scoresModel = new ScoresModel
            {
                Math = int.Parse(textBoxMath.Text),
                BasicTechnology = int.Parse(textBoxBasicTechnology.Text),
                Physics = int.Parse(textBoxPhysics.Text),
                NetTechnology = int.Parse(textBoxNetTechnology.Text),
                GeneralLaw = int.Parse(textBoxLaw.Text),
                English = int.Parse(textBoxEnglish.Text),
                ImageProcessing = int.Parse(textBoxImage.Text),
                IdStudent = selected
            };

            bool res = await scoresController.AddScore(scoresModel);

            if (res)
            {
                LoadData();
                MessageBox.Show("Tạo thông tin lớp thành công");
                ClearInput();
            }
        }

        private void ClearInput()
        {
            textBoxMath.Clear();
            textBoxBasicTechnology.Clear();
            textBoxPhysics.Clear();
            textBoxNetTechnology.Clear();
            textBoxLaw.Clear();
            textBoxEnglish.Clear();
            textBoxImage.Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells["IdScores"].Value.ToString());

                bool res = await scoresController.DeleteScore(id);

                if (res)
                {
                    LoadData();
                    MessageBox.Show("Xóa điểm thành công");
                    ClearInput();
                }
           
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells["IdStudent"].Value.ToString());
            int selected = (int)comboBoxStudent.SelectedValue;

            ScoresModel scoresModel = new ScoresModel
            {
                IdScores = id,
                Math = int.Parse(textBoxMath.Text),
                BasicTechnology = int.Parse(textBoxBasicTechnology.Text),
                Physics = int.Parse(textBoxPhysics.Text),
                NetTechnology = int.Parse(textBoxNetTechnology.Text),
                GeneralLaw = int.Parse(textBoxLaw.Text),
                English = int.Parse(textBoxEnglish.Text),
                ImageProcessing = int.Parse(textBoxImage.Text),
                IdStudent = selected
            };

            bool res = await scoresController.UpdateScores(scoresModel);

            if (res)
            {
                LoadData();
                MessageBox.Show("Cập nhật thông tin điểm thành công");
                ClearInput();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                FillData(selectedRow);
            }
        }

        private void FillData(DataGridViewRow selectedRow)
        {
            textBoxMath.Text = selectedRow.Cells["Math"].Value?.ToString();
            textBoxBasicTechnology.Text = selectedRow.Cells["BasicTechnology"].Value?.ToString();
            textBoxPhysics.Text = selectedRow.Cells["Physics"].Value?.ToString();
            textBoxNetTechnology.Text = selectedRow.Cells["NetTechnology"].Value?.ToString();
            textBoxLaw.Text = selectedRow.Cells["GeneralLaw"].Value?.ToString();
            textBoxEnglish.Text = selectedRow.Cells["English"].Value?.ToString();
            textBoxImage.Text = selectedRow.Cells["ImageProcessing"].Value?.ToString();
            var idFacultyValue = selectedRow.Cells["IdStudent"].Value;

            if (idFacultyValue != null)
            {
                comboBoxStudent.SelectedValue = idFacultyValue;
            }
            Console.WriteLine(selectedRow.Cells["IdStudent"].Value?.ToString());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();  
        }

        private void buttonNavigateStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsForm studentsForm = new StudentsForm(); 
            studentsForm.ShowDialog();
        }

        private void buttonClassForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassForm classForm = new ClassForm();
            classForm.ShowDialog();
        }

        private void buttonScoresManagement_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFacultyManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyForm facultyForm = new FacultyForm();
            facultyForm.ShowDialog();
        }
    }
}
