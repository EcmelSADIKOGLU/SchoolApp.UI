namespace SchoolApp.UI.Forms.AdminForms.StudentOperations
{
    partial class FrmAdminPanel_UpdateStudent
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
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.btnUpdateSurname = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(258, 84);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(83, 37);
            this.btnGetStudent.TabIndex = 0;
            this.btnGetStudent.Text = "Bul";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(129, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(212, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numara :";
            // 
            // cbbClass
            // 
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Location = new System.Drawing.Point(129, 228);
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(212, 33);
            this.cbbClass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 30);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyadı :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(129, 188);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(212, 30);
            this.txtSurname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sınıfı :";
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(347, 144);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(106, 33);
            this.btnUpdateName.TabIndex = 10;
            this.btnUpdateName.Text = "Güncelle";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSurname
            // 
            this.btnUpdateSurname.Location = new System.Drawing.Point(347, 188);
            this.btnUpdateSurname.Name = "btnUpdateSurname";
            this.btnUpdateSurname.Size = new System.Drawing.Size(106, 33);
            this.btnUpdateSurname.TabIndex = 11;
            this.btnUpdateSurname.Text = "Güncelle";
            this.btnUpdateSurname.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(347, 228);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(106, 33);
            this.btnUpdateClass.TabIndex = 12;
            this.btnUpdateClass.Text = "Güncelle";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            // 
            // FrmAdminPanel_UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 320);
            this.Controls.Add(this.btnUpdateClass);
            this.Controls.Add(this.btnUpdateSurname);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnGetStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel_UpdateStudent";
            this.Text = "FrmAdminPanel_UpdateStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.Button btnUpdateSurname;
        private System.Windows.Forms.Button btnUpdateClass;
    }
}