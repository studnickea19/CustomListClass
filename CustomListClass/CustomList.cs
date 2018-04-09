using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
    {
        //Member Variables
        private int listCount = 0;
        public int index;
        public string name;
        private T[] inputs;

        public CustomList()
        {
            inputs = new T[0];
        }


        //MEMBER METHODS
        public void Add(T input)
        {
            //inputs[] = input;
            //count++;                      //--> listCount = 1
            //input.index = count - 1;   //--> listIndex = 0 (1-1);
        }

        public void RemoveAt(int index)
        {
            //Remove element from array
        }

        public void ListToString()
        {
            //Print List as string
        }

        public void ListCount()
        {
            //get { return listCount; }
        }

        public T this[int index]
        {
            get { return inputs[index]; }
        }

        //IEnumerator<T> GetEnumerator()
        //{
        //    return (IEnumerator<T>)GetEnumerator();
        //}

        //public int CustomListEnum GetEnumerator()
        //{
        //    return new CustomListEnum();
        //}
    //NEED
    //Add
    //Remove
    //Iterable
    //ToString
    //Count
    //+ operator
    //- operator
    //Zip


    //BONUS
    //Sort
    //Easter Egg user story

    //Insert
    //RemoveAt
    //ToArray
    }
}

