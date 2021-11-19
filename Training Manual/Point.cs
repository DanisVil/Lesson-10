using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class Point: Figure
    {
        public Point(float[] coordinates)
        {
            defining_components = coordinates;
        }
        public Point(Color color, State state, float[] coordinates)
        {
            defining_components = coordinates;
            this.state = state;
            PropertyColor = color;
        }
        public Point()
        {
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual bool IsFigureContainsPoint(Point point)
        {
            if (point.GetCoordinates().Equals(defining_components))
            {
                return true;
            }
            return false;
        }
    }
}
