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
    public partial class Form5 : Form
    {
        int momoCount = 0;
        int chowmeinCount = 0;
        int burgercount = 0;
        int price = 0;
        int chickenDrum = 0;
        int chickenWings = 0;
        int chickenSet = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void momo_Click(object sender, EventArgs e)
        {
            
            momoCount++;
            textBox1.Text = Convert.ToString(momoCount);
            price = price + 90;
        }

        private void chowmein_Click(object sender, EventArgs e)
        {
            chowmeinCount++;
            textBox3.Text=Convert.ToString(chowmeinCount);
            price = price + 80;

        }

        private void burger_Click(object sender, EventArgs e)
        {
            burgercount++;
            textBox2.Text=Convert.ToString(burgercount);
            price = price + 90;
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+price);
            this.Hide();
            myGlobal.TotalPrice+=price;
            foodcategories fc = new foodcategories();
            fc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chickenDrum++;
            textBox4.Text=Convert.ToString(chickenDrum);
            price = price + 90;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chickenSet++;
            textBox6.Text=Convert.ToString(chickenSet);
            price += 90;
        }
    }
}
