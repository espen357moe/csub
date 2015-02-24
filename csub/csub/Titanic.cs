using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    //klasse for ferje, arver fra den abstrakte klassen Boat og interfacet IRenderable
    public class Titanic : Boat

    {       
        public override float Speed { get; set; }
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; } }
        private readonly Image titanicImage = Image.FromFile("../../images/titanic.png");
        public override int Value { get { return 1; } }      


        public override Image Image
        {
            get { return titanicImage; }
        }

        public new void Render(Graphics g)
        {
            g.DrawImage(titanicImage, 0, Position.Y);
        }
    }
}