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
    public partial class FrmStudentPanel_Profil : Form
    {
        string username;
        Student student = new Student();
        public FrmStudentPanel_Profil(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_Profil_Load(object sender, EventArgs e)
        {
            student = BLStudent.BLGetStudentByUserName(username);
            lblUserName.Text = student.StudentUserName;
            lblName.Text = student.StudentName;
            lblSurname.Text = student.StudentSurname;
            lblClass.Text = student.StudentClass;
            lblMail.Text = student.StudentMail;
            lblPassword.Text = student.StudentPassword;
        }

        private void btnUpdateMail_Click(object sender, EventArgs e)
        {
            FrmStudentPanel_UpdateMail frm = new FrmStudentPanel_UpdateMail(username);
            frm.ShowDialog();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmStudentPanel_UpdatePassword frm = new FrmStudentPanel_UpdatePassword(username);
            frm.ShowDialog();
        }
    }
}
