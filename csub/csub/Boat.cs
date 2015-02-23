﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    //abstrakt superklasse implementerer interfacet Renderable
    public abstract class Boat : IRenderable
    {
        public abstract float Speed { get; set; }
        public abstract MainGameForm.Direction Direction { get; }      
        public abstract Image Image { get; }       

        public void FrameTick(float dt)
        {
            Position = new PointF((Position.X + 30 * dt), Position.Y);
            System.Console.WriteLine("Skiff Position: " + Position.ToString());
        }

        public PointF Position { get; set; }
        public void Render(Graphics g)
        {

            g.DrawImage(Image, new Point(-Image.Width / 2, -Image.Height));
        }


    }

}
