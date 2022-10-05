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

namespace SchoolApp.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLBranch.BLBranchList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLBranch.BLAddBranch(txtName.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BLBranch.BLDeleteBranch(Convert.ToByte(txtID.Text));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Branch branch = new Branch();
            branch.BranchID = Convert.ToByte(txtID.Text);
            branch.BranchName = txtName.Text;
            BLBranch.BLUpdateBranch(branch);
        }
    }
}
