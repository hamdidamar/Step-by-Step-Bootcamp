using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value type - Stack
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            Console.WriteLine(number1);


            // Reference Types - Stack and heap
            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);

          


        }
    }
}
