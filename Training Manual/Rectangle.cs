using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class Rectangle: Point
    {
        private float baza, height;
        public Rectangle(Color color, State state, float[] coordinates, float baza, float height)
        {
            PropertyColor = color;
            this.state = state;
            defining_components = coordinates;
            this.baza = baza;
            this.height = height;
        }
        public Rectangle(State state, float[] coordinates, float baza, float height)
        {
            this.state = state;
            defining_components = coordinates;
            this.baza = baza;
            this.height = height;
        }
        public Rectangle(float[] coordinates, float baza, float height)
        {
            defining_components = coordinates;
            this.baza = baza;
            this.height = height;
        }
        public override double Area()
        {
            return baza * height;
        }
        public override bool IsFigureContainsPoint(Point point)
        {
            float x = point.GetCoordinates()[0], y = point.GetCoordinates()[1];
            if ((x - defining_components[0]) <= baza / 2 && (x - defining_components[0]) >= -baza / 2 
                && (y - defining_components[1]) <= height / 2 && (y - defining_components[1]) >= -height / 2)
            {
                return true;
            }
            return false;
        }
    }
}
