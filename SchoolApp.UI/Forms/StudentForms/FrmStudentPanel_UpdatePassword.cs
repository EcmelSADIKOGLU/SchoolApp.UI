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
        public FrmStudentPanel_UpdatePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_UpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
