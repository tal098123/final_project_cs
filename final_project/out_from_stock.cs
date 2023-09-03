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
        public string pet_type ;
        public string pet_specie;
        public Pet selected_pet;
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
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {
                SharedDatabase.Data[pet_type][pet_specie].RemoveAt(selectedIndex);
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
          
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
            listBox1.Items.Clear();
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
            radioButton4.Text = "Siamese";
            radioButton5.Text = "British";
            radioButton4.Checked = true;
            refresh_list();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pet_type = "Dog";
            pet_specie = "Poodle";
            radioButton4.Text = "Poodle";
            radioButton5.Text = "GoldenRetriever";
            radioButton4.Checked = true;
            refresh_list();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pet_type = "Fish";
            pet_specie = "Goldfish";
            radioButton4.Text = "Goldfish";
            radioButton5.Text = "Angelfish";
            radioButton4.Checked = true;
            refresh_list();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }


}
