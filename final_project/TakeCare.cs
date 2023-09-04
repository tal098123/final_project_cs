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
    public partial class TakeCare : Form
    {
        public string pet_type = "Dog";
        public string pet_specie = "Poodle";
        public Pet selected_pet;
        
        public TakeCare()
        {
            InitializeComponent();
            refresh_list();
            SharedDatabase.OnDataChanged += refresh_list;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TakeCare_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
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
            //refresh_list();
        }

        private void type_cat_radio_Click(object sender, EventArgs e)
        {
            pet_type = "Cat";
            pet_specie = "Siamese";
            specie1_radio.Text = "Siamese";
            specie2_radio.Text = "British";
            specie1_radio.Checked = true;
            refresh_list();
            //refresh_list();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Pets_stock.SelectedIndex;
            if (selectedIndex >= 0)
            {
                selected_pet = SharedDatabase.Data[pet_type][pet_specie][selectedIndex];
                label_age.Text = selected_pet.get_age().ToString();
                label_arriving.Text = selected_pet.get_arriving_date().ToString();
                label_id.Text = selected_pet.get_id().ToString();
            }
        }
        public void refresh_list()
        {
            Pets_stock.Items.Clear();
            pet_feedback.Text = "";
            label_age.Text = "";
            label_arriving.Text = "";
            label_id.Text = "";
            selected_pet = null;
            int count = SharedDatabase.Data[pet_type][pet_specie].Count;
            for (int i = 0; i < count; i++)
            {
                Pets_stock.Items.Add(SharedDatabase.Data[pet_type][pet_specie][i].get_name());
            }
        }

        private void specie1_radio_Click(object sender, EventArgs e)
        {
            pet_specie = SharedDatabase.specie_id[pet_type][1];
            refresh_list();
        }

        private void specie2_radio_Click(object sender, EventArgs e)
        {
            pet_specie = SharedDatabase.specie_id[pet_type][2];
            refresh_list();
        }


        private void feed_pet_btn_Click(object sender, EventArgs e)
        {
            if(selected_pet != null)
                pet_feedback.Text = selected_pet.serve_food();
        }

        private void check_pet_btn_Click(object sender, EventArgs e)
        {
            if (selected_pet != null)
                pet_feedback.Text = selected_pet.check_on_pet();
        }

        private void back_to_options_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label_arriving_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void specie1_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void type_dog_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void type_cat_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void type_fish_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
