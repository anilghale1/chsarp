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

        private void button11_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox2.Text);
            textBox2.Clear();
            textBox2.Focus();
            count = 4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            compute(count);
        }
            public void compute(int count)
            {
                switch (count)
                {
                    case 1:
                        ans = num1 - float.Parse(textBox2.Text);
                        textBox2.Text = ans.ToString();
                        break;
                    case 2:
                        ans = num1 + float.Parse(textBox2.Text);
                        textBox2.Text = ans.ToString();
                        break;
                    case 3:
                        ans = num1 * float.Parse(textBox2.Text);
                        textBox2.Text = ans.ToString();
                        break;
                    case 4:
                        ans = num1 / float.Parse(textBox2.Text);
                        textBox2.Text = ans.ToString();
                        break;
                    default:
                        break;
                }
            }
        

        private void button10_Click(object sender, EventArgs e)
        {
            
                num1 = float.Parse(textBox2.Text);
                textBox2.Clear();
                textBox2.Focus();
                count = 2;

            
        }
    }
    }
   