using System;
using System.Media;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csub
{
    public partial class Form1 : Form
    {
        private bool running;
        private readonly Form display;
        public bool IsRunning { get { return running; } }
        private Torpedo torpedo;
        private Rectangle skyRectangle = new Rectangle(0, 0, 1000, 400);
        private Rectangle seaRectangle = new Rectangle(0, 400, 1000, 600);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {     
            Graphics g = e.Graphics;          
            Render(g);           
        }

        //Instansierer ny torpedo om bruker trykker space
        private void DisplayOnKeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            if (keyPressEventArgs.KeyChar == ' ')
            {
                torpedo = new Torpedo() { Position = new PointF(0, (float)display.ClientSize.Height / 2) };
            }
        }

        //metode for å tegne en bilderute / frame
        private void Render(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            LinearGradientBrush skyBrush = new LinearGradientBrush(skyRectangle, Color.DodgerBlue, Color.LightSkyBlue, 90);
            LinearGradientBrush seaBrush = new LinearGradientBrush(seaRectangle, Color.CornflowerBlue, Color.DarkBlue, 90);

            g.FillRectangle(skyBrush, 0, 0, 1000, 400);
            g.FillRectangle(seaBrush, 0, 400, 1000, 600);

            if (torpedo != null) { torpedo.Render(g);}           
            
            Image periskop = Image.FromFile("../../images/periskop.png");

            g.DrawImage(periskop, 0, 0, (ClientSize.Width), ClientSize.Height);                 
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

    }            
}
