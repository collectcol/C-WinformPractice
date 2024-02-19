using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace sin_ShapeDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsLineRectangle im = new clsLineRectangle();
            this.plPaint.MouseDown += new MouseEventHandler(im.clsLineRectangle_OnMouseDown);
            this.plPaint.MouseMove += new MouseEventHandler(im.clsLineRectangle_OnMouseMove);
            this.plPaint.MouseUp += new MouseEventHandler(im.clsLineRectangle_OnMouseUp);
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbLine.Checked == true)
            {
                clsLineRectangle.checkflags = true;
            }
        }

        private void rbRect_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbRect.Checked  == true)
            {
                clsLineRectangle.checkflags = false;
            }
        }
    }

    public class clsLineRectangle
    {
        public static bool checkflags = true;
        Rectangle SelectRect = new Rectangle();
        Point ps = new Point();
        Point pe = new Point();

        public void clsLineRectangle_OnMouseDown(Object sender, MouseEventArgs e)
        {
            SelectRect.Width = 0;
            SelectRect.Height = 0;
            SelectRect.X = e.X;
            SelectRect.Y = e.Y;
            ps.X = e.X;
            ps.Y = e.Y;
            pe = ps;
        }

        public void clsLineRectangle_OnMouseMove(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel Paintform = (Panel)sender;
                if (checkflags)
                {
                    ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Color.Black);
                    pe = new Point(e.X, e.Y);
                    ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Color.Black);
                }
                else
                {
                    ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                    SelectRect.Width = e.X - SelectRect.X;
                    SelectRect.Height = e.Y - SelectRect.Y;
                    ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                }
            }
        }

        public void clsLineRectangle_OnMouseUp(Object sender, MouseEventArgs e)
        {
            Panel Paintform = (Panel)sender;
            Graphics g = Paintform.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            if(checkflags)
            {
                ControlPaint.DrawReversibleLine(Paintform.PointToScreen(ps), Paintform.PointToScreen(pe), Color.Black);
                g.DrawLine(p, ps, pe);
            }
            else
            {
                ControlPaint.DrawReversibleFrame(Paintform.RectangleToScreen(SelectRect), Color.Black, FrameStyle.Dashed);
                g.DrawRectangle(p, SelectRect);
            }
            g.Dispose();
        }
    }
}
