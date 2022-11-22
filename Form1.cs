namespace c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age_input = Convert.ToInt32(age.Text);
                MessageBox.Show("Age: " + age_input);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid number");
            }


            //string data = username.Text;
            //MessageBox.Show(data);
            /* if (data == "test")
             {
                 MessageBox.Show("success");
             }
             else
             {
                 MessageBox.Show("failed");
             }

         }*/
            // for(int i =0;i < 3; i++)
            // {
            //   MessageBox.Show("Display time: "+i);
            // }


        }
    }




}
   