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
        public string pet_type = "Dog";
        public string pet_specie = "Poodle";
        public Pet selected_pet;
        public out_from_stock()
        {
            InitializeComponent();
            refresh_list();
            SharedDatabase.OnDataChanged += refresh_list;
        }

        private void clear()
        {
            label_age.Text = "";
            label_date.Text = "";
            label_id.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            this.Hide();
        }

        private void out_from_stock_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                SharedDatabase.Data[pet_type][pet_specie].RemoveAt(selectedIndex);
                SharedDatabase.DataChanged();
            }
            refresh_list();
            clear();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pet_specie = radio_Button4.Text;
            refresh_list();

        }
        public void refresh_list()
        {
            listBox1.Items.Clear();
            label_age.Text = "";
            label_date.Text = "";
            label_id.Text = "";
            selected_pet = null;
            int count = SharedDatabase.Data[pet_type][pet_specie].Count;
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(SharedDatabase.Data[pet_type][pet_specie][i].get_name());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pet_type = "Cat";
            pet_specie = "Siamese";
            radio_Button4.Text = "Siamese";
            radio_Button5.Text = "British";
            radio_Button4.Checked = true;
            refresh_list();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pet_type = "Dog";
            pet_specie = "Poodle";
            radio_Button4.Text = "Poodle";
            radio_Button5.Text = "GoldenRetriever";
            radio_Button4.Checked = true;
            refresh_list();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pet_type = "Fish";
            pet_specie = "Goldfish";
            radio_Button4.Text = "Goldfish";
            radio_Button5.Text = "Angelfish";
            radio_Button4.Checked = true;
            refresh_list();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex=listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                selected_pet = SharedDatabase.Data[pet_type][pet_specie][selectedIndex];
                TimeSpan pet_age = selected_pet.get_age();
                label_age.Text = "year old: " + ((int)(pet_age.TotalDays / 365)) + " months: " + (int)((pet_age.TotalDays % 365) / 30) + " days: " + (int)((pet_age.TotalDays % 365) % 30);
                label_date.Text = selected_pet.get_arriving_date().ToString("dd/MM/yyyy");
                label_id.Text = selected_pet.get_id().ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radio_Button5_CheckedChanged(object sender, EventArgs e)
        {
            pet_specie = radio_Button5.Text;
            refresh_list();
        }
    }


}
