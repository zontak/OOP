using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var genericlist = new GenericList<String>(3);

            genericlist.Add("kur");
            genericlist.Add("kuramiqnko");
            genericlist.Add("asdasd");
            genericlist.Add("lqwlwqle");
            genericlist.Add("zsfsdsdg");
            genericlist.Add("sdsf");

            Console.WriteLine(((Attributes)Attribute.GetCustomAttribute(genericlist.GetType(),typeof(Attributes))).Version);
            
            Console.WriteLine(genericlist.Max());
            
        }
    }
}
