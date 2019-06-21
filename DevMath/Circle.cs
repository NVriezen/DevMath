using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            float distance = Vector2.Distance(Position, circle.Position);// (float)Math.Sqrt(Math.Pow(circle.Position.x - Position.x, 2) + Math.Pow(circle.Position.y - Position.y, 2));
            return (distance - circle.Radius - Radius) <= 0 ? true : false;
        }
    }
}
