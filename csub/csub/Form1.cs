﻿using System;
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
                torpedo = new Torpedo() { Position = new PointF(0, (float)this.ClientSize.Height / 2) };
            }
        }

        //metode for å tegne en bilderute / frame
        private void Render(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            LinearGradientBrush skyBrush = new LinearGradientBrush(skyRectangle, Color.DodgerBlue, Color.LightSkyBlue, 90);
            LinearGradientBrush seaBrush = new LinearGradientBrush(seaRectangle, Color.CornflowerBlue, Color.DarkBlue, 90);

            g.FillRectangle(skyBrush, 0, 0, ClientSize.Width, ClientSize.Height);
            g.FillRectangle(seaBrush, 0, 400, ClientSize.Width, (ClientSize.Height /3)*2);

            if (torpedo != null)
            {
                
                var transform = g.Transform;
                var mat = new Matrix(1, 0, 0, 1, 0, 0); // Identitetsmatrise

                int h2 = this.Height / 2;
                var scale = torpedo.Position.Y / h2;

                //Vi flytter koordinatsystemet til midten av skjermen istedet for øverst i høyre hjørne.
                mat.Translate((float) this.ClientSize.Width / 2, (float)this.ClientSize.Height / 2);
                // Vi skalerer etter avstand fra horisonten
                mat.Scale(scale, scale);
                // Vi flytter igjen koordinatsystemet til der torpedoen befinner seg.
                mat.Translate(torpedo.Position.X, torpedo.Position.Y);

                torpedo.Render(g);
                g.Transform = transform;
            }

            
            
            Image periskop = Image.FromFile("../../images/periskop.png");

            g.DrawImage(periskop, 0, 0, (ClientSize.Width), ClientSize.Height);                 
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (torpedo != null) torpedo.FrameTick((float)0.1);
            Invalidate();

        }

    }            
}
