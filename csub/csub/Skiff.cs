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
        public override float Speed { get; set; }     
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; }}       
        private readonly Image pirateImage = Image.FromFile("../../images/southpark.png");

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
    
