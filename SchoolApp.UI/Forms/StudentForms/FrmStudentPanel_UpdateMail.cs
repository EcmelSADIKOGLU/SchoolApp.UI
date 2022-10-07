using SchoolApp.BusinessLayer.BL;
using SchoolApp.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UI.Forms.StudentForms
{
    public partial class FrmStudentPanel_UpdateMail : Form
    {
        string username;
        Student student;
        public FrmStudentPanel_UpdateMail(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_UpdateMail_Load(object sender, EventArgs e)
        {
            student = BLStudent.BLGetStudentByUserName(username);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (student.StudentPassword == txtPassword.Text)
            {
                BLStudent.BLUpdateMail(username, txtMail.Text);
                MessageBox.Show("Başaryıla Güncellendi");
            }
            else
            {
                MessageBox.Show("Parola Yanlış");
            }
        }
    }
}
