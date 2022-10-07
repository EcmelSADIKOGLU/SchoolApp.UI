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
    public partial class FrmAdminPanel_AddStudent : Form
    {
        public FrmAdminPanel_AddStudent()
        {
            InitializeComponent();
        }

        private void FrmAdminPanel_AddStudent_Load(object sender, EventArgs e)
        {
            foreach (var item in BLClass.BLClassList())
            {
                cbbClass.Items.Add(item.ClassName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentName = txtName.Text;
            student.StudentClass = cbbClass.Text;
            student.StudentSurname = txtSurname.Text;
            BLStudent.BLAddStudent(student);
            MessageBox.Show("Öğrenci Başarıyla Eklendi");
        }

        
    }
}
