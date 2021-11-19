using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    abstract class Figure
    {
        public enum Color { R, G, B };
        public Color PropertyColor { get; set; }
        public enum State { Visible, Invisible };
        protected State state;
        protected float[] defining_components = new float[2];
        public Figure(Color color, State state, float[] coordinates)
        {
            PropertyColor = color;
            this.state = state;
            defining_components = coordinates;
        }
        public Figure(float[] coordinates)
        {
            defining_components = coordinates;
        }
        public Figure()
        {
            defining_components = new float[2] { 0, 0 };
        }
        public void Move(float x, float y)
        {
            defining_components[0] += x;
            defining_components[1] += y;
        }
        public State GetState
        {
            get
            {
                return state;
            }
        }
        public float[] GetCoordinates()
        {
            return defining_components;
        }
        public override string ToString()
        {
            return $"Color - {PropertyColor}, state - {state}, coordinates - {defining_components[0]}; {defining_components[1]}";
        }
    }
}
