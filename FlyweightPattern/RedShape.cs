using System.Drawing;

namespace FlyweightPattern
{
    public class RedShape : IShape
    {
        Brush paintBrush; // Intrinsic property

        public RedShape()
        {
            paintBrush = Brushes.Red;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
