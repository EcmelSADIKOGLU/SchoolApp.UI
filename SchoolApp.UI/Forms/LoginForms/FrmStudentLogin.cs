using SchoolApp.BusinessLayer.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UI.Forms.LoginForms
{
    public partial class FrmStudentLogin : Form
    {
        public FrmStudentLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLStudent.BLisStudent(txtUserName.Text, txtPassword.Text))
            {
                StudentForms.FrmStudentPanel frmStudentPanel = new StudentForms.FrmStudentPanel(txtUserName.Text);
                frmStudentPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
        }
    }
}
