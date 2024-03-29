﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable 
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }

        public T[] Items { get { return items; } set { items = value; } }

        //Constructor
        public CustomList()
        
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }
        
        
        public T this[int index]
        {

            get
            {
                if(index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
                
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
               else
                {
                    items[index] = value;
                }
                
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            if (Capacity == Count)
            {
                capacity = capacity * 2;
                T[] TempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    TempArray[i] = items[i];
                
                }
                items = TempArray;
            }
            items[count] = item;
            count++;
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            int X = Count;
            for (int i = 0; i < Items.Length; i++)
            {
                if (item.Equals(Items[i]))
                {
                    int index = i;
                    T[] temp = new T[Capacity];
                    for (int o = 0; o < index; o++)
                    {
                        temp[o] = Items[o];


                    }
                    for (int o = index + 1; o < Items.Length; o++)
                    {

                        temp[o - 1] = Items[o];

                    }

                    Items = temp;
                    count--;
                    break;
                }
            }
            if (X != Count)
            {

                return true;
            }

            else
            {
                return false;
            }
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
        }
        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public void Add(string[] items)
        {
            throw new NotImplementedException();
        }

        public void Add(object items)
        {
            throw new NotImplementedException();
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
