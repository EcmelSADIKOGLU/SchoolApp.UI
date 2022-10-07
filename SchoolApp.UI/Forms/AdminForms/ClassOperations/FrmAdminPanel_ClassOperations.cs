using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UI.Forms.AdminForms.ClassOperations
{
    public partial class FrmAdminPanel_ClassOperations : Form
    {
        public FrmAdminPanel_ClassOperations()
        {
            InitializeComponent();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_UpdateClass frm = new FrmAdminPanel_UpdateClass();
            frm.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_AddClass frm = new FrmAdminPanel_AddClass();
            frm.ShowDialog();
        }

        private void btnClassTeachers_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_ClassTeachers frm = new FrmAdminPanel_ClassTeachers();
            frm.ShowDialog();
        }
    }
}
