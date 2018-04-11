using System;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomList<int> listName = new CustomList<int>();
            listName.Add(64);
            listName.Add(32);
            listName.Add(16);
            listName.Add(46);
            listName.Add(23);
            listName.Add(61);
            string newString = listName.ToString();
            Console.WriteLine(newString);
            Console.ReadLine();

        }
    }
}
