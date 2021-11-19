using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class Circle: Point
    {
        private float radius;
        public Circle(Color color, State state, float[] coordinates, float radius)
        {
            PropertyColor = color;
            this.state = state;
            defining_components = coordinates;
            this.radius = radius;
        }
        public Circle(State state, float[] coordinates, float radius)
        {
            this.state = state;
            defining_components = coordinates;
            this.radius = radius;
        }
        public Circle(float[] coordinates, float radius)
        {
            defining_components = coordinates;
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override bool IsFigureContainsPoint(Point point)
        {
            float x = point.GetCoordinates()[0], y = point.GetCoordinates()[1];
            float distance_squared = (x - GetCoordinates()[0]) * (x - GetCoordinates()[0]) + (y - GetCoordinates()[1]) * (y - GetCoordinates()[1]);
            if (distance_squared <= radius * radius)
            {
                return true;
            }
            return false;
        }
    }
}
