namespace SchoolApp.UI.Forms.AdminForms.ExamOperations
{
    partial class FrmAdminPanel_ExamOperations
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbExam1 = new System.Windows.Forms.ComboBox();
            this.cbbExam2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Birinci Sınav :";
            // 
            // cbbExam1
            // 
            this.cbbExam1.FormattingEnabled = true;
            this.cbbExam1.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cbbExam1.Location = new System.Drawing.Point(166, 60);
            this.cbbExam1.Name = "cbbExam1";
            this.cbbExam1.Size = new System.Drawing.Size(201, 33);
            this.cbbExam1.TabIndex = 3;
            // 
            // cbbExam2
            // 
            this.cbbExam2.FormattingEnabled = true;
            this.cbbExam2.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cbbExam2.Location = new System.Drawing.Point(166, 105);
            this.cbbExam2.Name = "cbbExam2";
            this.cbbExam2.Size = new System.Drawing.Size(201, 33);
            this.cbbExam2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci Sınav :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmAdminPanel_ExamOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 248);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbbExam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbExam1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel_ExamOperations";
            this.Text = "FrmAdminPanel_ExamOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbExam1;
        private System.Windows.Forms.ComboBox cbbExam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}