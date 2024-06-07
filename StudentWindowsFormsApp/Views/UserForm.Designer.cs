namespace StudentWindowsFormsApp.Views
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNavigateStudent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(119, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(169, 157);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.buttonNavigateStudent);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, -4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(74, 451);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNavigateStudent
            // 
            this.buttonNavigateStudent.Location = new System.Drawing.Point(3, 50);
            this.buttonNavigateStudent.Name = "buttonNavigateStudent";
            this.buttonNavigateStudent.Size = new System.Drawing.Size(69, 37);
            this.buttonNavigateStudent.TabIndex = 2;
            this.buttonNavigateStudent.Text = "Sinh vien";
            this.buttonNavigateStudent.UseVisualStyleBackColor = true;
            this.buttonNavigateStudent.UseWaitCursor = true;
            this.buttonNavigateStudent.Click += new System.EventHandler(this.buttonNavigateStudent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Khoa hoc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Diem";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Lich hoc";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Dang nhap";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ho va ten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngay sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ma giang vien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chuyen nganh";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(223, 190);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Nguyen Van A";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Location = new System.Drawing.Point(223, 309);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(47, 13);
            this.labelMajor.TabIndex = 8;
            this.labelMajor.Text = "Example";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(223, 281);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(67, 13);
            this.labelUserId.TabIndex = 9;
            this.labelUserId.Text = "1911060221";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(223, 251);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.labelDateOfBirth.TabIndex = 10;
            this.labelDateOfBirth.Text = "20/01/2001";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(223, 218);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(104, 13);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "example@gmail.com";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(716, 443);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNavigateStudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelEmail;
    }
}