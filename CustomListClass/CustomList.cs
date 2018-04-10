using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace CustomListClass
{
    public class CustomList<T> 
    {
        //Member Variables
        private int listCount;
        private T[] inputs;
        int capacity;
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

        //counting

        //MEMBER METHODS
        public void Add(T input)
        {
            if (listCount < capacity)
            {
                inputs[listCount] = input;  
                listCount++;
            }
            else
            {
                Resize(inputs);
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

        public string ListToString()
        {
            string listString = "";
            for (int i = 0; i <= listCount; i++)
            {
                T value = inputs[i];
                listString += value + " ";
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

        public void Resize(T[] inputs)
        {
            capacity *= 2;
            T[] inputs2 = new T[capacity];
            //not transferring data
            inputs = inputs2;
        }

        //DONE
        //Add
        //Iterable
        //ToString
        //Count
        //Remove

        //NEED

        //+ operator
        //- operator
        //Zip


        //BONUS
        //Sort
        //Easter Egg user story
    }
}

