using System;
using System.Windows.Forms;
using MathMethods;

namespace WindowsFormsApplication1
{
    public partial class MathStuffForm : Form
    {
        public MathStuffForm()
        {
            InitializeComponent();
        }

        private void mathify_button_Click(object sender, EventArgs e)
        {
            long operand1 = Convert.ToInt64(this.operand1.Text);
            long operand2 = Convert.ToInt64(this.operand2.Text);

            if (this.operand1.Text == "" || this.operand2.Text == "")
            {
                return;
            }

            long sum = MathStuff.add(operand1, operand2);
            long product = MathStuff.multiply(operand1, operand2);
            long add_count = MathStuff.getAddCount();
            long mult_count = MathStuff.getMultCount();

            this.add_label.Text = string.Format("The sum of {0} and {1} is {2}. MathStuff.add() has been called {3} times.",
                                                operand1,
                                                operand2,
                                                sum,
                                                add_count
                                               );
            this.mult_label.Text = string.Format("The product of {0} and {1} is {2}. MathStuff.multiply() has been called {3} times.",
                                                 operand1,
                                                 operand2,
                                                 product,
                                                 mult_count
                                                );
        }
    }
}
