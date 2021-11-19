using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class ACipher: BCipher
    {
        public override string Encode(string str, ushort offset)
        {
            return base.Encode(str, 1);
        }
        public override string Decode(string str, ushort offset)
        {
            return base.Decode(str, 1);
        }
    }
}
