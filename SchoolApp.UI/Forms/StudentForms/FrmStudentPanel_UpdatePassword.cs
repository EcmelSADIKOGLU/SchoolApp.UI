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
    public partial class FrmStudentPanel_UpdatePassword : Form
    {
        string username;
        Student student;
        public FrmStudentPanel_UpdatePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_UpdatePassword_Load(object sender, EventArgs e)
        {
            student = BLStudent.BLGetStudentByUserName(username);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordAgain.Text)
            {
                if(txtPasswordConfirm.Text == student.StudentPassword)
                {
                    BLStudent.BLUpdatePassword(username, txtPassword.Text);
                    MessageBox.Show("Başaryıla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Parola yanlış");
                }
            }
            else
            {
                MessageBox.Show("Parolalar Uyuşmuyor");
            }
        }
    }
}
