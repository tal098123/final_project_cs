using System;
using Database;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pets;


namespace final_project
{
    public partial class MainWindow : Form
    {
        public Form regist_form = new regist_pet();
        public Form out_from_stock_form = new out_from_stock();
        public Form stock_view_form = new stock_view();
        public Form take_care_form = new TakeCare();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void take_care_button(object sender, EventArgs e)
        {
            take_care_form.Show();
        }

        private void move_out_button(object sender, EventArgs e)
        {
            out_from_stock_form.Show();
        }

        private void regist_pet_button(object sender, EventArgs e)
        {
            regist_form.Show();
        }

        private void current_stock_button(object sender, EventArgs e)
        {
            stock_view_form.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
