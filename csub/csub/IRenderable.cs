using System.Drawing;

namespace csub
{
    //interface for tegnbare objekter
    public interface IRenderable
    {
        PointF Position { get; set; }
        void Render(Graphics g);
    }
}
