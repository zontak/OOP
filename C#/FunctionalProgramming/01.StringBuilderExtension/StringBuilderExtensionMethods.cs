using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtension
{
    public static class StringBuilderExtensionMethods
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            if ((startIndex + length) > str.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid range");
            }
            string stringg = "";
            for (int i = startIndex; i <= length; i++)
            {
                stringg += str[i];
            }
            return stringg.ToString();
        }

        public static StringBuilder RemoveText(this StringBuilder stringg, string text)
        {
            return stringg.Replace(text, "");
        }

        public static StringBuilder AppendAll<T>(this StringBuilder stringg, IEnumerable<T> enumerable)
        {
            return stringg.Append(string.Join("", enumerable));
        }

    }
}
