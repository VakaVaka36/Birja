using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }


        int Akcii = 0;
        int[,] Vybor = new int[3, 3];
        int Neftb = 0;


        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Vybor[i, j] = -1;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rnd = new Random(Environment.TickCount);
            Neftb = rnd.Next(3);
            Akcii = rnd.Next(3);

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            switch (Neftb)
            {
                case 0:
                    label3.ForeColor = Color.Red;
                    label3.Text = "Падает";
                    break;

                case 1:
                    label3.ForeColor = Color.Yellow;
                    label3.Text = "Стабильна";
                    break;

                case 2:
                    label3.ForeColor = Color.Green;
                    label3.Text = "Растёт";
                    break;
            }

            switch (Akcii)
            {
                case 0:
                    label4.ForeColor = Color.Red;
                    label4.Text = "Падает";
                    break;

                case 1:
                    label4.ForeColor = Color.Yellow;
                    label4.Text = "Стабилен";
                    break;

                case 2:
                    label4.ForeColor = Color.Green;
                    label4.Text = "Растет";
                    break;
            }

            if (button1WasClicked == true)
                if (Vybor[Neftb, Akcii] == -1)
                {
                    timer1.Enabled = false;
                    label5.Text = "Выберите действие";
                }

            if (Vybor[Neftb, Akcii] == 0)
            {
                radioButton1.Checked = true;
            }

            if (Vybor[Neftb, Akcii] == 1)
            {
                radioButton2.Checked = true;
            }

            if (Vybor[Neftb, Akcii] == 2)
            {
                radioButton3.Checked = true;
            }

        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Vybor[Neftb, Akcii] = 0;
                timer1.Enabled = true;
                label5.Text = "";
            }

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Vybor[Neftb, Akcii] = 1;
                timer1.Enabled = true;
                label5.Text = "";
            }

        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Vybor[Neftb, Akcii] = 2;
                timer1.Enabled = true;
                label5.Text = "";
            }
        }

        private bool button1WasClicked = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1WasClicked = true;

        }
    }
}
