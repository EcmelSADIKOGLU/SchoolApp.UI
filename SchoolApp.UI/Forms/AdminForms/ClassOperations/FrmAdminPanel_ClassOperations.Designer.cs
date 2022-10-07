namespace SchoolApp.UI.Forms.AdminForms.ClassOperations
{
    partial class FrmAdminPanel_ClassOperations
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
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnClassTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(50, 57);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(223, 55);
            this.btnUpdateClass.TabIndex = 0;
            this.btnUpdateClass.Text = "Sınıf Güncelle";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(50, 131);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(223, 55);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "Sınıf Ekle";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnClassTeachers
            // 
            this.btnClassTeachers.Location = new System.Drawing.Point(50, 204);
            this.btnClassTeachers.Name = "btnClassTeachers";
            this.btnClassTeachers.Size = new System.Drawing.Size(223, 55);
            this.btnClassTeachers.TabIndex = 2;
            this.btnClassTeachers.Text = "Sınıf Öğretmenleri";
            this.btnClassTeachers.UseVisualStyleBackColor = true;
            this.btnClassTeachers.Click += new System.EventHandler(this.btnClassTeachers_Click);
            // 
            // FrmAdminPanel_ClassOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 327);
            this.Controls.Add(this.btnClassTeachers);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnUpdateClass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel_ClassOperations";
            this.Text = "FrmAdminPanel_ClassOperations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnClassTeachers;
    }
}