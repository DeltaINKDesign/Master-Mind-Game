using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind_Game
{
    public partial class Form1 : Form
    {
        int fl;  //postep gracza

        int[] tablicaOdpowiedzi = new int[4];  //tablica wylosowanych poprawnych odpowiedzi
        int[] tablicaStrzalow = new int[4];   //tablica odpowiedzi gracza

        int skok = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Random nowy = new Random();
            for (int i = 0; i < 4; i++)
            {
                tablicaOdpowiedzi[i] = nowy.Next(9);
            }

            fl = 10;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablicaStrzalow[0] = int.Parse(textBox1.Text);
            tablicaStrzalow[1] = int.Parse(textBox2.Text);
            tablicaStrzalow[2] = int.Parse(textBox3.Text);
            tablicaStrzalow[3] = int.Parse(textBox4.Text);

            switch (fl)
            {
                case 10:

                    int iletrafionych = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (tablicaStrzalow[k] == tablicaOdpowiedzi[j])
                            {
                                iletrafionych = iletrafionych + 1;
                                break;
                            }

                        }
                        //przechodzi i sprawdza odpowiedzi
                    }
                    if (iletrafionych == 4)
                    {
                        MessageBox.Show("Wygrales !");
                    }
                    else
                    {
                        MessageBox.Show("Trafiles: " + iletrafionych);
                    }

                    break;

            }
            skok = skok + 10;
            progressBar1.Value = skok;

            if (progressBar1.Value == 100)
            {
                MessageBox.Show("Przegrałeś! ");
                MessageBox.Show("Wylosowane liczby to: " + tablicaOdpowiedzi[0] + " " + tablicaOdpowiedzi[1] + " " + tablicaOdpowiedzi[2] + " " + tablicaOdpowiedzi[3]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
