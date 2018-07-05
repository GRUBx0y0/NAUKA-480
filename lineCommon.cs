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
    public partial class lineCommon : Form
    {
        double v = 0, t = 0, s = 0;
        bool vb = false, tb = false, sb = false;

        private void vres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public lineCommon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          
           if(vtext.Text.Length != 0)
            {

                try
                {
                    v = Double.Parse(vtext.Text);
                    vb = true;
                }

                catch(FormatException)
                {
                    MessageBox.Show("Ввод символов запрещен! (Помните, что при вводе дробей нужно использовать не . а ,)");
                }
               
            }

            if (stext.Text.Length != 0)
            {

                try
                {
                  s = Double.Parse(stext.Text);
                  sb = true;
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


            int counter = 0;

            if (vb == false)
            {
                counter++;
            }

            if (sb == false)
            {
                counter++;
            }

            if(tb == false)
            {
                counter++;
            }

            if(counter > 1)
            {
                MessageBox.Show("Слишком много неизвестных переменных (Расчет невозможен)");
            }


            else
            {
                if(sb == false)
                {
                    s = v * t;
                }

                if (vb == false)
                {
                    if(t != 0)
                    {
                        v = s / t;
                    }

                    else
                    {
                        MessageBox.Show("Время не может быть равно нулю при расчете скорости");
                    }
                    
                }

                if (tb == false)
                {
                    if(v != 0)
                    {
                      t = s / v;
                    }

                    else
                    {
                        MessageBox.Show("Скоость не может быть равна нулю при расчете времени");
                    }

                }

                vres.Text = v.ToString();
                sres.Text = s.ToString();
                tres.Text = t.ToString();

                vtext.Text = "";
                stext.Text = "";
                ttext.Text = "";

                tb = false;
                sb = false;
                vb = false;
            }


        }
    }
}
