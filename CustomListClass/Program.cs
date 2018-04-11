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
            expected.Add(46);
            expected.Add(32);
            expected.Add(23);
            expected.Add(16);
            expected.Add(61);
            expected.Remove(32);
            //expected.Remove(61);
            string newString = expected.ToString();
            Console.WriteLine(newString);
            Console.ReadLine();

        }
    }
}
