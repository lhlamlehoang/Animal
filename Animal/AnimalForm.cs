using Animal.Concrete;
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
        InterfaceAnimalFactory factory;
        static string filePath = "D:\\HK2-S3\\Design Patterns\\Animal\\Image\\";
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

        private void btcreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbanimal.Text != "")
                {
                    string animal = cbanimal.Text.ToString().ToLower().Trim();
                    int type;
                    if (!animal.Equals("cat") && !animal.Equals("dog") && !animal.Equals("pig") && !animal.Equals("mouse"))
                    {
                        MessageBox.Show("This animal has not been created!", "Create Animal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        type = cbanimal.SelectedIndex;
                        if (cbanimal.Equals("cat") && type == -1 /* Error*/)
                        {
                            type = 0;
                        }
                        else if (animal.Equals("dog") && type == -1)
                        {
                            type = 1;
                        }
                        else if (animal.Equals("pig") && type == -1)
                        {
                            type = 2;
                        }
                        else if (animal.Equals("mouse") && type == -1)
                        {
                            type = 3;
                        }
                        factory = new ChosenAnimalCreation(type);
                        lbname.Visible = true;
                        lbname.Text = factory.createAnimals().getName();
                        lbinfo_name.Text = lbname.Text;
                        lbinfo_ability.Text = factory.createAnimals().getAbility();
                        lbinfo_food.Text = factory.createAnimals().getFood();
                        picbox.Image = Image.FromFile(filePath + factory.createAnimals().getImage());
                        pninfo.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
