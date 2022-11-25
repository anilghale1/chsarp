namespace calculator
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;
        decimal calculation;
        string operat;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        public void GetResultValue()
        {
            if (textBox2.Text != "" && textBox2.Text != "+" && textBox2.Text != "/")
            {
                calculation = Convert.ToDecimal(textBox2.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            GetResultValue();
            calculation = Convert.ToDecimal(textBox2.Text);
            operat = "x";
            textBox2.Text = "x";
            textBox2.Clear();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetResultValue();
            calculation = Convert.ToDecimal(textBox2.Text);
            operat = "/";
            textBox2.Text = "/";
            textBox2.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal firstnum = calculation;
            decimal secondnum = Convert.ToDecimal(textBox2.Text);

             switch(operat)
            {
                case "+":
                    calculation = (firstnum + secondnum);
                    textBox2.Text = calculation.ToString();
                    break;

                case "x":
                    calculation = (firstnum *  secondnum);
                    textBox2.Text = calculation.ToString();
                    break;

                case "/":
                    calculation = (firstnum / secondnum);
                    textBox2.Text = calculation.ToString();
                    break;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 employeeform = new Form2();
           employeeform.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetResultValue();
            calculation =Convert.ToDecimal(textBox2.Text);
                operat = "+";
            textBox2.Text = "+";
        }


        

    }
    }
   