using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_GraphPaint
{
    public partial class Form1 : Form
    {
        private Timer Time;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();

            Time = new Timer();
            Time.Interval = 1000;
            Time.Tick += Time_Tick;
            Time.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphCore.OpenType = global::sin_GraphCore.sin_GraphCore.ChartControlOpenType.Bar;
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            double ValueAdd;
            int n = r.Next(1, 45);
            int s = r.Next(1, 3);
            try
            {
                if (s / 2 == 0)
                    ValueAdd = Convert.ToDouble(n);
                else
                    ValueAdd = Convert.ToDouble(-n);
                GraphCore.AddValue((float)ValueAdd);
                GraphCore.RefreshControl();
            }
            catch
            {
                return;
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphCore.OpenType = global::sin_GraphCore.sin_GraphCore.ChartControlOpenType.Graph;
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            GraphCore.OpenType = global::sin_GraphCore.sin_GraphCore.ChartControlOpenType.Bar;
        }
    }
}
