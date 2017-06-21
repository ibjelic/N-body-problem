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

namespace Simulacija
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double G;
        double dt = 1E-5;
        static public int brt { get; set; } = 0;
        bool io = false;
        static public telo[] a { get; set; } = new telo[100];
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 40; //ms
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<brt;i++)
            {
                e.Graphics.FillEllipse(Brushes.Black, a[i].x, a[i].y, a[i].r, a[i].r);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!io)
            {
                G = Convert.ToDouble(txtConst.Text);
                double multp = Convert.ToDouble(txtMultp.Text);
                for (int i = 0; i < brt; i++)
                {
                    a[i].setc(G);
                    a[i].rmultp = multp;
                }
                txtConst.Enabled = false;
                txtMultp.Enabled = false;
                btnStart.Text = "Stop";
                timer1.Start();
                btnreset.Enabled = false;
                btnAdd.Enabled = false;
                btnAddFile.Enabled = false;
                io = true;
            } else if(io)
            {
                btnreset.Enabled = true;
                txtConst.Enabled = true;
                txtMultp.Enabled = true;
                btnStart.Text = "Start";
                btnAdd.Enabled = true;
                btnAddFile.Enabled = true;
                timer1.Stop();
                io = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < brt; i++)
                for (int j = 0; j < brt; j++)
                    if (i != j)
                        a[i].sila(a[j]);

            for (int i = 0; i < brt; i++)
            {
                a[i].x += (float)(a[i].vx * dt);
                a[i].y += (float)(a[i].vy * dt);
            }
            if (chkodb.Checked)
            {
                for (int i = 0; i < brt; i++)
                {
                    if (a[i].x >= panel1.Width - a[i].r) a[i].vx *= (-1);
                    if (a[i].y >= panel1.Height - a[i].r) a[i].vy *= (-1);
                    if (a[i].x < 0) a[i].vx *= (-1);
                    if (a[i].y < 0) a[i].vy *= (-1);
                }
            }
            /* sudar
                for (int i = 0; i < brt; i++)
                    for (int j = 0; j < brt; j++)
                        if (i != j)
                            if (a[i].sudar(a[j]))
                            {
                                btnreset.Enabled = true;
                                txtConst.Enabled = true;
                                txtMultp.Enabled = true;
                                btnStart.Text = "Start";
                                btnAdd.Enabled = true;
                                btnAddFile.Enabled = true;
                                io = false;
                                timer1.Stop();
                            } */
            panel1.Invalidate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (dodajtelo dlg = new dodajtelo())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    a[brt] = dlg.b;
                    brt++;
                    lblBrt.Text = "Broj tela: " + brt;
                }
            }
            panel1.Invalidate();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            grafik.dis();
           
            DialogResult dlg = MessageBox.Show("Resetovati?", "Reset", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                
                for (int i = 0; i < brt; i++) a[i] = null;
                brt = 0;
                txtConst.Text = "1E0";
                txtMultp.Text = "1E0";
                lblBrt.Text = "Broj tela: " + brt;
                panel1.Invalidate();
            }
            btnAdd.Enabled = true;
            btnAddFile.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) //btnAddFile
        {
            string line;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            StreamReader f = new StreamReader(openFileDialog1.FileName);
            while ((line = f.ReadLine()) != null)
                {
                    string[] parm = line.Split(' ');  //x y vx vy m r
                    telo b = new telo();
                    b.x = Convert.ToSingle(parm[0]);
                    b.y = Convert.ToSingle(parm[1]);
                    b.vx = Convert.ToDouble(parm[2]);
                    b.vy = Convert.ToDouble(parm[3]);
                    b.m = Convert.ToDouble(parm[4]);
                    b.r = Convert.ToSingle(parm[5]);
                    a[brt] = b;
                    brt++;
                    lblBrt.Text = "Broj tela: " + brt;
                    panel1.Invalidate();
                } 
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtConst.Text = "9E9";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtConst.Text = "6.75E-11";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(!io)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grafik dlg = new grafik();
            dlg.Show();
        }
    } 
}
