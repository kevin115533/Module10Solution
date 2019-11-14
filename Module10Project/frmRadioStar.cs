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
            try
            {
                if (validate(txtLeftOp) && validate(txtRightOp))
                {
                    int op1 = int.Parse(txtLeftOp.Text);
                    int op2 = int.Parse(txtRightOp.Text);

                    if (rBtnAdd.Checked == true)
                    {
                        lblMessage.Text = addition(op1, op2);
                    }
                    if (rBtnSubtract.Checked == true)
                    {
                        lblMessage.Text = subtraction(op1, op2);
                    }
                    if (rBtnMutliply.Checked == true)
                    {
                        lblMessage.Text = multiply(op1, op2);
                    }
                    if (rBtnDivide.Checked == true && isZero(op2))
                    {
                        lblMessage.Text = division(op1, op2);
                    }
                    if (rBtnModulus.Checked == true && isZero(op2))
                    {
                        lblMessage.Text = modulus(op1, op2);
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message + ex.GetType().ToString();
            }
            if(chkBxVerbose.Checked == true)
            {
                txtLeftOp.Text = "";
                txtRightOp.Text = "";
            }
        }

        private bool validate(TextBox textBox)
        {
            return
                ifBlank(textBox) &&
                isNumber(textBox);
        }

        private bool ifBlank(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                lblMessage.Text = "Operand box blank, please enter value(s)";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isZero(int userNumber)
        {
            if(userNumber == 0)
            {
                if(rBtnModulus.Checked == true)
                {
                    lblMessage.Text = "Modulus operation can not be performed with 0";
                    return false;
                }
                if (rBtnDivide.Checked == true)
                {
                    lblMessage.Text = "Division operation can not be performed with 0";
                    return false;
                }
            }
            return true;
        }

        public bool isNumber(TextBox textBox)
        {
            string s = textBox.Text;
            int number = 0;
            if (int.TryParse(s, out number))
            {
                return true;
            }
            else
            {
                lblMessage.Text = "Please enter a numeric value";
                return false;
            }
        }

        private string addition(int op1, int op2)
        {
            string addString = "";
            int result = op1 + op2;

            if(chkBxVerbose.Checked == true)
            {
                addString = Convert.ToString(op1) + " + " + Convert.ToString(op2) + " = " + Convert.ToString(result);
            }
            else
            {
                addString = "The answer is " + Convert.ToString(result);
            }
            return addString;
        }
        private string subtraction(int op1, int op2)
        {
            string subString = "";
            int result = op1 - op2;

            if (chkBxVerbose.Checked == true)
            {
                subString = Convert.ToString(op1) + " - " + Convert.ToString(op2) + " = " + Convert.ToString(result);
            }
            else
            {
                subString = "The answer is " + Convert.ToString(result);
            }
            return subString;
        }

        private string multiply(int op1, int op2)
        {
            string multiString = "";
            int result = op1 * op2;

            if (chkBxVerbose.Checked == true)
            {
                multiString = Convert.ToString(op1) + " * " + Convert.ToString(op2) + " = " + Convert.ToString(result);
            }
            else
            {
                multiString = "The answer is " + Convert.ToString(result);
            }
            return multiString;
        }

        private string division(int op1, int op2)
        {
            string divString = "";
            int result = op1 / op2;

            if (chkBxVerbose.Checked == true)
            {
                divString = Convert.ToString(op1) + " / " + Convert.ToString(op2) + " = " + Convert.ToString(result);
            }
            else
            {
                divString = "The answer is " + Convert.ToString(result);
            }
            return divString;
        }

        private string modulus(int op1, int op2)
        {
            string modString = "";
            int result = op1 % op2;

            if (chkBxVerbose.Checked == true)
            {
                modString = Convert.ToString(op1) + " % " + Convert.ToString(op2) + " = " + Convert.ToString(result);
            }
            else
            {
                modString = "The answer is " + Convert.ToString(result);
            }
            return modString;
        }
    }
}
