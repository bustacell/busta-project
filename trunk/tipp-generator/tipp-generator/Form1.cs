using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tipp_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            teamlabel1.Text =  "Team A";
            teamlabel2.Text = "Team B";
            teamlabel3.Text = "Team C";
            teamlabel4.Text = "Team D";
            teamlabel5.Text = "Team E";
            teamlabel6.Text = "Team F";
            teamlabel7.Text = "Team G";
            teamlabel8.Text = "Team H";
            teamlabel9.Text = "Team I";
            teamlabel10.Text = "Team J";
            teamlabel11.Text = "Team K";
            teamlabel12.Text = "Team L";
            teamlabel13.Text = "Team M";
            teamlabel14.Text = "Team N";
            teamlabel15.Text = "Team O";
            teamlabel16.Text = "Team P";
            teamlabel17.Text = "Team Q";
            teamlabel18.Text = "Team R";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Random zufall = new Random(); ;

            int[] randoms = new int[18];

            for (int i = 0; i < randoms.Length; i++)
            {
                randoms[i] = zufall.Next(0, 4);
            }        

            teamtextBox1.Text = randoms[0].ToString();
            teamtextBox2.Text = randoms[1].ToString();
            teamtextBox3.Text = randoms[2].ToString();
            teamtextBox4.Text = randoms[3].ToString();
            teamtextBox5.Text = randoms[4].ToString();
            teamtextBox6.Text = randoms[5].ToString();
            teamtextBox7.Text = randoms[6].ToString();
            teamtextBox8.Text = randoms[7].ToString();
            teamtextBox9.Text = randoms[8].ToString();
            teamtextBox10.Text = randoms[9].ToString();
            teamtextBox11.Text = randoms[10].ToString();
            teamtextBox12.Text = randoms[11].ToString();
            teamtextBox13.Text = randoms[12].ToString();
            teamtextBox14.Text = randoms[13].ToString();
            teamtextBox15.Text = randoms[14].ToString();
            teamtextBox16.Text = randoms[15].ToString();
            teamtextBox17.Text = randoms[16].ToString();
            teamtextBox18.Text = randoms[17].ToString();
        }

        private void copybutton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox1.Text, TextDataFormat.Text);
        }

        private void copybutton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox2.Text, TextDataFormat.Text);
        }

        private void copybutton3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox3.Text, TextDataFormat.Text);
        }

        private void copybutton4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox4.Text, TextDataFormat.Text);
        }

        private void copybutton5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox5.Text, TextDataFormat.Text);
        }

        private void copybutton6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox6.Text, TextDataFormat.Text);
        }

        private void copybutton7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox7.Text, TextDataFormat.Text);
        }

        private void copybutton8_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox8.Text, TextDataFormat.Text);
        }

        private void copybutton9_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox9.Text, TextDataFormat.Text);
        }

        private void copybutton10_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox10.Text, TextDataFormat.Text);
        }

        private void copybutton11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox11.Text, TextDataFormat.Text);
        }

        private void copybutton12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox12.Text, TextDataFormat.Text);
        }

        private void copybutton13_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox13.Text, TextDataFormat.Text);
        }

        private void copybutton14_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox14.Text, TextDataFormat.Text);
        }

        private void copybutton15_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox15.Text, TextDataFormat.Text);
        }

        private void copybutton16_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox16.Text, TextDataFormat.Text);
        }

        private void copybutton17_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox17.Text, TextDataFormat.Text);
        }

        private void copybutton18_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(teamtextBox18.Text, TextDataFormat.Text);
        }
    }
}
