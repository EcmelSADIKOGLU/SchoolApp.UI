namespace SchoolApp.UI.Forms.AdminForms.ClassOperations
{
    partial class FrmAdminPanel_ClassTeachers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.btnGetClass = new System.Windows.Forms.Button();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTeacher = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınıf :";
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(127, 60);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(201, 33);
            this.cbbClass.TabIndex = 2;
            // 
            // btnGetClass
            // 
            this.btnGetClass.Location = new System.Drawing.Point(229, 110);
            this.btnGetClass.Name = "btnGetClass";
            this.btnGetClass.Size = new System.Drawing.Size(99, 34);
            this.btnGetClass.TabIndex = 3;
            this.btnGetClass.Text = "Bul";
            this.btnGetClass.UseVisualStyleBackColor = true;
            // 
            // cbbBranch
            // 
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(127, 197);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(201, 33);
            this.cbbBranch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ders :";
            // 
            // btnTeacher
            // 
            this.btnTeacher.FormattingEnabled = true;
            this.btnTeacher.Location = new System.Drawing.Point(127, 246);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(201, 33);
            this.btnTeacher.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Öğretmen :";
            // 
            // btnAssing
            // 
            this.btnAssing.Location = new System.Drawing.Point(229, 297);
            this.btnAssing.Name = "btnAssing";
            this.btnAssing.Size = new System.Drawing.Size(99, 34);
            this.btnAssing.TabIndex = 8;
            this.btnAssing.Text = "Ata";
            this.btnAssing.UseVisualStyleBackColor = true;
            // 
            // FrmAdminPanel_ClassTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 476);
            this.Controls.Add(this.btnAssing);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetClass);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel_ClassTeachers";
            this.Text = "FrmAdminPanel_ClassTeachers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnGetClass;
        private System.Windows.Forms.ComboBox cbbBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox btnTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssing;
    }
}