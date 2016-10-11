using System.Collections.Generic;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            // If shape does not already exist, it will be created. This will only happen the first time
            // Thereafter this shape will be return for all subsequent calls.
            switch (shapeType)
            {
                case "Red":
                    if (!shapes.ContainsKey("Red"))
                    {
                        shapes["Red"] = new RedShape();
                    }
                    return shapes["Red"];
                case "Blue":
                    if (!shapes.ContainsKey("Blue"))
                    {
                        shapes["Blue"] = new BlueShape();
                    }
                    return shapes["Blue"];
                default:
                    break;
            }
            return null;
        }
    }
}
