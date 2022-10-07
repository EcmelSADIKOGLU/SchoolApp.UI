namespace SchoolApp.UI.Forms.StudentForms
{
    partial class FrmStudentPanel
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
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnLessons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(52, 40);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(174, 56);
            this.btnProfil.TabIndex = 0;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(52, 112);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(174, 56);
            this.btnNotes.TabIndex = 1;
            this.btnNotes.Text = "Notlar";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnLessons
            // 
            this.btnLessons.Location = new System.Drawing.Point(52, 191);
            this.btnLessons.Name = "btnLessons";
            this.btnLessons.Size = new System.Drawing.Size(174, 56);
            this.btnLessons.TabIndex = 2;
            this.btnLessons.Text = "Dersler";
            this.btnLessons.UseVisualStyleBackColor = true;
            this.btnLessons.Click += new System.EventHandler(this.btnLessons_Click);
            // 
            // FrmStudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 293);
            this.Controls.Add(this.btnLessons);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnProfil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStudentPanel";
            this.Text = "FrmStudentPanel";
            this.Load += new System.EventHandler(this.FrmStudentPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnLessons;
    }
}