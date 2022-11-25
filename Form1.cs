namespace calculatorusingcsharp
{
    public partial class Form1 : Form


    {
        string operate = "";
        decimal calculation = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void GetResultValue()
        {
            if (input.Text != "" && input.Text != "+" && input.Text != "-" && input.Text != "*" && input.Text != "/")
            {
                calculation = Convert.ToDecimal(input.Text);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = input.Text;
            int leng = data.Length;
            string new_data = data.Substring(0, leng - 1);
            input.Text = new_data;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // input.Text = "0";
            string data = input.Text;
            input.Text = data + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(input.Text);

            switch(operate)
            {
                case "+":
                    calculation = (firstNum + secondNum);
                    input.Text = calculation.ToString();
                    break;
                    case "-":
                    calculation = (firstNum - secondNum);
                    input.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstNum *secondNum);
                    input.Text = calculation.ToString();
                    break;
                case "/":
                    calculation = (firstNum /secondNum);
                    input.Text = calculation.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input.Text=="+"|| input.Text == "-"|| input.Text == "*"|| input.Text == "/")
            {
                input.Text = "1";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "1";
            }

        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "8";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "9";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "4";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "4";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "5";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "6";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //input.Text = "2";
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "2";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "2";
            }
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //input.Text = "3";
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "3";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "3";
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string data = input.Text;
            input.Text = data + "7";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            input.Text = "  ";

        }


        private void button15_Click(object sender, EventArgs e)
        {
            ///input.Text = ".";
            string data = input.Text;
            input.Text = data + ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            GetResultValue();
            operate = "/";
            input.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "*";
            input.Text = "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            GetResultValue();
            operate = "-";
            input.Text = "-";
        }

        private void button19_Click(object sender, EventArgs e)
        {

            GetResultValue();
            operate = "+";
            input.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input.Text == "+" || input.Text == "-" || input.Text == "*" || input.Text == "/")
            {
                input.Text = "7";
            }
            else
            {
                string data = input.Text;
                input.Text = data + "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeform object_name = new employeeform();
           object_name.Show();
           
        }
    }
}

       
    
