using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalistaCalc
{
    public partial class way : Form
    {
        double v , v0,a,t,s;
        bool vb = false, v0b = false, tb = false, ab = false, sb = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (atext.Text.Length != 0)
            {

                try
                {
                    a = Double.Parse(vtext.Text);
                    ab = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }

            }
            if (vtext.Text.Length != 0)
            {

                try
                {
                    v = Double.Parse(vtext.Text);
                    vb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }

            }
            if (ttext.Text.Length != 0)
            {
                try
                {
                    t = Double.Parse(ttext.Text);
                    tb = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }

            }
            if (vtext.Text.Length != 0)
            {

                try
                {
                    v0 = Double.Parse(vtext.Text);
                    v0b = true;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }

            }
            int counter = 0;

            if (ab == false)
            {
                counter++;
            }

            if (vb == false)
            {
                counter++;
            }

            if (tb == false)
            {
                counter++;
            }
            if (v0b == false)
            {
                counter++;
            }

            if (counter > 1)
            {
                MessageBox.Show("Слишком много неизвестных переменных (Расчет невозможен)");
            }
            else
            {
                if (sb == false)
                {
                    if (t != 0) {
                        s = v0 * t + ((a * t * t) / 2);
 }
                    else
                    {
                        s = (v * v - v0 * v0) / 2;
                    }
        }

                if (ab == false)
                {
                    if (t != 0)
                    {
                        a = (v - v0) / t;
                    }
                    else
                    {
                        MessageBox.Show("Время не может быть равно нулю при расчете ускорения");
                    }
                }

                if (vb == false)
                {
                    if (t != 0)
                    {
                        v = v0 + (a * t);
                    }
                    else
                    {
                        MessageBox.Show("Время не может быть равно нулю при расчете скорости");
                    }

                }

                if(tb == false)
                {
                    if (v != 0)
                    {
                        t = s / v;
                    }
                    else
                    {
                        MessageBox.Show("Скоость не может быть равна нулю при расчете времени");
                    }
                }


                vres.Text = v.ToString();
                v0res.Text = v0.ToString();
                ares.Text = a.ToString();
                tres.Text = t.ToString();
                sres.Text = s.ToString();

                vtext.Text = "";
                v0text.Text = "";
                atext.Text = "";
                ttext.Text = "";
                stext.Text = "";

                vb = false; v0b = false; tb = false; ab = false; sb = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void vres_TextChanged(object sender, EventArgs e)
        {

        }

        public way()
        {
            InitializeComponent();
        }

        private void way_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
