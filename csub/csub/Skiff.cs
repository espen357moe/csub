using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    //klasse for piratbåt, arver fra den abstrakte klassen Boat og interfacet IRenderable
    public class Skiff : Boat
<<<<<<< HEAD
    {        
        public override float Speed { get; set; }     
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; }}       
        private readonly Image pirateImage = Image.FromFile("../../images/southpark.png");
        public override int Value { get { return 3; } }       
=======
    {
        public override int Value { get { return 3; } }
        public override float Speed { get; set; }     
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; }}       
        private readonly Image pirateImage = Image.FromFile("../../images/southpark.png");
>>>>>>> 47b8f0e8aa0374e9acf6b084540edb6fec6d4ab4

        public override Image Image
        {
            get { return pirateImage; }
        }

        public new void Render(Graphics g)
        {
            g.DrawImage(pirateImage, 0, Position.Y);
        }
    }
}
