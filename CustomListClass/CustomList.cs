using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace CustomListClass
{
    public class CustomList<T> 
    {
        //Member Variables
        private int listCount = 0;
        public int index = -1;
        public string name;
        private T[] inputs;
        int capacity = 5;

        public CustomList()
        {
            inputs = new T[5];

        }

        //counting

        //MEMBER METHODS
        public void Add(T input)
        {
            if (capacity <=5)
            {
                listCount++;
                index++;
                inputs[index] = input;  
            }
            else
            {
                Resize(ref inputs);
                Add(input);

            }
            Console.WriteLine(inputs);
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

        public void ListToString()
        {
            for (int i = 0; i <= listCount; i++)
            {
                Console.WriteLine(inputs[i]);
            }
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
            
        public T this[int index]
        {
            get { return inputs[index]; }
            set { inputs[index] = value; }
        }


        public void Resize(ref T[] inputs)
        {
            T[] temp;
            T[] inputs2 = new T[capacity * 2];
            temp = inputs;
            inputs = inputs2;
            inputs2 = temp;
        }

        //DONE
        //Add
        //Iterable
        //ToString
        //Count

        //NEED
        //Remove
        //+ operator
        //- operator
        //Zip


        //BONUS
        //Sort
        //Easter Egg user story
    }
}

