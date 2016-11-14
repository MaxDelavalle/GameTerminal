using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchGameTerminal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            int iComputerChoice;

            pictureBox5.Image = pictureBox3.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {
                case 1:

                    pictureBox4.Image = pictureBox3.Image;
                    label6.Text = "Cravate";
                    listBox1.Items.Add("Cravate");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "Tu as Perdu";
                    listBox1.Items.Add("Perte");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "Vous Gagnez!!!";
                    listBox1.Items.Add("Victoire");
                    break;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            int iComputerChoice;

            pictureBox5.Image = pictureBox2.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {
                case 1:

                    pictureBox4.Image = pictureBox3.Image;
                    label6.Text = "Vous Gagnez!!!";
                    listBox1.Items.Add("Victoire");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "Cravate";
                    listBox1.Items.Add("Cravate");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "Tu as Perdu";
                    listBox1.Items.Add("Perte");
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random oRandomGenerator = new Random();
            int iComputerChoice;

            pictureBox5.Image = pictureBox1.Image;

            int iRandomNum = oRandomGenerator.Next(100, 4000);
            iComputerChoice = (iRandomNum % 3) + 1;

            switch (iComputerChoice)
            {
                case 1:

                    pictureBox4.Image = pictureBox3.Image;
                    label6.Text = "Tu as perdu";
                    listBox1.Items.Add("Perte");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "Vous Gagnez!!!";
                    listBox1.Items.Add("Victoire");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "Cravate";
                    listBox1.Items.Add("Cravate");
                    break;




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            label6.Text = "............";
            listBox1.Items.Clear();
        }
    }
}



