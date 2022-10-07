using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UI.Forms.AdminForms.TeacherOperations
{
    public partial class FrmAdminPanel_TeacherOperations : Form
    {
        public FrmAdminPanel_TeacherOperations()
        {
            InitializeComponent();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_TeacherList frm = new FrmAdminPanel_TeacherList();
            frm.ShowDialog();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_AddTeacher frm = new FrmAdminPanel_AddTeacher();
            frm.ShowDialog();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_UpdateTeacher frm = new FrmAdminPanel_UpdateTeacher();
            frm.ShowDialog();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_DeleteTeacher frm = new FrmAdminPanel_DeleteTeacher();
            frm.ShowDialog();
        }
    }
}
