using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;


            int m = 6;
            double z = 0;
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            single.Area = (single.X2 * single.X2 * single.X2) / 3 - (single.X1 * single.X1 * single.X1) / 3;
            double blad_kwadrat = 0;
            double blad_trapez = 0;
            for (int j = 0; j < m; j++)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = Math.Pow(10, j + 1);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };

                string wynik = "metoda kwadratów parametry to n=";
                wynik += n.ToString();

                wynik += "  wynik to =";
                wynik += f.ToString();
                wynik += "  błąd to  = ";
                double blad = single.Area - f;
                blad_kwadrat += blad * blad;
                wynik += blad.ToString();
                wynik += "\t\t\t";
                //wynik_box.Text += wynik;

                f = 0.0F;

                n = Math.Pow(10, j + 1);
                old_i = 0;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };

                wynik = "metoda trapezów parametry to n=";

                wynik += "  wynik to =";
                wynik += f.ToString();
                wynik += "  błąd to = ";
                blad = single.Area - f;
                wynik += blad.ToString();
                wynik += "\t\t\t";
                blad_trapez += blad * blad;
                //wynik_box.Text += wynik;

            };
            string wynik2 = "blad sredniokwadratowy kwadraty = ";
            blad_kwadrat = blad_kwadrat / 6;
            wynik2 += blad_kwadrat.ToString();
            wynik2 += "   blad sredniokwadratowy trapezy = ";
            blad_trapez = blad_trapez / 6;
            wynik2 += blad_trapez.ToString();
            wynik_box.Text += wynik2;
        }
    }
}
