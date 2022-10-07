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
    public partial class FrmStudentPanel_LessonNotes : Form
    {
        string username;
        public FrmStudentPanel_LessonNotes(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FrmStudentPanel_LessonNotes_Load(object sender, EventArgs e)
        {

        }
    }
}
