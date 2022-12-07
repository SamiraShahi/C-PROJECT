using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trying
{
    
    public partial class Form2 : Form
    {
        SqlConnection cafe = new SqlConnection(
             @"data source=.\SQLEXPRESS;
            initial catalog=cms;
            user id=sa;
            password=qwe;");
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           loginpage form1= new loginpage();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cafe.Open();
            var x = textBox1.Text;
            var nx = textBox2.Text;
            string getPass = "select * from password where pass='" + x + "'";
            SqlDataAdapter sda = new SqlDataAdapter(getPass, cafe);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                string qu="update password set pass='"+nx+"' where pass='"+x+"'";
                SqlCommand cmd = new SqlCommand(qu,cafe);
                cmd.ExecuteNonQuery();
                MessageBox.Show("password has been reset");
                this.Hide();
                loginpage form1= new loginpage();
                form1.ShowDialog();
                               
            }
            cafe.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
