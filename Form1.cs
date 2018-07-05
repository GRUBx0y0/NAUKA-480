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
    public partial class MNForm : Form
    {
        public MNForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MNForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectedItem_click(object sender, EventArgs e)
        {
            MessageBox.Show(lst1.SelectedItem.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FInfo ForM = new FInfo();
            ForM.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/%D0%A4%D0%B8%D0%B7%D0%B8%D0%BA%D0%B0");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
