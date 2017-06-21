using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Threading;
namespace Simulacija
{
    public partial class grafik : Form
    {
        public grafik()
        {
            InitializeComponent();

        }
        //globalne

        int[] counter = new int[100];
        LineItem[] myCurve = new LineItem[100];
        PointPairList[] list = new PointPairList[100];
        GraphPane myPane;
        telo[] a = new telo[100];
        int brt = Form1.brt;
        static bool skk = false;
        static bool scc = false;
        static public void dis() { scc = true;  }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plotGraph();
            
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void grafik_Load(object sender, EventArgs e)
        {
            a = Form1.a;
            for (int i = 0; i < brt; i++)
            {
                counter[i] = 0;
                list[i] = new PointPairList();
            }
            //timer1.Interval = 50;
            //timer1.Start();

            skk = false;
            myPane = zedGraphControl1.GraphPane;
            myPane.Title = "Udaljenost od centra mase u funkciji vremena";
            myPane.XAxis.Title = "t";
            myPane.YAxis.Title = "r";
            Thread asd = new Thread(plotGraph);
            asd.Start();
        }

        private void plotGraph()
        {
            while (true)
            {
                try
                {
                    for (int j = 0; j < brt; j++)
                    {
                        //udaljenost od centra mase
                        double sx = 0, sy = 0, masa = 0;
                        for(int i=0;i<brt;i++)
                        {
                            sx += a[i].x * a[i].m;
                            sy += a[i].y * a[i].m;
                            masa += a[i].m;
                        }
                        double x = sx / masa;
                        double y = sy / masa;
                        double d = Math.Sqrt(Math.Pow(a[j].x - x, 2) + Math.Pow(a[j].y - y, 2));
                        //udaljenost od (0,0)
                        //double d = Math.Sqrt(a[j].x * a[j].x + a[j].y * a[j].y);
                        
                        list[j].Add(counter[j]* 0.00025, d); 
                        counter[j]++;
                        myCurve[j] = myPane.AddCurve(null, list[j], Color.Red);
                        myCurve[j].Line.IsSmooth = true;
                        myCurve[j].Line.SmoothTension = 0.1F;
                        //myCurve[j].Line.IsVisible = false;
                    }
                    zedGraphControl1.AxisChange();
                    if (!skk && !scc)
                    {
                        zedGraphControl1.Invoke(new MethodInvoker(
                        delegate
                        {
                            zedGraphControl1.Invalidate(); 
                        }));
                    }
                    if (skk) {   break; }
                    if (scc) { scc = false;  this.Invoke(new MethodInvoker(delegate { this.Close(); })); }

                    
                    
                    Thread.Sleep(1000);
                }
                catch (TimeoutException) { }
            }
        }
        
        private void grafik_FormClosing(object sender, FormClosingEventArgs e)
        {
            skk = true;
            scc = false;
            zedGraphControl1.GraphPane.CurveList.Clear();
        }
    }
}
