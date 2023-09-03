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
            //type_dog_radio.Checked = true;
            //specie1_radio.Checked = true;
            //specie1_radio.Text = "Poodle";
            //specie2_radio.Text = "GoldenRetriever";
            //SharedDatabase.Data["Dog"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Dog"]["Poodle"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["Poodle"].Add(new Poodle("George", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Dog"]["Poodle"] = new List<Pet>();
            //SharedDatabase.specie_id["Dog"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Dog"][1] = "Poodle";
            //SharedDatabase.Data["Dog"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Dog"]["GoldenRetriever"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["GoldenRetriever"].Add(new GoldenRetriever("Terry", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Dog"][2] = "GoldenRetriever";
            //SharedDatabase.Data["Cat"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Cat"]["Siamese"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["Siamese"].Add(new Siamese("shimi", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Cat"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Cat"][1] = "Siamese";
            //SharedDatabase.Data["Cat"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Cat"]["British"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["British"].Add(new British("Sebastian", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Cat"][2] = "British";
            //SharedDatabase.Data["Fish"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Fish"]["GoldFish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["GoldFish"].Add(new Goldfish("Danny", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Fish"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Fish"][1] = "GoldFish";
            //SharedDatabase.Data["Fish"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Fish"]["AngelFish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["AngelFish"].Add(new Angelfish("Kiki", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Fish"][2] = "AngelFish";
            refresh_list();


            //SharedDatabase.Data["3e3e"] = new Dictionary<string, Pet>();
            //RefreshPetsDict();

            //// Subscribe to data changes
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
            //SharedDatabase.LoadFromFile();
            //SharedDatabase.Data["Dog"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Dog"]["Poodle"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["Poodle"].Add(new Poodle("George", DateTime.Now, DateTime.Now));
            ////int count = SharedDatabase.Data["Dog"]["Poodle"].Count;
            ////Console.WriteLine(count);
            ////Pet pet = SharedDatabase.Data["Dog"]["Poodle"][0];
            ////Poodle check_1 = pet as Poodle;
            //SharedDatabase.specie_id["Dog"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Dog"][1] = "Poodle";
            //SharedDatabase.Data["Dog"]["GoldenRetriever"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["GoldenRetriever"].Add(new GoldenRetriever("Terry", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Dog"][2] = "GoldenRetriever";
            //SharedDatabase.Data["Cat"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Cat"]["Siamese"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["Siamese"].Add(new Siamese("shimi", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Cat"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Cat"][1] = "Siamese";
            //SharedDatabase.Data["Cat"]["British"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["British"].Add(new British("Sebastian", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Cat"][2] = "British";
            //SharedDatabase.Data["Fish"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Fish"]["Goldfish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["Goldfish"].Add(new Goldfish("Danny", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Fish"] = new Dictionary<int, string>();
            //SharedDatabase.specie_id["Fish"][1] = "Goldfish";
            //SharedDatabase.Data["Fish"]["Angelfish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["Angelfish"].Add(new Angelfish("Kiki", DateTime.Now, DateTime.Now));
            //SharedDatabase.specie_id["Fish"][2] = "Angelfish";
            //SharedDatabase.SaveToFile();
            //int count = SharedDatabase.Data["Dog"]["Poodle"].Count;
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
