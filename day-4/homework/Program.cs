using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Table");
            myDictionary.Add(2, "Pencil");
            myDictionary.Add(3, "Eraser");

            Console.WriteLine(myDictionary.LengthK);
            Console.WriteLine(myDictionary.LengthV);

            foreach (var dictKey in myDictionary.Keys)
            {
                Console.WriteLine(dictKey);
            }

            foreach (var dictValue in myDictionary.Values)
            {
                Console.WriteLine(dictValue);
            }
        }
    }
}
