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
            dataGridViewFaculty.DataSource = new BindingList<FacultyModel>(faculties);
            dataGridViewFaculty.AutoGenerateColumns = true;
            dataGridViewFaculty.Refresh();
        }

        private void ClearInput()
        {
            textBoxFaculty.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            textBoxAddress.Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewFaculty.SelectedRows[0];
            string id = selectedRow.Cells["IdFaculty"].Value.ToString();

            bool res = await controller.DeleteFaculty(int.Parse(id));

            try
            {
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
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewFaculty.SelectedRows[0];
            string id = selectedRow.Cells["IdFaculty"].Value.ToString();


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
            textBoxFaculty.Text = selectedRow.Cells["Name"].Value?.ToString();
            textBoxPhone.Text = selectedRow.Cells["Phone"].Value?.ToString();
            textBoxAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
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
    }
}
