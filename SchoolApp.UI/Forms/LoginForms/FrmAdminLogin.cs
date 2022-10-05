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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BLAdmin.BLisAdmin(txtUserName.Text, txtPassword.Text))
            {
                Forms.AdminForms.FrmAdminPanel frmAdminPanel = new Forms.AdminForms.FrmAdminPanel(BLAdmin.BLGetAdmin(txtUserName.Text));
                frmAdminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
            
        }
    }
}
