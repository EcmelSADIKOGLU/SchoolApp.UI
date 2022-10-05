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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            LoginForms.FrmStudentLogin frmStudentLogin = new LoginForms.FrmStudentLogin();
            frmStudentLogin.Show();
            this.Hide();
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            LoginForms.FrmTeacherLogin frmTeacherLogin = new LoginForms.FrmTeacherLogin();
            frmTeacherLogin.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            LoginForms.FrmAdminLogin frmAdminLogin = new LoginForms.FrmAdminLogin();
            frmAdminLogin.Show();
            this.Hide();
        }
    }
}
