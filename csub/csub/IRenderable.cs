using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    public interface IRenderable
    {
        PointF Position { get; set; }
        void Render(Graphics g);
    }
}
