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

namespace SchoolApp.UI.Forms.AdminForms.StudentOperations
{
    public partial class FrmAdminPanel_StudentList : Form
    {
        public FrmAdminPanel_StudentList()
        {
            InitializeComponent();
        }

        private void FrmAdminPanel_StudentList_Load(object sender, EventArgs e)
        {
            foreach (var cls in BLClass.BLClassList())
            {
                cbbClass.Items.Add(cls.ClassName);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLStudent.BLStudentListByClass(cbbClass.Text);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLStudent.BLStudentList();
        }
    }
}
