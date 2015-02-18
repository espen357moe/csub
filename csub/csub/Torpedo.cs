using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    public class Torpedo : Renderable
    {
        //metode for å tegne selve torpedoen
        public override void Render(Graphics g)
        {
            g.FillEllipse(Brushes.CornflowerBlue, new RectangleF(-15, -16, 32, 64));
            g.FillRectangle(Brushes.CornflowerBlue, new RectangleF(-22, 24, 48, 48));
        }

        //metode for å flytte torpedoen ved bilderuteoppdatering
        public void FrameTick(float dt)
        {
            Position = new PointF(Position.X, (Position.Y - 30 * dt));
        }
    }
}
