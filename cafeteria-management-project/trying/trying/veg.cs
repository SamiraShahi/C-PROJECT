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
    public partial class veg : Form
    {
        int price=0, saladcount = 0, friedriceCount = 0, sandwitchcount = 0;
         public veg()
        {
            InitializeComponent();
        }

        private void salad_Click(object sender, EventArgs e)
        {
            saladcount++;
            textBox3.Text=(Convert.ToString(saladcount));
            price += 80;
        }

        private void sandwitch_Click(object sender, EventArgs e)
        {
            sandwitchcount++;
            textBox2.Text=(Convert.ToString(sandwitchcount));
            price += 90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the price is " + price);
            myGlobal.TotalPrice = myGlobal.TotalPrice+ price;
            foodcategories fc = new foodcategories();
           this.Hide();
            fc.ShowDialog();
           
        }

        private void veg_Load(object sender, EventArgs e)
        {
            

        }

        private void frice_Click(object sender, EventArgs e)
        {
            friedriceCount++;
            textBox1.Text=(Convert.ToString(friedriceCount));
            price += 90;
        }
    }
}
