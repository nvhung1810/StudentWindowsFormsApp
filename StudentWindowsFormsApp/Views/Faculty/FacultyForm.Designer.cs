namespace StudentWindowsFormsApp.Views.Faculty
{
    partial class FacultyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyForm));
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFaculty = new System.Windows.Forms.DataGridView();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonNavigateStudent = new System.Windows.Forms.Button();
            this.buttonClassForm = new System.Windows.Forms.Button();
            this.buttonScoresManagement = new System.Windows.Forms.Button();
            this.buttonFacultyManagement = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(293, 163);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(198, 22);
            this.textBoxPhone.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(206, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 33);
            this.label9.TabIndex = 72;
            this.label9.Text = "QUẢN LÝ KHOA";
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.BackColor = System.Drawing.Color.OldLace;
            this.buttonSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchStudent.Image")));
            this.buttonSearchStudent.Location = new System.Drawing.Point(425, 53);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(66, 25);
            this.buttonSearchStudent.TabIndex = 71;
            this.buttonSearchStudent.UseVisualStyleBackColor = false;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(177, 54);
            this.textBoxSearch.MaxLength = 40000;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(251, 22);
            this.textBoxSearch.TabIndex = 70;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(292, 395);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(95, 27);
            this.buttonUpdate.TabIndex = 69;
            this.buttonUpdate.Text = "Cập Nhật";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(411, 395);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 27);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(184, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 28);
            this.buttonSave.TabIndex = 67;
            this.buttonSave.Text = "    Tạo Mới";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveFaculty_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(292, 193);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(198, 22);
            this.textBoxAddress.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên Khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Địa Chỉ:";
            // 
            // dataGridViewFaculty
            // 
            this.dataGridViewFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculty.Location = new System.Drawing.Point(509, 13);
            this.dataGridViewFaculty.Name = "dataGridViewFaculty";
            this.dataGridViewFaculty.Size = new System.Drawing.Size(669, 425);
            this.dataGridViewFaculty.TabIndex = 51;
            this.dataGridViewFaculty.SelectionChanged += new System.EventHandler(this.dataGridViewFacultys_SelectionChanged);
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFaculty.Location = new System.Drawing.Point(292, 129);
            this.textBoxFaculty.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(198, 22);
            this.textBoxFaculty.TabIndex = 75;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.buttonHome);
            this.flowLayoutPanel1.Controls.Add(this.buttonNavigateStudent);
            this.flowLayoutPanel1.Controls.Add(this.buttonClassForm);
            this.flowLayoutPanel1.Controls.Add(this.buttonScoresManagement);
            this.flowLayoutPanel1.Controls.Add(this.buttonFacultyManagement);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogout);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 461);
            this.flowLayoutPanel1.TabIndex = 76;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(3, 7);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(137, 37);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Trang Chủ";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.UseWaitCursor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonNavigateStudent
            // 
            this.buttonNavigateStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavigateStudent.Image")));
            this.buttonNavigateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavigateStudent.Location = new System.Drawing.Point(3, 50);
            this.buttonNavigateStudent.Name = "buttonNavigateStudent";
            this.buttonNavigateStudent.Size = new System.Drawing.Size(137, 37);
            this.buttonNavigateStudent.TabIndex = 2;
            this.buttonNavigateStudent.Text = "Quản Lý Sinh Viên";
            this.buttonNavigateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNavigateStudent.UseVisualStyleBackColor = true;
            this.buttonNavigateStudent.UseWaitCursor = true;
            this.buttonNavigateStudent.Click += new System.EventHandler(this.buttonNavigateStudent_Click);
            // 
            // buttonClassForm
            // 
            this.buttonClassForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonClassForm.Image")));
            this.buttonClassForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClassForm.Location = new System.Drawing.Point(3, 93);
            this.buttonClassForm.Name = "buttonClassForm";
            this.buttonClassForm.Size = new System.Drawing.Size(137, 37);
            this.buttonClassForm.TabIndex = 3;
            this.buttonClassForm.Text = "Quản Lý Lớp";
            this.buttonClassForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClassForm.UseVisualStyleBackColor = true;
            this.buttonClassForm.UseWaitCursor = true;
            this.buttonClassForm.Click += new System.EventHandler(this.buttonClassForm_Click);
            // 
            // buttonScoresManagement
            // 
            this.buttonScoresManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonScoresManagement.Image")));
            this.buttonScoresManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonScoresManagement.Location = new System.Drawing.Point(3, 136);
            this.buttonScoresManagement.Name = "buttonScoresManagement";
            this.buttonScoresManagement.Size = new System.Drawing.Size(137, 37);
            this.buttonScoresManagement.TabIndex = 4;
            this.buttonScoresManagement.Text = "Quản Lý Điểm";
            this.buttonScoresManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonScoresManagement.UseVisualStyleBackColor = true;
            this.buttonScoresManagement.UseWaitCursor = true;
            this.buttonScoresManagement.Click += new System.EventHandler(this.buttonScoresManagement_Click);
            // 
            // buttonFacultyManagement
            // 
            this.buttonFacultyManagement.Image = ((System.Drawing.Image)(resources.GetObject("buttonFacultyManagement.Image")));
            this.buttonFacultyManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFacultyManagement.Location = new System.Drawing.Point(3, 179);
            this.buttonFacultyManagement.Name = "buttonFacultyManagement";
            this.buttonFacultyManagement.Size = new System.Drawing.Size(137, 37);
            this.buttonFacultyManagement.TabIndex = 5;
            this.buttonFacultyManagement.Text = "Quản Lý Khoa";
            this.buttonFacultyManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFacultyManagement.UseVisualStyleBackColor = true;
            this.buttonFacultyManagement.UseWaitCursor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(3, 222);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 37);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Đăng Xuất";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.UseWaitCursor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxFaculty);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSearchStudent);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewFaculty);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculty)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFaculty;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonNavigateStudent;
        private System.Windows.Forms.Button buttonClassForm;
        private System.Windows.Forms.Button buttonScoresManagement;
        private System.Windows.Forms.Button buttonFacultyManagement;
        private System.Windows.Forms.Button buttonLogout;
    }
}