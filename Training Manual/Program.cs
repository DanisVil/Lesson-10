using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class Program
    {
        static void Main(string[] args)
        {
            BCipher aewsg = new BCipher();
            Console.WriteLine(aewsg.Decode(aewsg.Encode("АБВГДЕЖЗИКЛМНКОПРСТУФКЦЧШЩЪЫЬЭЮЯ", 5), 6));

            Circle circle = new Circle(new float[2] { 1, 2 }, 5);
            Console.WriteLine(circle.IsFigureContainsPoint(new Point(new float[2]{ -4.001f, 2 })));
            Rectangle rect = new Rectangle(new float[2] { 4, -2 }, 7, 4);
            Console.WriteLine(rect.IsFigureContainsPoint(new Point(new float[2] { -0.5001f, 0 })));
            Console.ReadKey();
        }
    }
}
