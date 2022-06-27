using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        
        int number = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Start();
            AssignIconsToSquares();
            
        
        }

        
        private void AssignIconsToSquares()
        {
           
            label1.Image = Resource1.images__1_;
            label2.Image = Resource1.images;
            label3.Image = Resource1.images__4_;
            label4.Image = Resource1.images__3_1;
            label8.Image = Resource1.images__3_1;
            label7.Image = Resource1.images__1_1;
            label6.Image = Resource1.images__2_1;
            label5.Image = Resource1.images__1_1;
            label9.Image = Resource1.images__1_;
            label13.Image = Resource1.images1;
            label10.Image = Resource1.images__2_1;
            label14.Image = Resource1.images__4_;
            label11.Image = Resource1.images__5_;
            label15.Image = Resource1.images;
            label12.Image = Resource1.images1;
            label16.Image = Resource1.images__5_;
            


        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Image = Resource1.images__1_;
            label1.Tag = "blueBerry";
            number++;
            if (number % 2 == 0)
            {
                secondClicked = label1;
            }
            else { firstClicked = label1; }
            checkIfIsEqual();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Image = Resource1.images;
            label2.Tag = "orange";
            number++;
            if (number % 2 == 0)
            {
               secondClicked=label2;
               
            }
            else { firstClicked=label2; }
            checkIfIsEqual();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Image = Resource1.images__4_;
            label3.Tag = "grapes";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label3;
            }
            else { firstClicked=label3; }
            checkIfIsEqual();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Image = Resource1.images__3_1;
            label4.Tag = "lemon";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label4;
            }
            else {  firstClicked=label4; }
            checkIfIsEqual();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Image = Resource1.images__3_1;
            label8.Tag = "lemon";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label8;
            }
            else { firstClicked=label8; }
            checkIfIsEqual();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Image = Resource1.images__1_1;
            label7.Tag = "blackBerry";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label7;
            }
            else { firstClicked=label7; }
            checkIfIsEqual();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Image = Resource1.images__2_1;
            label6.Tag = "watermelon";
            number++;
            if (number % 2 == 0)
            {
                 secondClicked=label6;
            }
            else { firstClicked=label6; }
            checkIfIsEqual();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Image = Resource1.images__1_1;
            label5.Tag = "blackBerry";
            number++;
            if (number % 2 == 0)
            {
                 secondClicked=label5;
            }
            else {firstClicked=label5; }
            checkIfIsEqual();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Image = Resource1.images__1_;
            label9.Tag = "blueBerry";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label9;
            }
            else { firstClicked=label9; }
            checkIfIsEqual();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.Image = Resource1.images1;
            label13.Tag = "pear";
            number++; if (number % 2 == 0)
            {
                 secondClicked=label13;
            }
            else { firstClicked=label13; }
            checkIfIsEqual();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Image = Resource1.images__2_1;
            label10.Tag = "watermelon";
            number++; if (number % 2 == 0)
            {
                secondClicked=label10;
            }
            else { firstClicked=label10; }
            checkIfIsEqual();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Image = Resource1.images__4_;
            label14.Tag = "grapes";
            number++;
            if (number % 2 == 0)
            {
                 secondClicked=label14;
            }
            else { firstClicked=label14; }
            checkIfIsEqual();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Image = Resource1.images__5_;
            label11.Tag = "dragonFruit";
            number++; 
            if (number % 2 == 0)
            {
                secondClicked=label11;
            }
            else { firstClicked=label11; }
            checkIfIsEqual();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Image = Resource1.images;
            label15.Tag = "orange";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label15;
            }
            else { firstClicked=label15; }
            checkIfIsEqual();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Image = Resource1.images1;
            label12.Tag = "pear";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label12;
            }
            else {  firstClicked=label12; }
            checkIfIsEqual();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            label16.Image = Resource1.images__5_;
            label16.Tag = "dragonFruit";
            number++;
            if (number % 2 == 0)
            {
                secondClicked=label16;
            }
            else { firstClicked=label16; }
            checkIfIsEqual();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            foreach(Label l in tableLayoutPanel1.Controls)
            {
                l.Image = Resource1.icon1;

            }
            
            firstClicked = null;
            secondClicked = null;
        }

        bool matched = false;
        int count = 0;
        private void checkIfIsEqual()
        {
            if (number % 2 == 0) { 
            if (firstClicked.Tag == secondClicked.Tag)
            {
                    matched = true;
                    firstClicked.Enabled=false;
                    secondClicked.Enabled=false;
                    count++;
                    CheckForWinner();
                    return;
            }
            else
            {
                    firstClicked.Image = Resource1.icon1;
                   secondClicked.Image = Resource1.icon1;
                    
                    return;
            }
            
        }
            }
        private void CheckForWinner()
        {
           if (count == 8)
            {
                MessageBox.Show("You matched all the icons!", "Congratulations");
                Close();
            }
            else
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
