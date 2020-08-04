using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_LESSON09_PART1_IDEAL
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button;

            if (calculatorButton.Tag.ToString() == "Operand")
            {
                if (resultLabel.Text.Length > 7)
                {
                    resultLabel.Font = new Font("Microsoft Sans Serif" , 26.0f);
                }
                else
                {
                    resultLabel.Font = new Font("Microsoft Sans Serif", 40.0f);
                }

                if (resultLabel.Text == "0") 
                {
                    resultLabel.Text = calculatorButton.Text;
                }
                else
                {
                    resultLabel.Text += calculatorButton.Text;
                }
                
            }
            else if (calculatorButton.Tag.ToString() == "Operator")
            {
                switch (calculatorButton.Name)
                {
                    case "clearButton":
                        resultLabel.Text = "0";
                        break;
                    case "backspaceButton":
                        if (resultLabel.Text != "0")
                        {
                            resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.Length - 1);
                            if (resultLabel.Text.Equals(string.Empty))
                            {
                                resultLabel.Text = "0";
                            }
                        }
                        break;
                }
            }
        }
    }
}
