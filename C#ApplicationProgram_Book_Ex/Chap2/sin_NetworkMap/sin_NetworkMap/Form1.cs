using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sin_NetworkMap
{
    public partial class Form1 : Form
    {
        PictureBox frmPic = null;
        bool Dragging = false;
        int mouseX, mouseY;

        public Form1()
        {
            InitializeComponent();
        }
        private void tsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.tsMenu.Items.Count > 0)
            {
                PictureBox myPicBox = new PictureBox();
                myPicBox.MouseDown += new MouseEventHandler(MyMouseClick);
                myPicBox.MouseMove += new MouseEventHandler(MyMouseMove);
                myPicBox.MouseUp += new MouseEventHandler(MyMouseUp);
                myPicBox.MouseDoubleClick += new MouseEventHandler(MyMouseDoubleClick);

                this.plMap.Controls.Add(myPicBox);
                myPicBox.Location = new Point(plMap.Location.X, plMap.Location.Y);
                myPicBox.BringToFront();
                myPicBox.BackgroundImageLayout = ImageLayout.Stretch;

                int tagId = Convert.ToInt32(e.ClickedItem.Tag);
                myPicBox.BackgroundImage = tsMenu.Items[tagId].Image;
                myPicBox.Name = tsMenu.Items[tagId].ToolTipText;
                myPicBox.Tag = tsMenu.Items[tagId].Tag;
                myPicBox.Size = new System.Drawing.Size(80, 60);
                myPicBox.Invalidate();
            }
        }

        private void MyMouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
            {
                int X = pic.Location.X + pic.Width + 50 + Location.X;
                int Y = pic.Location.Y + Location.Y;

                Form2 frm2 = new Form2();
                frm2.ItemId = pic.Tag.ToString();
                frm2.ItemName = pic.Name.ToString();
                frm2.ItemDesc = pic.TabIndex;
                frm2.Itemxy = new Point(X, Y);
                frmPic = pic;
                frm2.btnOk.Click += new EventHandler(btnOk_Click);
                frm2.ShowDialog();
            }
            else if (e.Button == MouseButtons.Left)
            {
                pic.Cursor = Cursors.Hand;
                Dragging = true;
                mouseX = -e.X;
                mouseY = -e.Y;
                int clipleft = this.plMap.PointToClient(MousePosition).X - pic.Location.X;
                int cliptop = this.plMap.PointToClient(MousePosition).Y - pic.Location.Y;
                int clipwidth = this.plMap.ClientSize.Width - (pic.Width - clipleft);
                int clipheight = this.plMap.ClientSize.Height - (pic.Height - cliptop);
                Cursor.Clip = this.plMap.RectangleToScreen(new Rectangle(clipleft, cliptop, clipwidth, clipheight));
                pic.Invalidate();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string fId = ItemManage.ItemId;
            string fName = ItemManage.ItemName;

            frmPic.Name = fName;
            frmPic.Tag = Convert.ToInt32(fId);
        }

        private void MyMouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Dragging = false;
            Cursor.Clip = Rectangle.Empty;
            this.tsslblItem.Text = "아이디 : " + pic.Tag.ToString() + " 이름 : " + pic.Name.ToString();
        }

        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (Dragging)
            {
                Point MPosition = new Point();
                MPosition = this.plMap.PointToClient(MousePosition);
                MPosition.Offset(mouseX, mouseY);
                pic.Location = MPosition;
            }
        }

        private void MyMouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (Dragging)
            {
                Dragging = false;
                Cursor.Clip = Rectangle.Empty;
                pic.Invalidate();
            }
            pic.Cursor = Cursors.Arrow;
        }
    }
}
