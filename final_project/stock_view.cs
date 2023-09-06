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


namespace final_project
{
    public partial class stock_view : Form
    {
        public string pet_type = "Dog";
        public string pet_specie = "Poodle";
        public stock_view()
        {
            InitializeComponent();
            SharedDatabase.OnDataChanged += refresh_list;
        }

        private void stock_view_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void type_dog_radio_Click(object sender, EventArgs e)
        {
            pet_type = "Dog";
            pet_specie = "Poodle";
            specie1_radio.Text = "Poodle";
            specie2_radio.Text = "GoldenRetriever";
            specie1_radio.Checked = true;
            refresh_list();
       
        }

        private void type_cat_radio_Click(object sender, EventArgs e)
        {
            pet_type = "Cat";
            pet_specie = "Siamese";
            specie1_radio.Text = "Siamese";
            specie2_radio.Text = "British";
            specie1_radio.Checked = true;
            refresh_list();
        }

        private void type_fish_radio_Click(object sender, EventArgs e)
        {
            pet_type = "Fish";
            pet_specie = "Goldfish";
            specie1_radio.Text = "Goldfish";
            specie2_radio.Text = "Angelfish";
            specie1_radio.Checked = true;
            refresh_list();
        }
        public void refresh_list()
        {
            Pets_stock.Items.Clear();
            int count = SharedDatabase.Data[pet_type][pet_specie].Count;
            count_species.Text = count.ToString();
            for (int i = 0; i < count; i++)
            {
                Pets_stock.Items.Add(SharedDatabase.Data[pet_type][pet_specie][i].get_name());
            }
        }

        private void specie1_radio_Click(object sender, EventArgs e)
        {
            pet_specie = specie1_radio.Text;
            refresh_list();
        }

        private void specie2_radio_Click(object sender, EventArgs e)
        {
            pet_specie = specie2_radio.Text;
            refresh_list();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Pets_stock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
