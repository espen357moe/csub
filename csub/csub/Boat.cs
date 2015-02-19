using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    //abstrakt superklasse for båter, arver fra klassen Renderable
    public abstract class Boat : IRenderable
    {
        public abstract float Speed { get; }
        public abstract MainGameForm.Direction Direction { get; }
        public abstract float Distance { get; }
        public abstract Image Image { get; }

        public PointF Position { get; set; }
        public void Render(Graphics g)
        {
            g.DrawImage(Image, new Point(-Image.Width / 2, -Image.Height));
        }
    }

}
