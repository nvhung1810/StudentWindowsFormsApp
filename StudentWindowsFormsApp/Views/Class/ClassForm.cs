using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Models;
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

namespace StudentWindowsFormsApp.Views.Class
{
    public partial class ClassForm : Form
    {
        private ClassController classController;
        private FacultyController facultyController;

        public ClassForm()
        {
            InitializeComponent();
            facultyController = new FacultyController();
            classController = new ClassController();
        }

        private async void ClassForm_Load(object sender, EventArgs e)
        {
            FormHelper.CenterForm(this);
            try
            {
                List<FacultyModel> faculties = await facultyController.GetAllFaculty();
                LoadData();
                comboBoxFaculty.DataSource = faculties;
                comboBoxFaculty.DisplayMember = "Name";
                comboBoxFaculty.ValueMember = "IdFaculty";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            int selected = (int)comboBoxFaculty.SelectedValue;
            string name = comboBoxFaculty.Text;

            ClassModel classModel = new ClassModel
            {
                Name = textBoxName.Text,
                Quantity = int.Parse(textBoxQuantity.Text),
                IdFaculty = selected,
            };

            try
            {
                bool res = await classController.AddClass(classModel);

                if (res)
                {
                    LoadData();
                    MessageBox.Show("Tạo thông tin lớp thành công");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
        }

        private async void LoadData()
        {
            List<ClassModel> classList = await classController.GetAll();
            var bindingList = new BindingList<ClassModel>(classList);
            var source = new BindingSource(bindingList, null);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdClass",
                HeaderText = "ID Lớp"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Tên Lớp"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Quantity",
                HeaderText = "SLSV"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IdFaculty",
                HeaderText = "Id Khoa"
            });

            dataGridView.DataSource = source;
            dataGridView.Refresh();
        }


        private void ClearInput()
        {
            textBoxName.Clear();
            textBoxQuantity.Clear();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());

                // Show confirmation dialog
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?",
                                                            "Xác nhận xóa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Proceed with delete if Yes is clicked
                        bool res = await classController.DeleteClass(id);

                        if (res)
                        {
                            LoadData();
                            MessageBox.Show("Xóa lớp thành công");
                            ClearInput();
                        }
                        else
                        {
                            MessageBox.Show("Xóa lớp thất bại");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                        MessageBox.Show("Đã xảy ra lỗi trong quá trình xóa lớp.");
                    }
                }
                // No action needed if No is clicked
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để xóa");
            }
        }


        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Dữ liệu hiện tại không phù hợp để cập nhật.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int id = int.Parse(selectedRow.Cells[0].Value.ToString());
            int selected = (int)comboBoxFaculty.SelectedValue;

            ClassModel classModel = new ClassModel
            {
                IdClass = id,
                Name = textBoxName.Text,
                Quantity = int.Parse(textBoxQuantity.Text),
                IdFaculty = selected,
            };

            try
            {
                bool res = await classController.UpdateClass(classModel);

                if (res)
                {
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin lớp học thành công");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            textBoxName.Text = selectedRow.Cells[1].Value?.ToString();
            textBoxQuantity.Text = selectedRow.Cells[2].Value?.ToString();
            var idFacultyValue = selectedRow.Cells[3].Value;

            if (idFacultyValue != null)
            {
                comboBoxFaculty.SelectedValue = idFacultyValue;
            }
        }

        private async void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            try
            {
                List<ClassModel> classList = await classController.SearchClass(name);
                dataGridView.DataSource = new BindingList<ClassModel>(classList);
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void buttonNavigateStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentsForm studentForm = new StudentsForm();
            studentForm.ShowDialog();
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

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
