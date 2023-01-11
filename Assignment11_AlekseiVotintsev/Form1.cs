using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment11_AlekseiVotintsev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PetClass pet;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = namePet.Text;
            string type = typePet.Text;
            decimal age = 0;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(type) && decimal.TryParse(agePet.Text, out age))
            {
                pet = new PetClass(name, type, age);
            }
            else
            {
                MessageBox.Show("Check your inputs");
            }
        }

        private void infocheck_Click(object sender, EventArgs e)
        {
            try
            {
                info.Items.Add("Pet's name: " + pet.PetName);
                info.Items.Add("Pet's type: " + pet.PetType);
                info.Items.Add("Pet's age: " + pet.PetAge);
            }
            catch (NullReferenceException)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
