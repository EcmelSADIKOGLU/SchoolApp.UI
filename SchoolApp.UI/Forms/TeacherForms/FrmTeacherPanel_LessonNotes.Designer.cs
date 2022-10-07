namespace SchoolApp.UI.Forms.TeacherForms
{
    partial class FrmTeacherPanel_LessonNotes
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
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateExam1 = new System.Windows.Forms.Button();
            this.btnUpdateExam2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(129, 51);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(225, 33);
            this.cbbClass.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(256, 90);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(98, 40);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 427);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sınıf :";
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(129, 205);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(225, 30);
            this.txtExam1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğrenci :";
            // 
            // cbbStudent
            // 
            this.cbbStudent.FormattingEnabled = true;
            this.cbbStudent.Location = new System.Drawing.Point(129, 164);
            this.cbbStudent.Name = "cbbStudent";
            this.cbbStudent.Size = new System.Drawing.Size(225, 33);
            this.cbbStudent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "1. Sınav :";
            // 
            // btnUpdateExam1
            // 
            this.btnUpdateExam1.Enabled = false;
            this.btnUpdateExam1.Location = new System.Drawing.Point(256, 241);
            this.btnUpdateExam1.Name = "btnUpdateExam1";
            this.btnUpdateExam1.Size = new System.Drawing.Size(98, 40);
            this.btnUpdateExam1.TabIndex = 8;
            this.btnUpdateExam1.Text = "Güncelle";
            this.btnUpdateExam1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExam2
            // 
            this.btnUpdateExam2.Enabled = false;
            this.btnUpdateExam2.Location = new System.Drawing.Point(256, 333);
            this.btnUpdateExam2.Name = "btnUpdateExam2";
            this.btnUpdateExam2.Size = new System.Drawing.Size(98, 40);
            this.btnUpdateExam2.TabIndex = 11;
            this.btnUpdateExam2.Text = "Güncelle";
            this.btnUpdateExam2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "2. Sınav :";
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(129, 297);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(225, 30);
            this.txtExam2.TabIndex = 9;
            // 
            // FrmTeacherPanel_LessonNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 475);
            this.Controls.Add(this.btnUpdateExam2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExam2);
            this.Controls.Add(this.btnUpdateExam1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbStudent);
            this.Controls.Add(this.txtExam1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbbClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTeacherPanel_LessonNotes";
            this.Text = "FrmTeacherPanel_LessonNotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateExam1;
        private System.Windows.Forms.Button btnUpdateExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExam2;
    }
}