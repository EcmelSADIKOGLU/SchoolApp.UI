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
    public partial class FrmAdminPanel_UpdateStudent : Form
    {
        public FrmAdminPanel_UpdateStudent()
        {
            InitializeComponent();
        }
        private void FrmAdminPanel_UpdateStudent_Load(object sender, EventArgs e)
        {
            foreach (var item in BLClass.BLClassList())
            {
                cbbClass.Items.Add(item.ClassName);
            }
        }
        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            Student student = BLStudent.BLGetStudentByUserName(txtUserName.Text);

            txtName.Text = student.StudentName;
            txtSurname.Text = student.StudentSurname;
            cbbClass.Text = student.StudentClass;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentName = txtName.Text;
            student.StudentSurname = txtSurname.Text;
            student.StudentClass = cbbClass.Text;
            student.StudentUserName = txtUserName.Text;
            BLStudent.BLUpdateStudent(student);
        }
    }
}
