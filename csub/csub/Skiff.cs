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
    {
        public override float Speed { get { return 1f; } }     
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; }}
        public override float Distance { get { return 200f; } }
       
        private readonly Image pirateImage = Image.FromFile("../../images/southpark.png");

        public override Image Image
        {
            get { return pirateImage; }
        }
        
        public void Render(Graphics g)
        {            
            g.DrawImage(pirateImage,100,100);
        }
   
        }
}
    
