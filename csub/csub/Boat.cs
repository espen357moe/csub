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

        public void foo(IRenderable i, Graphics g)
        {
            var transform = g.Transform;
            var mat = new Matrix(1, 0, 0, 1, 0, 0); // Identitetsmatrise

            int h2 = MainGameForm.Height / 3;
            var scale = i.Position.Y / h2;

            //Vi flytter koordinatsystemet til midten av skjermen istedet for øverst i høyre hjørne.
            mat.Translate((float)MainGameForm.Width / 2, ((float)MainGameForm.Height / 10) * 4);
            // Vi skalerer etter avstand fra horisonten
            mat.Scale(scale, scale);
            // Vi flytter igjen koordinatsystemet til der torpedoen befinner seg.
            mat.Translate(i.Position.X, i.Position.Y);

            g.Transform = mat;
            i.Render(g);
            g.Transform = transform;
        }

        public PointF Position { get; set; }
        public void Render(Graphics g)
        {
            g.DrawImage(Image, new Point(-Image.Width / 2, -Image.Height));
        }
    }

}
