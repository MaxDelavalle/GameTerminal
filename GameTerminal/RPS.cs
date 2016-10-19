using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2

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
                    label6.Text = "TIE";
                    listBox1.Items.Add("TIE");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "YOU LOSE";
                    listBox1.Items.Add("LOSS");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "YOU WIN!!!";
                    listBox1.Items.Add("WIN");
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
                    label6.Text = "YOU WIN!!!";
                    listBox1.Items.Add("WIN");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "TIE";
                    listBox1.Items.Add("TIE");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "YOU LOSE";
                    listBox1.Items.Add("LOSS");
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
                    label6.Text = "YOU LOSE";
                    listBox1.Items.Add("LOSS");
                    break;

                case 2:

                    pictureBox4.Image = pictureBox2.Image;
                    label6.Text = "YOU WIN!!!";
                    listBox1.Items.Add("WIN");
                    break;

                case 3:

                    pictureBox4.Image = pictureBox1.Image;
                    label6.Text = "TIE";
                    listBox1.Items.Add("TIE");
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
        
    

