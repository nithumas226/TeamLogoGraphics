using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamLogoGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics L = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen whitePen = new Pen(Color.White);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font titleFont = new Font("Georgia", 35, FontStyle.Bold);
            Font trademarkFont = new Font("Georgia", 10);

            L.Clear(Color.White);
            L.DrawEllipse(redPen, 50, 50, 250, 250);
            L.FillEllipse(redBrush, 50, 50, 250, 250);
            L.DrawEllipse(whitePen, 100, 100, 150, 150);
            L.FillEllipse(whiteBrush, 100, 100, 150, 150);
            L.DrawEllipse(redPen, 137, 138, 75, 75);
            L.FillEllipse(redBrush, 137, 138, 75, 75);

            L.DrawString("Target", titleFont, redBrush, 90, 300);

            L.TranslateTransform(260, 290);
            L.RotateTransform(45);
            L.DrawString("TM", trademarkFont, redBrush, 0, 0);
            L.ResetTransform();

        }
    }
}
