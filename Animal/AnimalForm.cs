using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Animal
{
    public partial class AnimalForm : Form
    {
        Animals animal = new Animals();
        public AnimalForm()
        {
            InitializeComponent();
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            cbanimal.Items.Add("Cat");
            cbanimal.Items.Add("Dog");
            cbanimal.Items.Add("Pig");
            cbanimal.Items.Add("Mouse");
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Set the image of the picture box to the selected image
                    picbox.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool verif()
        {
            if ((tbname.Text.Trim() == "")
                || (tbinfo_ability.Text.Trim() == "")
                || (tbinfo_food.Text.Trim() == "")
                || (picbox.Image == null))
            {
                return false;
            }
            else return true;
        }


        private void btcreate_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if(cbanimal.Text.Trim() == "Cat"){
                    id = 0;
                }
                else if (cbanimal.Text.Trim() == "Dog")
                {
                    id = 1;
                }
                else if (cbanimal.Text.Trim() == "Pig")
                {
                    id = 2;
                }
                else
                {
                    id = 3;
                }

                string name = tbname.Text;
                string ability = tbinfo_ability.Text;
                string food = tbinfo_food.Text;
                MemoryStream picture = new MemoryStream();
                picbox.Image.Save(picture, picbox.Image.RawFormat);
                if (verif())
                {
                    if (animal.addAnimal(id, name, ability, food, picture))
                    {
                        MessageBox.Show("New Animal Has Been Created", "Create Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Create Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty fields", "Create Animal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {
            if (tbname.Text.Trim() == "")
            {
                tbinfo_name.Text = "";
            }
            else
            {
                string name = tbname.Text;
                tbinfo_name.Text = tbname.Text.ToString();
                //if (name == animal.getAnimals(name).Rows[0]["name"].ToString())
                //{
                //    tbinfo_ability.Text = animal.getAnimals(name).Rows[0]["ability"].ToString();
                //    tbinfo_food.Text = animal.getAnimals(name).Rows[0]["food"].ToString();
                //    byte[] pic;
                //    pic = (byte[])animal.getAnimals(name).Rows[0]["image"];
                //    MemoryStream picture = new MemoryStream(pic);
                //    picbox.Image = Image.FromStream(picture);
                //}
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
