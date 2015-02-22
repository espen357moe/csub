using System;
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
        //public abstract float Distance { get; set; }
        public abstract Image Image { get; }

        int Distance
        {
            get
            {
                return (int)(Position.Y / 5); //ratioen (5) er vilkårlig valgt
            }
            set
            {
                Position = new PointF(Position.X, value * 5); //ratioen (5) er vilkårlig valgt
            }
        }

        

        public PointF Position { get; set; }
        public void Render(Graphics g)
        {

            g.DrawImage(Image, new Point(-Image.Width / 2, -Image.Height));
        }
    }

}
