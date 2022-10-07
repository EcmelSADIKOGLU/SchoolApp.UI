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

namespace SchoolApp.UI.Forms.AdminForms
{
    public partial class FrmAdminPanel : Form
    {
        Admin admin = new Admin();
        public FrmAdminPanel(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentOperations_Click(object sender, EventArgs e)
        {
            StudentOperations.FrmAdminPanel_StudentOperations frm = new StudentOperations.FrmAdminPanel_StudentOperations();
            frm.Show();
        }

        private void btnTeacherOperations_Click(object sender, EventArgs e)
        {
            TeacherOperations.FrmAdminPanel_TeacherOperations frm = new TeacherOperations.FrmAdminPanel_TeacherOperations();
            frm.Show();

        }

        private void btnClassOperations_Click(object sender, EventArgs e)
        {
            ClassOperations.FrmAdminPanel_ClassOperations frm = new ClassOperations.FrmAdminPanel_ClassOperations();
            frm.Show();
        }

        
    }
}
