using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{
    class BCipher: ICipher
    {
        public virtual string Encode(string str, ushort offset)
        {
            char[] new_str = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (64 < str[i] && str[i] < 91)
                {
                    int new_value = str[i] + offset;
                    if (new_value > 90)
                    {
                        new_value = (new_value % 90) + 64;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (96 < str[i] && str[i] < 123)
                {
                    int new_value = str[i] + offset;
                    if (new_value > 122)
                    {
                        new_value = (new_value % 122) + 96;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (1039 < str[i] && str[i] < 1072)
                {
                    int new_value = str[i] + offset;
                    if (new_value > 1071)
                    {
                        new_value = (new_value % 1071) + 1039;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (1071 < str[i] && str[i] < 1104)
                {
                    int new_value = str[i] + offset;
                    if (new_value > 1103)
                    {
                        new_value = (new_value % 1103) + 1071;
                    }
                    new_str[i] = (char)new_value;
                }
            }
            return new string(new_str);
        }
        public virtual string Decode(string str, ushort offset)
        {
            char[] new_str = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (64 < str[i] && str[i] < 91)
                {
                    int new_value = str[i] - (offset % 26);
                    if (new_value < 65)
                    {
                        new_value += 26;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (96 < str[i] && str[i] < 123)
                {
                    int new_value = str[i] - (offset % 26);
                    if (new_value < 97)
                    {
                        new_value += 26;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (1039 < str[i] && str[i] < 1072)
                {
                    int new_value = str[i] - (offset % 32);
                    if (new_value < 1040)
                    {
                        new_value += 32;
                    }
                    new_str[i] = (char)new_value;
                }
                else if (1071 < str[i] && str[i] < 1104)
                {
                    int new_value = str[i] - (offset % 32);
                    if (new_value < 1072)
                    {
                        new_value += 32;
                    }
                    new_str[i] = (char)new_value;
                }
            }
            return new string(new_str);
        }
    }
}
