using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    public abstract class Skiff : Boat
    {
        public override float Speed { get { return 1f; } }     
        public override bool Direction { get { return Direction.Left; }}
        public override float Distance { get { return 200f; } }
       
        private static readonly Image pirateImage = Image.FromFile("../../images/southpark.png");
       
        public static Image Image { return pirateImage; }
    }
}
