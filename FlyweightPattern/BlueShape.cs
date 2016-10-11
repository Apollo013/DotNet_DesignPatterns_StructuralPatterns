using System.Drawing;

namespace FlyweightPattern
{
    public class BlueShape : IShape
    {
        Brush paintBrush; // Intrinsic property

        public BlueShape()
        {
            paintBrush = Brushes.Blue;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
