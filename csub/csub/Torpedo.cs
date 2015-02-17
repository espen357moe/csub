using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    public class Torpedo
    {
        //lager skrivbar og lesbar variabel for torpedoens posisjon
        public PointF Position { get; set; }

        //metode for å tegne selve torpedoen
        public void Render(Graphics g)
        {
            g.FillEllipse(Brushes.Red, new RectangleF(-16, -16, 32, 32));
        }

        //metode for å flytte torpedoen ved bilderuteoppdatering
        public void FrameTick(float dt)
        {
            Position = new PointF(Position.X, (Position.Y - 50 * dt));
        }
    }
}
