using System;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(64);
            listOne.Add(32);
            listOne.Add(16);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(46);
            listTwo.Add(23);
            listTwo.Add(61);
            CustomList<int> actual = new CustomList<int>();
            actual = listOne.ZipNewArray(listOne, listTwo);
            string newString = actual.ToString();
            Console.WriteLine(newString);
            Console.ReadLine();

        }
    }
}
