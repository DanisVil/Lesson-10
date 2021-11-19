using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    interface ICipher
    {
        string Encode(string str, ushort offset);
        string Decode(string str, ushort offset);
    }
}
