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
    public partial class accelerated_move : Form
    {
        public accelerated_move()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DC(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            switch (index)
            {
                case 0:
                   way w = new way();
                    w.ShowDialog();
                    break;
                case 1:
                    Coordinate c = new Coordinate();
                    c.ShowDialog();
                    break;
                case 2:
                    Speed s = new Speed();
                    s.ShowDialog();
                    break;

            }
        }

        private void accelerated_move_Load(object sender, EventArgs e)
        {

        }

        
    }
}
