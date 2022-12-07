using System;
using System.Data;
using System.Data.SqlClient;

namespace trying
{

    public partial class loginpage : Form
    {
        
        SqlConnection cafe = new SqlConnection(
            @"data source=.\SQLEXPRESS;
            initial catalog=cms;
            user id=sa;
            password=qwe;");


        public loginpage()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cafe.Open();
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("password req");
            }
            else
            {
                var x = textBox2.Text;
                string getPass = "select * from password where pass='" + x + "'";
                //SqlCommand cmd = new SqlCommand(getPass, cafe);
                SqlDataAdapter sda = new SqlDataAdapter(getPass, cafe);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("logged in!!");
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("invalid password");
                }
            }
            cafe.Close();
        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            
        }

        private void logo_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}