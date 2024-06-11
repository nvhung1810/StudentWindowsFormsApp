using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Models;
using StudentWindowsFormsApp.Views.Class;
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

namespace StudentWindowsFormsApp.Views.Faculty
{
    public partial class FacultyForm : Form
    {
        private readonly FacultyController controller;
        public FacultyForm()
        {
            InitializeComponent();
            controller = new FacultyController();
        }

        private async void FacultyForm_Load(object sender, EventArgs e)
        {
            FormHelper.CenterForm(this);
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void buttonSaveFaculty_Click(object sender, EventArgs e)
        {
            FacultyModel faculty = new FacultyModel
            {
                Name = textBoxFaculty.Text,
                Phone = textBoxPhone.Text,
                Address = textBoxAddress.Text,
            };

            try
            {
                bool res = await controller.AddFaculty(faculty);

                if (res)
                {
                    LoadData();
                    MessageBox.Show("Tạo thông tin khoa thành công");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add faculty faild" + ex.Message);
            }
        }

        private async void LoadData()
        {
            List<FacultyModel> faculties = await controller.GetAllFaculty();

            var bindingList = new BindingList<FacultyModel>(faculties);
            var source = new BindingSource(bindingList, null);

            dataGridViewFaculty.AutoGenerateColumns = false;

            dataGridViewFaculty.Columns.Clear();

            dataGridViewFaculty.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdFaculty",
                HeaderText = "ID Khoa"
            });
            dataGridViewFaculty.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Tên Khoa"
            });
            dataGridViewFaculty.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Phone",
                HeaderText = "SDT"
            });
            dataGridViewFaculty.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Address",
                HeaderText = "Địa chỉ"
            });

            dataGridViewFaculty.DataSource = source;

            dataGridViewFaculty.Refresh();
        }


        private void ClearInput()
        {
            textBoxFaculty.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFaculty.SelectedRows.Count == 0)
            {
                MessageBox.Show("Dữ liệu hiện tại không phù hợp để cập nhật.");
                return;
            }
            // Check if a row is selected
            if (dataGridViewFaculty.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFaculty.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();

                // Show confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?",
                                                            "Xác nhận xóa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Proceed with delete if Yes is clicked
                        bool res = await controller.DeleteFaculty(int.Parse(id));

                        if (res)
                        {
                            List<FacultyModel> faculties = await controller.GetAllFaculty();
                            dataGridViewFaculty.DataSource = new BindingList<FacultyModel>(faculties);
                            MessageBox.Show("Xóa thông tin khoa thành công");
                            ClearInput();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin khoa thất bại");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa khoa.");
                    }
                }
                // No action needed if No is clicked
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa để xóa");
            }
        }


        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewFaculty.SelectedRows[0];
            string id = selectedRow.Cells[0].Value.ToString();


            FacultyModel faculty = new FacultyModel
            {
                IdFaculty = int.Parse(id),
                Name = textBoxFaculty.Text,
                Phone = textBoxPhone.Text,
                Address = textBoxAddress.Text,
            };

            try
            {
                bool res = await controller.UpdateFaculty(faculty);

                if (res)
                {
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin khoa thành công");
                    ClearInput();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Update student faield" + ex.Message);
            }
        }

        private void dataGridViewFacultys_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFaculty.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFaculty.SelectedRows[0];
                FillData(selectedRow);
            }
        }

        private void FillData(DataGridViewRow selectedRow)
        {
            Console.Write(selectedRow.Cells[1].Value);
            textBoxFaculty.Text = selectedRow.Cells[1].Value?.ToString();
            textBoxPhone.Text = selectedRow.Cells[2].Value?.ToString();
            textBoxAddress.Text = selectedRow.Cells[3].Value?.ToString();
        }

        private async void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            string nameSearch = textBoxSearch.Text;

            try
            {
                List<FacultyModel> faculties = await controller.SearchFaculty(nameSearch);
                dataGridViewFaculty.DataSource = new BindingList<FacultyModel>(faculties);
                dataGridViewFaculty.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
