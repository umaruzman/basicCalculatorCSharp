using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class frmMain : Form
    {   
        public double total = 0;
        public string operation = "";

        public frmMain()
        {
            InitializeComponent();
        }
    
        public void numberButtonClicked(string val)
        {
            if (txtDisplay.Text == "0" && val != ".")
            {
                txtDisplay.Text = "";
            }

            string currentVal = txtDisplay.Text;
            txtDisplay.Text = currentVal + val;
        }

        public void clearDisplay()
        {
            txtDisplay.Text = "0";
            btnDot.Enabled = true;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            numberButtonClicked("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            numberButtonClicked("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            numberButtonClicked("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            numberButtonClicked("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            numberButtonClicked("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            numberButtonClicked("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            numberButtonClicked("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            numberButtonClicked("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            numberButtonClicked("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numberButtonClicked("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                numberButtonClicked("0.");
            } else
            {
                numberButtonClicked(".");
            }

            btnDot.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double currentDisplayValue = Double.Parse(txtDisplay.Text);
            total = currentDisplayValue;
            operation = "plus";
            clearDisplay();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearDisplay();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearDisplay();
            total = 0;
            operation = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "plus":
                    total += Double.Parse(txtDisplay.Text);
                    break;
                case "minus":
                    total -= Double.Parse(txtDisplay.Text);
                    break;
                case "divide":
                    total /= Double.Parse(txtDisplay.Text);
                    break;
                case "multiply":
                    total *= Double.Parse(txtDisplay.Text);
                    break;
            }

            
            txtDisplay.Text = total.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double currentDisplayValue = Double.Parse(txtDisplay.Text);
            total = currentDisplayValue;
            operation = "minus";
            clearDisplay();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double currentDisplayValue = Double.Parse(txtDisplay.Text);
            total = currentDisplayValue;
            operation = "divide";
            clearDisplay();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double currentDisplayValue = Double.Parse(txtDisplay.Text);
            total = currentDisplayValue;
            operation = "multiply";
            clearDisplay();
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)49)
            {
                btnOne.PerformClick();

            } else if (e.KeyChar == (char)50)
            {
                btnTwo.PerformClick();

            } else if(e.KeyChar == (char)51)
            {
                btnThree.PerformClick();

            } else if (e.KeyChar == (char)52)
            {
                btnFour.PerformClick();

            } else if (e.KeyChar == (char)53)
            {
                btnFive.PerformClick();

            } else if (e.KeyChar == (char)54)
            {
                btnSix.PerformClick();

            } else if (e.KeyChar == (char)55)
            {
                btnSeven.PerformClick();

            } else if (e.KeyChar == (char)56)
            {
                btnEight.PerformClick();

            } else if (e.KeyChar == (char)57)
            {
                btnNine.PerformClick();

            } else if (e.KeyChar == (char)48)
            {
                btnZero.PerformClick();

            }
        }
    }
}
