using System;
using System.Media;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    
            Graphics g;
            g = e.Graphics;
            LinearGradientBrush skyBrush = new LinearGradientBrush(skyRectangle, Color.DodgerBlue, Color.LightSkyBlue, 90);
            LinearGradientBrush seaBrush = new LinearGradientBrush(seaRectangle, Color.CornflowerBlue, Color.DarkBlue, 90);
                         
            g.FillRectangle(skyBrush, 0, 0, 1000, 400);
            g.FillRectangle(seaBrush, 0, 400, 1000, 600);
            
            Torpedo t = new Torpedo();
            t.drawTorpedo(g, this.ClientSize);

            Image periskop = System.Drawing.Image.FromFile("../../images/periskop.png");
            e.Graphics.DrawImage(periskop, 0, 0, (ClientSize.Width), ClientSize.Height);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
    }
}
