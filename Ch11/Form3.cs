using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        Graphics dot;
        Rectangle myRect = new Rectangle();

        Brush blueBrush = new SolidBrush(Color.Blue);
        Pen blackPen = new Pen(Color.Black);

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            
            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100);

            graphics.DrawRectangle(blackPen, rect);
            graphics.FillRectangle(redBrush, rect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);

            for(int i = 1; i <= 19; i++)
            {
                graphics.DrawLine(blackPen, new Point(20, 20 * i), new Point(20 * 19, 20 * i));
                graphics.DrawLine(blackPen, new Point(20 * i, 20), new Point(20 * i, 20 * 19));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            Brush redBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(120, 10, 100, 100);

            graphics.DrawEllipse(blackPen, rect);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            myRect.Y += 10;
            Console.WriteLine("Tick");
            Invalidate();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            dot = this.CreateGraphics();
            myRect.X = 360;
            myRect.Y = 10;

            myRect.Width = 10;
            myRect.Height = 10;

            dot.DrawRectangle(blackPen, myRect);
            dot.FillRectangle(blueBrush, myRect);
        }
    }
}
