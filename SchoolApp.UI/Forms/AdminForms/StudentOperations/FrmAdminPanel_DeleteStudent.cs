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

namespace SchoolApp.UI.Forms.AdminForms.StudentOperations
{
    public partial class FrmAdminPanel_DeleteStudent : Form
    {
        public FrmAdminPanel_DeleteStudent()
        {
            InitializeComponent();
        }

        private void FrmAdminPanel_DeleteStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            Student student = BLStudent.BLGetStudentByUserName(txtUserName.Text);
            students.Add(student);
            dataGridView1.DataSource = students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BLStudent.BLDeleteStudent(txtUserName.Text);
            MessageBox.Show("Öğrenci Başarıyla Silindi");
        }
    }
}
