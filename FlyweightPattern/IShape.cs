using System.Drawing;

namespace FlyweightPattern
{
    public interface IShape
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}
