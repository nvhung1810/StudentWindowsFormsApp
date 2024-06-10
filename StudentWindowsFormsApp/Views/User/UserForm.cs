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
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            FormHelper.CenterForm(this);
            UserController userController = new UserController();

            User user = await userController.GetUserById(1);

            if (user != null)
            {
                labelName.Text = user.Name;
                labelEmail.Text = user.Email;
                labelDateOfBirth.Text = user.DateOfBirth;
                labelUserId.Text = user.UserId;
                labelMajor.Text = user.Major;

                await LoadUserImageAsync(user.ImgUrl);
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private async Task LoadUserImageAsync(string imageUrl)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = await webClient.DownloadDataTaskAsync(imageUrl);

                    if (pictureBox.InvokeRequired)
                    {
                        pictureBox.Invoke(new Action(() =>
                        {
                            Image image = Image.FromStream(new MemoryStream(imageBytes));
                            pictureBox.Image = image;
                        }));
                    }
                    else
                    {
                        Image image = Image.FromStream(new MemoryStream(imageBytes));
                        pictureBox.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle image loading errors gracefully
                Console.WriteLine($"Error loading image: {ex.Message}");
                pictureBox.Image = null; // Or set a default image
            }
        }

        private void buttonNavigateStudent_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm(); 
            studentsForm.ShowDialog();
        }

        private void buttonNavigateStudent_Click_1(object sender, EventArgs e)
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
