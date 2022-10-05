namespace SchoolApp.UI.Forms.AdminForms
{
    partial class FrmAdminPanel
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
            this.btnStudentOperations = new System.Windows.Forms.Button();
            this.btnTeacherOperations = new System.Windows.Forms.Button();
            this.btnClassOperations = new System.Windows.Forms.Button();
            this.btnExamOperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentOperations
            // 
            this.btnStudentOperations.Location = new System.Drawing.Point(47, 62);
            this.btnStudentOperations.Name = "btnStudentOperations";
            this.btnStudentOperations.Size = new System.Drawing.Size(259, 57);
            this.btnStudentOperations.TabIndex = 0;
            this.btnStudentOperations.Text = "Öğrenci İşlemleri";
            this.btnStudentOperations.UseVisualStyleBackColor = true;
            this.btnStudentOperations.Click += new System.EventHandler(this.btnStudentOperations_Click);
            // 
            // btnTeacherOperations
            // 
            this.btnTeacherOperations.Location = new System.Drawing.Point(47, 145);
            this.btnTeacherOperations.Name = "btnTeacherOperations";
            this.btnTeacherOperations.Size = new System.Drawing.Size(259, 57);
            this.btnTeacherOperations.TabIndex = 1;
            this.btnTeacherOperations.Text = "Öğretmen İşlemleri";
            this.btnTeacherOperations.UseVisualStyleBackColor = true;
            // 
            // btnClassOperations
            // 
            this.btnClassOperations.Location = new System.Drawing.Point(47, 222);
            this.btnClassOperations.Name = "btnClassOperations";
            this.btnClassOperations.Size = new System.Drawing.Size(259, 57);
            this.btnClassOperations.TabIndex = 2;
            this.btnClassOperations.Text = "Sınıf İşlemleri";
            this.btnClassOperations.UseVisualStyleBackColor = true;
            // 
            // btnExamOperations
            // 
            this.btnExamOperations.Location = new System.Drawing.Point(47, 298);
            this.btnExamOperations.Name = "btnExamOperations";
            this.btnExamOperations.Size = new System.Drawing.Size(259, 57);
            this.btnExamOperations.TabIndex = 3;
            this.btnExamOperations.Text = "Sınav İşlemleri";
            this.btnExamOperations.UseVisualStyleBackColor = true;
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 420);
            this.Controls.Add(this.btnExamOperations);
            this.Controls.Add(this.btnClassOperations);
            this.Controls.Add(this.btnTeacherOperations);
            this.Controls.Add(this.btnStudentOperations);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel";
            this.Text = "FrmAdminPanel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentOperations;
        private System.Windows.Forms.Button btnTeacherOperations;
        private System.Windows.Forms.Button btnClassOperations;
        private System.Windows.Forms.Button btnExamOperations;
    }
}