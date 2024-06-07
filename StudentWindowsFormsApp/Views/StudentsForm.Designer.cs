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
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 207);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(801, 243);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
    }
}