using System;
using System.Collections.Generic;
using System.Text;

namespace _01.StringBuilderExtension
{
    class StringBuilderExtension
    {
        static void Main(string[] args)
        {

            StringBuilder stringg = new StringBuilder();
            stringg.Append("This is example for text...");

            IEnumerable<int> nums = new List<int>() { 6, 3, 7, 8, 15, 1 };


            // 01.
            //Console.WriteLine(stringg.Substring(2,5));

            // 02.
            //Console.WriteLine(stringg.RemoveText("example for"));

            // 03.
            //Console.WriteLine(sb.AppendAll<int>(numbers));
        }
    }
}
