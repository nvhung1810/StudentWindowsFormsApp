namespace StudentWindowsFormsApp.Views
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMathScores = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEnglishBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSaveStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonUpdateStudent = new System.Windows.Forms.Button();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonNavigateStudent = new System.Windows.Forms.Button();
            this.buttonClassForm = new System.Windows.Forms.Button();
            this.buttonScoresManagement = new System.Windows.Forms.Button();
            this.buttonFacultyManagement = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(510, 21);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(763, 417);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ Và Tên:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(265, 150);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(229, 22);
            this.textBoxFullName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Sinh:";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.Location = new System.Drawing.Point(264, 209);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(229, 22);
            this.textBoxGender.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(264, 240);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(229, 22);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(265, 271);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(229, 22);
            this.textBoxAddress.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ:";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(265, 300);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(229, 22);
            this.textBoxClass.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lớp:";
            // 
            // textBoxMathScores
            // 
            this.textBoxMathScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMathScores.Location = new System.Drawing.Point(265, 331);
            this.textBoxMathScores.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxMathScores.Name = "textBoxMathScores";
            this.textBoxMathScores.Size = new System.Drawing.Size(229, 22);
            this.textBoxMathScores.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Điểm toán";
            // 
            // textBoxEnglishBox
            // 
            this.textBoxEnglishBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnglishBox.Location = new System.Drawing.Point(266, 364);
            this.textBoxEnglishBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEnglishBox.Name = "textBoxEnglishBox";
            this.textBoxEnglishBox.Size = new System.Drawing.Size(229, 22);
            this.textBoxEnglishBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Điểm Anh:";
            // 
            // buttonSaveStudent
            // 
            this.buttonSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveStudent.Image")));
            this.buttonSaveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveStudent.Location = new System.Drawing.Point(187, 411);
            this.buttonSaveStudent.Name = "buttonSaveStudent";
            this.buttonSaveStudent.Size = new System.Drawing.Size(87, 28);
            this.buttonSaveStudent.TabIndex = 19;
            this.buttonSaveStudent.Text = "    Tạo Mới";
            this.buttonSaveStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveStudent.UseVisualStyleBackColor = true;
            this.buttonSaveStudent.Click += new System.EventHandler(this.buttonSaveStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteStudent.Image")));
            this.buttonDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(414, 411);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(65, 27);
            this.buttonDeleteStudent.TabIndex = 20;
            this.buttonDeleteStudent.Text = "Xóa";
            this.buttonDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonUpdateStudent
            // 
            this.buttonUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdateStudent.Image")));
            this.buttonUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdateStudent.Location = new System.Drawing.Point(295, 411);
            this.buttonUpdateStudent.Name = "buttonUpdateStudent";
            this.buttonUpdateStudent.Size = new System.Drawing.Size(95, 27);
            this.buttonUpdateStudent.TabIndex = 21;
            this.buttonUpdateStudent.Text = "Cập Nhật";
            this.buttonUpdateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdateStudent.UseVisualStyleBackColor = true;
            this.buttonUpdateStudent.Click += new System.EventHandler(this.buttonUpdateStudent_Click);
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(265, 181);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 22;
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchStudent.Location = new System.Drawing.Point(176, 105);
            this.textBoxSearchStudent.MaxLength = 40000;
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(253, 22);
            this.textBoxSearchStudent.TabIndex = 23;
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.BackColor = System.Drawing.Color.OldLace;
            this.buttonSearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchStudent.Image")));
            this.buttonSearchStudent.Location = new System.Drawing.Point(426, 104);
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.Size = new System.Drawing.Size(66, 25);
            this.buttonSearchStudent.TabIndex = 24;
            this.buttonSearchStudent.UseVisualStyleBackColor = false;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(180, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "QUẢN LÝ HỌC SINH";
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 461);
            this.flowLayoutPanel1.TabIndex = 26;
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
            this.buttonFacultyManagement.Click += new System.EventHandler(this.buttonFacultyManagement_Click);
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
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSearchStudent);
            this.Controls.Add(this.textBoxSearchStudent);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.buttonUpdateStudent);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.buttonSaveStudent);
            this.Controls.Add(this.textBoxEnglishBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMathScores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMathScores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEnglishBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSaveStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonUpdateStudent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonNavigateStudent;
        private System.Windows.Forms.Button buttonClassForm;
        private System.Windows.Forms.Button buttonScoresManagement;
        private System.Windows.Forms.Button buttonFacultyManagement;
        private System.Windows.Forms.Button buttonLogout;
    }
}