using System;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomList<int> expected = new CustomList<int>();
            expected.Add(64);
            expected.Add(32);
            //expected.Add(16);
            //expected.Add(46);
            //expected.Add(23);
            //expected.Add(61);
            string newExpected = expected.ListToString();
            Console.WriteLine(newExpected);
            Console.ReadLine();
        }
    }
}
