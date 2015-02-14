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

        public void drawTorpedo()
        {
            Graphics g = new Graphics();
            SolidBrush torpedoBrush = new SolidBrush(Color.Red);

            g.DrawEllipse(torpedoBrush, 200, 200, 50, 50);
        }

    }
}
