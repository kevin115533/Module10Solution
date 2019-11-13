using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module10Project
{
    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
        }

        private void rBtnAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRadioStar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeftOp.Text = "";
            txtRightOp.Text = "";
            lblMessage.Text = "";
            rBtnAdd.Checked = true;
            chkBxVerbose.Checked = true;
            txtLeftOp.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int op1 = int.Parse(txtLeftOp.Text);
            int op2 = int.Parse(txtRightOp.Text);
        }
    }
}
