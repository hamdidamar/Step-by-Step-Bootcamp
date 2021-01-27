using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("name1");
            Console.WriteLine(names.Length);

            names.Add("name2");
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

        }
    }
}
