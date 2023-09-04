using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using System.Windows.Forms;


using Pets;

namespace final_project
{
    public partial class regist_pet : Form
    {
        public regist_pet()
        {
            InitializeComponent();
        }

        private void regist_pet_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Dog")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Poodle");
                comboBox2.Items.Add("Retriever");
            }
            else if (comboBox3.SelectedItem.ToString() == "Cat")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Siamese");
                comboBox2.Items.Add("British");
            }
            else if (comboBox3.SelectedItem.ToString() == "Fish")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Gold fish");
                comboBox2.Items.Add("Angelfish");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)///
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Poodle")
                SharedDatabase.Data["Dog"]["Poodle"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
           
            else if (comboBox2.SelectedItem.ToString() == "GoldenRetriever")
                SharedDatabase.Data["Dog"]["GoldenRetriever"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
            
            else if (comboBox2.SelectedItem.ToString() == "Siamese")
                SharedDatabase.Data["Cat"]["Siamese"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
            
            else if (comboBox2.SelectedItem.ToString() == "British")
                SharedDatabase.Data["Cat"]["British"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
            
            else if (comboBox2.SelectedItem.ToString() == "Goldfish")
                SharedDatabase.Data["Fish"]["Goldfish"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
            else 
                SharedDatabase.Data["Fish"]["Angelfish"].Add(new Poodle(textBox1.Text.ToString(), DateTime.Today, dateTimePicker1.Value));
           
            SharedDatabase.DataChanged();
            clearRegist();
            this.Hide();


        }
        private void clearRegist()
        {
            //comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            textBox1.Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-4);
            //DateTime dt = dateTimePicker1.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearRegist();
            this.Hide();
        }
    }
}
