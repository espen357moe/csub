using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    //klasse for piratbåt, arver fra de abstrakte klassene Boat og Renderable
    public class Skiff : Boat
    {
        public override float Speed { get { return 1f; } }     
        public override MainGameForm.Direction Direction { get { return MainGameForm.Direction.Left; }}
        public override float Distance { get { return 200f; } }
       
        private static readonly Image pirateImage = Image.FromFile("../../images/southpark.png");
       
        public static Image Image { return pirateImage};
        
        public override void Render(Graphics g)
        {
            throw new NotImplementedException();
        }
   
        }
}
    
