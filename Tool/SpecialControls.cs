using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckoutSystem
{
    public static class Gdi32
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
    }

    public class PersonButton : Button
    {
        [DefaultValue(false)]
        public override bool AutoSize { get; set; }

        private int _Radius = 16;

        public int Radius { get { return _Radius; } set { _Radius = value; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //繪製漸層樣式
            this.Region = System.Drawing.Region.FromHrgn(Gdi32.CreateRoundRectRgn(0, 0, this.Width, this.Height, this.Radius, this.Radius));

            Graphics g = e.Graphics;

            g.FillRectangle(
                new SolidBrush(this.BackColor),
                new RectangleF(PointF.Empty, this.Size));

            g.FillRegion(
                new LinearGradientBrush(new PointF(0, 0), new PointF(0, this.Height), Color.FromArgb(50, this.BackColor), Color.FromArgb(250, this.BackColor)),
                Region);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new RectangleF(PointF.Empty, this.Size), format);
        }
    }

    public class PersonLabel : Label
    {
        [DefaultValue(false)]
        public override bool AutoSize { get; set; }

        private int _Radius = 12;
        public int Radius { get { return _Radius; } set { _Radius = value; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //繪製漸層樣式
            this.Region = System.Drawing.Region.FromHrgn(Gdi32.CreateRoundRectRgn(0, 0, this.Width, this.Height, this.Radius, this.Radius));

            Graphics g = e.Graphics;

            g.FillRectangle(
                new SolidBrush(this.BackColor),
                new RectangleF(PointF.Empty, this.Size));

            g.FillRegion(
                new LinearGradientBrush(new PointF(0, 0), new PointF(0, this.Height), Color.FromArgb(50, this.BackColor), Color.FromArgb(250, this.BackColor)),
                Region);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;

            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new RectangleF(PointF.Empty, this.Size), format);
        }
    }

    public class PersonListBox : ListBox
    {
        public PersonListBox()
        {

        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Items.Count > 0)
            {
                if (-1 != e.Index)
                {
                    Display item = (Display)this.Items[e.Index];
                    item.DrawItem(e);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }

    public class HistoryListBox : ListBox
    {
        public HistoryListBox()
        {

        }
        
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (this.Items.Count > 0)
            {
                if (-1 != e.Index)
                {
                    History item = (History)this.Items[e.Index];
                    item.DrawItem(e);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }

    public class History
    {
        public History()
        {

        }

        public History(Bitmap image)
        {
            Image = image;
        }

        public Bitmap Image { get; set; }

        public void DrawItem(DrawItemEventArgs e)
        {
            e.Graphics.DrawImage(Image, new Rectangle(e.Bounds.X + 10, e.Bounds.Y + 10, 120, 120));
        }
    }

    public class Display
    {
        public Display()
        {

        }

        /// <summary>
        /// 顯示內容
        /// </summary>
        /// <param name="image">顯示商品影像</param>
        /// <param name="name">顯示商品名稱</param>
        /// <param name="pic">顯示商品數量</param>
        /// <param name="price">顯示商品價格</param>
        public Display(Bitmap image, string name, int pic, int price)
        {
            Image = image;
            Name = name;
            Number = pic;
            Price = price;
        }

        /// <summary>
        /// 顯示商品影像
        /// </summary>
        public Bitmap Image { get; set; }

        /// <summary>
        /// 顯示商品數量
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 顯示商品名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 顯示商品價格
        /// </summary>
        public int Price { get; set; }

        public void DrawItem(DrawItemEventArgs e)
        {
            e.Graphics.DrawImage(Image, new Rectangle(e.Bounds.X + 10, e.Bounds.Y + 10, 50, 50));
            e.Graphics.DrawString(Name, new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 65, e.Bounds.Y + 20));

            if (1 >= Number)
            {

            }
            else if (10 > Number)
            {
                e.Graphics.FillEllipse(Brushes.SeaGreen, new Rectangle(e.Bounds.X + 50, e.Bounds.Y, 20, 20));
                e.Graphics.DrawString(Number.ToString(), new Font("微軟正黑體", 10, FontStyle.Bold), Brushes.White, new PointF(e.Bounds.X + 55, e.Bounds.Y));
            }
            else if (100 > Number)
            {
                e.Graphics.FillEllipse(Brushes.SeaGreen, new Rectangle(e.Bounds.X + 50, e.Bounds.Y, 20, 20));
                e.Graphics.DrawString(Number.ToString(), new Font("微軟正黑體", 10, FontStyle.Bold), Brushes.White, new PointF(e.Bounds.X + 50, e.Bounds.Y));
            }

            if (10 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365, 20 + e.Bounds.Y));
            else if (100 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 1, 20 + e.Bounds.Y));
            else if (1000 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 2, 20 + e.Bounds.Y));
            else if (10000 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 3.5F, 20 + e.Bounds.Y));
            else if (100000 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 4.5F, 20 + e.Bounds.Y));
            else if (1000000 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 5.5F, 20 + e.Bounds.Y));
            else if (10000000 > Price) e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 7, 20 + e.Bounds.Y));
            else e.Graphics.DrawString("$" + Price.ToString("N0"), new Font("微軟正黑體", 16, FontStyle.Bold), Brushes.Black, new PointF(e.Bounds.X + 365 - 13 * 8, 20 + e.Bounds.Y));
        }
    }
}
