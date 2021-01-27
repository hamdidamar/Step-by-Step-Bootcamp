using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "name1", "name2" };
            names.Add("name3");
            names.Add("name4");
            Console.WriteLine(names[2]);
            names.Remove("name3");
            Console.WriteLine(names[2]);
        }
    }
}
