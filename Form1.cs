using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        float feet;
        float inches;
        float cm;
        float kg;
        float pounds;

        bool show1 = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (show1)
            {
                float BMI = (pounds / ((feet * 12) + inches) / ((feet * 12) + inches)) * 703;
            }
        }
        
        private void textBoxCM_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxCM.Text, out var s)))
            {
                cm = float.Parse(textBoxCM.Text);
                show1 = true;
            }
            else{
                show1 = false;
            }
        }


        private void textBoxKG_TextChanged(object sender, EventArgs e)
        {
            if ((float.TryParse(textBoxKG.Text, out var s)) )
            {
                show1 = true;
                kg = float.Parse(textBoxKG.Text);
            }
            else
            {
                show1 = false;
            }
        }

        private void calculateMetric_Click(object sender, EventArgs e)
        {
            float BMI = (kg / (cm * cm) * 10000);
            label14.Text = "" + BMI;

            if (BMI <= 18)
            {
                pictureBox1.Image = Properties.Resources.low;
                l1.Text = "▼";
                l2.Text = "";
                l3.Text = "";
                l4.Text = "";
            }
            if (BMI >= 18 && BMI <= 25)
            {
                pictureBox1.Image = Properties.Resources.man;
                l1.Text = "";
                l2.Text = "▼";
                l3.Text = "";
                l4.Text = "";
            }
            if (BMI >= 25 && BMI <= 30)
            {
                pictureBox1.Image = Properties.Resources.hight;
                l1.Text = "";
                l2.Text = "";
                l3.Text = "▼";
                l4.Text = "";
            }
            if (BMI >= 30)
            {
                pictureBox1.Image = Properties.Resources.hight_woman;
                l1.Text = "";
                l2.Text = "";
                l3.Text = "";
                l4.Text = "▼";
            }
            else
            {
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            pictureBox1.Image = Properties.Resources.man;
            label14.Text = "";
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            pictureBox1.Image = Properties.Resources.woman;
            label14.Text = "";
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            textBoxCM.Clear();
            textBoxKG.Clear();
            pictureBox1.Image = Properties.Resources.man;
            label14.Text = "";
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
