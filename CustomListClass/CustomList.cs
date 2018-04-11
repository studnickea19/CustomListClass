using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace CustomListClass
{
    public class CustomList<T> : IEnumerable<T>
    {
        //Member Variables
        private int listCount;
        private T[] inputs;
        public int capacity;
        public T this[int index]
        {
            get { return inputs[index]; }
            set { inputs[index] = value; }
        }

        public CustomList()
        {
            listCount = 0;
            capacity = 5;
            inputs = new T[capacity];
        }


        //MEMBER METHODS
        public void Add(T input)
        {
            if (listCount < capacity/2)
            {
                inputs[listCount] = input;  
                listCount++;
            }
            else
            {
                Resize();
                Add(input);
            }
        }

        public void Remove(T input)
        {
            for (int i = 0; i <= listCount; i++)
            {
                T checkInput = inputs[i];
                if(checkInput.Equals(input) == true)
                {
                    inputs[i] = inputs[i+1];
                    listCount--;
                }
                else
                {
                    inputs[i] = inputs[i];
                }
            }
        }

        public override string ToString()
        {
            string listString = "";
            for (int i = 0; i < listCount; i++)
            {
                if(i < listCount)
                {
                    T value = inputs[i];
                    listString += value + ", ";  
                }
                else
                {
                    T value = inputs[i];
                    listString += value + " ";  
                }
            }
            return listString;
        }

        public int ListCount()
        { 
            return listCount;
        }

        public CustomList<T> ZipNewArray(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newInputs = new CustomList<T>();
            int newListCount = listOne.ListCount() + listTwo.ListCount();

            for (int x = 0; x <= newListCount; x++)
            {
                newInputs.Add(listOne[x]);
                newInputs.Add(listTwo[x]);
            }
            return newInputs;
        }

        public T[] Resize()
        {
            capacity *= 2;
            T[] inputs2 = new T[capacity];
            for (int x = 0; x < inputs.Length; x++)
            {
                inputs2[x] = inputs[x];
            }
            inputs = inputs2;
            return inputs;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int x = 0; x <= inputs.Length; x++)
            {
                yield return inputs[x];
            } 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //DONE
        //Add
        //Iterable
        //ToString
        //Count
        //Remove
        //Zip

        //NEED
        //+ operator
        //- operator



        //BONUS
        //Sort
        //Easter Egg user story
    }
}

