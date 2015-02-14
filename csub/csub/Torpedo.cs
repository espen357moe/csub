using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csub
{
    class Torpedo
    {
        public Torpedo()
        {
            float speed;
        }

        public void drawTorpedo(Graphics g, Size clientSize)
        {
            SolidBrush torpedoBrush = new SolidBrush(Color.Red);
            g.FillEllipse(torpedoBrush, ((clientSize.Width-43)/2), (clientSize.Height-20), 50, 50);
        }

    }
}
