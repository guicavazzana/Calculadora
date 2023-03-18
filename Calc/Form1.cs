using System.Text.RegularExpressions;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float ans, num;
        int count;

        private void button0_Click(object sender, EventArgs e)
        {
            screenBox.Text += 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            screenBox.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            screenBox.Text += 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            screenBox.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            screenBox.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            screenBox.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            screenBox.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            screenBox.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            screenBox.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            screenBox.Text += 9;
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            num = float.Parse(screenBox.Text);
            screenBox.Clear();
            screenBox.Focus();
            count = 1;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num = float.Parse(screenBox.Text);
            screenBox.Clear();
            screenBox.Focus();
            count = 2;
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            num = float.Parse(screenBox.Text);
            screenBox.Clear();
            screenBox.Focus();
            count = 3;
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (screenBox.Text != "")
            {
                num = float.Parse(screenBox.Text);
                screenBox.Clear();
                screenBox.Focus();
                count = 4;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            num = float.Parse(screenBox.Text);
            screenBox.Clear();
            screenBox.Focus();
            count = 5;
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (count) 
            {
                case 1:
                    ans = num / 100;
                    screenBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num / float.Parse(screenBox.Text);
                    screenBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(screenBox.Text);
                    screenBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num - float.Parse(screenBox.Text);
                    screenBox.Text = ans.ToString();
                    break;
                case 5:
                    ans = num + float.Parse(screenBox.Text);
                    screenBox.Text = ans.ToString();
                    break;
            }
        }
        private void buttonAC_Click(object sender, EventArgs e)
        {
            screenBox.Text = String.Empty;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            screenBox.Text += ",";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            screenBox.Text = "-" + screenBox.Text;
        }

        private void screenBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}