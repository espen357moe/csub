using System.Drawing;

namespace csub
{
    //abstrakt superklasse implementerer interfacet Renderable
    public abstract class Boat : IRenderable
    {
        public abstract float Speed { get; set; }
        public abstract MainGameForm.Direction Direction { get; }      
        public abstract Image Image { get; }
        public abstract int Value { get; }
      
        public void FrameTick(float dt)
        {
            Position = new PointF((Position.X + 50 * dt), Position.Y);          
        }

        public PointF Position { get; set; }

        public void Render(Graphics g)
        {
            g.DrawImage(Image, new Point(-Image.Width / 2, Image.Height));
        }

        public void Explode(Graphics g)
        {
            RectangleF boatRectangle = new RectangleF(Position.X, Position.Y, 400, 400);
            SolidBrush explosionBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
            g.FillEllipse(explosionBrush, boatRectangle);          
        }
    }
}
