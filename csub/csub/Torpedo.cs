using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
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
            var xPosition = clientSize.Width;
            var yPosition = clientSize.Height;
            SolidBrush torpedoBrush = new SolidBrush(Color.Red);
            g.FillEllipse(torpedoBrush, ((xPosition/2)), (yPosition), 100, 100);
        }

    }
}
