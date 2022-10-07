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
    public partial class FrmStudentPanel : Form
    {
        String username;
        public FrmStudentPanel(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            FrmStudentPanel_Profil frm = new FrmStudentPanel_Profil(username);
            frm.ShowDialog();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            FrmStudentPanel_LessonNotes frm = new FrmStudentPanel_LessonNotes(username);
            frm.ShowDialog();
        }

        private void btnLessons_Click(object sender, EventArgs e)
        {
            FrmStudentPanel_Lessons frm = new FrmStudentPanel_Lessons(username);
            frm.ShowDialog();
        }
    }
}
