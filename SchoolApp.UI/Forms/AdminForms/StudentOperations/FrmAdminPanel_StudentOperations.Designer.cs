﻿namespace SchoolApp.UI.Forms.AdminForms.StudentOperations
{
    partial class FrmAdminPanel_StudentOperations
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
            this.btnStudentList = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudentList
            // 
            this.btnStudentList.Location = new System.Drawing.Point(87, 68);
            this.btnStudentList.Name = "btnStudentList";
            this.btnStudentList.Size = new System.Drawing.Size(211, 50);
            this.btnStudentList.TabIndex = 0;
            this.btnStudentList.Text = "Öğrenci Listesi";
            this.btnStudentList.UseVisualStyleBackColor = true;
            this.btnStudentList.Click += new System.EventHandler(this.btnStudentList_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(87, 140);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(211, 50);
            this.btnStudentAdd.TabIndex = 1;
            this.btnStudentAdd.Text = "Öğrenci Ekle";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(87, 211);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(211, 50);
            this.btnStudentUpdate.TabIndex = 2;
            this.btnStudentUpdate.Text = "Öğrenci Güncelle";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmAdminPanel_StudentOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 339);
            this.Controls.Add(this.btnStudentUpdate);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.btnStudentList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdminPanel_StudentOperations";
            this.Text = "FrmAdminPanel_StudentOperations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentList;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnStudentUpdate;
    }
}