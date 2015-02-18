using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    public abstract class Renderable
    {
        public PointF Position { get; set; }
        public abstract void Render(Graphics g);
    }
}
