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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace csub
{
    public partial class MainGameForm : Form
    {

        private bool running;
        public bool IsRunning { get { return running; } }
        private Torpedo torpedo;
        private OurSoundPlayer soundPlayer = new OurSoundPlayer();
        public enum Direction { Left, Right }
        private List<Boat> boats; 



        private Image periskop = Image.FromFile("../../images/periskop.png");

        public MainGameForm()
        {
            InitializeComponent();
            boats = new List<Boat>();
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
                if (torpedo == null)
                {
                    soundPlayer.playTorpedoFire();
                    torpedo = new Torpedo() { Position = new PointF(0, (float)this.ClientSize.Height / 2) };
                }
                else
                {
                    soundPlayer.playReloading();
                }
 
           }
 
        }


        private void Render(IRenderable i, Graphics g)
        {
            var transform = g.Transform;
            var mat = new Matrix(1, 0, 0, 1, 0, 0); // Identitetsmatrise

            int h2 = this.Height / 3;
            var scale = i.Position.Y / h2;

            //Vi flytter koordinatsystemet til midten av skjermen istedet for øverst i høyre hjørne.
            mat.Translate((float)ClientSize.Width / 2, ((float)ClientSize.Height / 10) * 4);
            // Vi skalerer etter avstand fra horisonten
            mat.Scale(scale, scale);
            // Vi flytter igjen koordinatsystemet til der gjenstanden befinner seg.
            mat.Translate(i.Position.X, i.Position.Y);

            g.Transform = mat;
            i.Render(g);
            g.Transform = transform;
        }

        //metode for å tegne en bilderute / frame
        private void Render(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var windowHeight = ClientSize.Height;
            var windowWidth = ClientSize.Width;

            Rectangle skyRectangle = new Rectangle(0, 0, windowWidth, (windowHeight/10)*4);
            Rectangle seaRectangle = new Rectangle(0, ((windowHeight/10)*4), windowWidth, (windowHeight/10)*6);

            LinearGradientBrush skyBrush = new LinearGradientBrush(skyRectangle, Color.DodgerBlue, Color.LightSkyBlue, 90);
            LinearGradientBrush seaBrush = new LinearGradientBrush(seaRectangle, Color.CornflowerBlue, Color.DarkBlue, 90);

            g.FillRectangle(skyBrush, 0, 0, windowWidth, windowHeight);
            g.FillRectangle(seaBrush, 0, ((windowHeight / 10) * 4), windowWidth, (windowHeight / 10) * 6);

            if (boats != null)
            {
                foreach (var boat in boats)
                {                   
                    Render(boat, g);
                   
                }
            }

            if (torpedo != null)
            {                
                Render(torpedo, g);            
            }

            
            
            

            g.DrawImage(periskop, 0, 0, (ClientSize.Width), ClientSize.Height);                 
        }    

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (torpedo != null)
            {
                torpedo.FrameTick((float)0.1);
                if (torpedo.Position.Y <= 0)
                    torpedo = null;
            }

            //vi genererer en tilfeldig båt etter en viss sannsynlighet pr. bilderute
            Random rnd = new Random();       
            int prb = rnd.Next(250);
            if (prb == 1)
            {
                var theSkiff = new Skiff();
                theSkiff.Speed = (rnd.Next(1,5));
                theSkiff.Position = new PointF(-(ClientSize.Width), rnd.Next(50, 200));
                boats.Add(theSkiff);
                System.Console.WriteLine("Skiff added. Speed: " +theSkiff.Speed + ", distance: " + theSkiff.Position.Y);
                soundPlayer.playNewSkiff(); 
                theSkiff.FrameTick((float)0.1);              
            }

            foreach (var boat in boats)
            {
               boat.FrameTick((float)0.1);
                
            }

            Refresh();



        } 
    

        public void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        //    //Score
            scoreLbl.Text = Convert.ToString(score);

            XDocument xdoc = XDocument.Load("test.xml");

            xdoc.Root.Add(
                new XElement("Snippet",
                    new XAttribute("name", scoreLbl.Text),
                    new XElement("SnippetCode", scoreLbl.Text))
                );
            xdoc.Save("test.xml");

        }


    }            
}
