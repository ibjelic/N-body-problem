using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacija
{
    public partial class dodajtelo : Form
    {
        public dodajtelo()
        {
            InitializeComponent();
        }
        public telo b = new telo();
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtx.Text) || String.IsNullOrWhiteSpace(txty.Text) ||
                String.IsNullOrWhiteSpace(txtvx.Text) || String.IsNullOrWhiteSpace(txtvy.Text) ||
                String.IsNullOrWhiteSpace(txtm.Text) || String.IsNullOrWhiteSpace(txtr.Text))
                MessageBox.Show("Prazno polje!");
            else
            {
                b.x = Convert.ToSingle(txtx.Text);
                b.y = Convert.ToSingle(txty.Text);
                b.vx = Convert.ToDouble(txtvx.Text);
                b.vy = Convert.ToDouble(txtvy.Text);
                b.m = Convert.ToDouble(txtm.Text);
                b.r = Convert.ToSingle(txtr.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
