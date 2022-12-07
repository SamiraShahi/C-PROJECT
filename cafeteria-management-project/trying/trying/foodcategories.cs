using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trying
{
    public partial class foodcategories : Form
    {
        int price = 0;
        public foodcategories()
        {
            InitializeComponent();
        }
        public foodcategories(int price)
        {
            this.price += price;
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
          //  Form3 n =new Form3();
           // n.ShowDialog();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5= new Form5();   
            form5.ShowDialog();
            //changes
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            veg v= new veg();
            v.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(""+myGlobal.TotalPrice));
            myGlobal.TotalPrice = 0;
        }
    }
}
