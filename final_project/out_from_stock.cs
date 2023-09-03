using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Pets;


namespace final_project
{
    public partial class out_from_stock : Form
    {
        public out_from_stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void out_from_stock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Text = "Siamese";
            radioButton5.Text = "British";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Text = "Poodle";
            radioButton5.Text = "GoldenRetieve";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Text = "GoldFish";
            radioButton5.Text = "AngelFish";
        }
    }
}
