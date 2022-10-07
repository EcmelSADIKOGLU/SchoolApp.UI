using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.UI.Forms.AdminForms.StudentOperations
{
    public partial class FrmAdminPanel_StudentOperations : Form
    {
        public FrmAdminPanel_StudentOperations()
        {
            InitializeComponent();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_StudentList frm = new FrmAdminPanel_StudentList();
            frm.ShowDialog();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_AddStudent frm = new FrmAdminPanel_AddStudent();
            frm.ShowDialog();
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_UpdateStudent frm = new FrmAdminPanel_UpdateStudent();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminPanel_DeleteStudent frm = new FrmAdminPanel_DeleteStudent();
            frm.ShowDialog();
        }
    }
}
