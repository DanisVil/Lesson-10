using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Person
    {
        private static ushort counter;
        public ushort id = counter;
        public Person()
        {
            counter++;
        }
    }
}
