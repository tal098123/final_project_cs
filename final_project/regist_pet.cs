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
    }
}
