using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member Variables
        private int listCount = 0;
        public int index;
        public string name;
        private T[] inputs;

        public CustomList()
        {
            inputs = new T[5];

        }

        //counting

        //MEMBER METHODS
        public void Add(T input)
        {
            //inputs[] = input;
            //listCount++;                      //--> listCount = 1
            //input.index = count - 1;   //--> listIndex = 0 (1-1);

            //if index is less than /equal to capacity, add
            //else resize array & add
            //ArrayB capacity = array A capacity*2.
            //Send arrayA items to array B
            //ArrayB = ArrayA
        }

        public void Remove(T input)
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
            set { inputs[index] = value; }
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

