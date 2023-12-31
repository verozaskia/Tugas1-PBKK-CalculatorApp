namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "*";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(textBox1.Text);
                    result = valueFirst - valueSecond;
                    textBox1.Text = result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(textBox1.Text);
                    result = valueFirst + valueSecond;
                    textBox1.Text = result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(textBox1.Text);
                    result = valueFirst / valueSecond;
                    textBox1.Text = result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(textBox1.Text);
                    result = valueFirst * valueSecond;
                    textBox1.Text = result.ToString();
                    break;

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            textBox1.Text = "0";
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }
    }
}
