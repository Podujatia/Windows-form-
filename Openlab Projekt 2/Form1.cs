using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Openlab_Projekt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vyber z koloniek na akí tip eventu chceš ísť, Kde chceš aby sa konal, Kedy chceš aby sa konal.");
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            //test na zaznamenanie outputu 
            string mesto = comboBox1.Text;
            //label4.Text = mesto;

            //test na zaznamenanie outputu 
            string typ = comboBox2.Text;
            //label5.Text = typ;
           
            //numUpDown pre dátum 
            string den1 = label11.Text = numericUpDown1.Value.ToString();
            string mesac1 = label11.Text = numericUpDown2.Value.ToString();
            string rok1 = label11.Text = numericUpDown3.Value.ToString();
            //label11.Text = den1 +". "+ mesac1 +". "+ rok1;
            string den2 = label12.Text = numericUpDown4.Value.ToString();
            string mesac2 = label12.Text = numericUpDown5.Value.ToString();
            string rok2 = label12.Text = numericUpDown6.Value.ToString();
            //label12.Text = den2 + ". " + mesac2 + ". " + rok2;
            //MessageBox.Show("Kód nedorobený :("); //zapoznámkovaní kód
            //Form2 zjav sa a zober dáta čo potrebujeś  
            Form2 f = new Form2(mesto,typ,den1,mesac1,rok1,den2,mesac2,rok2);
            f.ShowDialog();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //limity pre NumUpDown
            numericUpDown1.Maximum = 31;
            numericUpDown1.Minimum = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //limity pre NumUpDown
            numericUpDown2.Maximum = 12;
            numericUpDown2.Minimum = 1;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //limity pre NumUpDown
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 2022;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
