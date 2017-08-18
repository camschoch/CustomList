﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T> : IEnumerable
    { 
        public int Count;
        private T[] list;
        public string testTwo;

        public CustomListClass()
        {
            list = new T[Count];
        }

        //ITERATOR//
        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
     
        public void Add(T item)
        {
            T[] tempList = new T[Count+1];

            for (int j = 0; j < Count; j++)
            {
                tempList[j] = list[j];
            }

            tempList[Count] = item;
            Count++;

            list = tempList;            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            T[] tempList = new T[Count];

            for(int j = 0; j < Count; j++)
            {
                if (list[j].Equals(item))
                {
                    for (int i = j; i < Count; i++)
                    {
                        if (i + 1 == Count)
                        {
                            j = i;
                            break;
                        }
                        tempList[i] = list[i + 1];
                    }
                }
                else
                {
                    tempList[j] = list[j];
                }
           }
            Count--;
            list = tempList;
        }

        public override string ToString()
        {   
            for (int i = 0; i < Count; i++)
            {
                testTwo += list[i].ToString();
            }
            return testTwo;
        }

        public static CustomListClass<T> operator + (CustomListClass<T> b, CustomListClass<T> c)
        {
            CustomListClass<T> combinedList = new CustomListClass<T>();
            combinedList = b;
            combinedList.Count = b.Count + c.Count;
            for (int i = 0; i < c.Count; i++)
            {
                
                combinedList[i + b.Count] = c[i];

            }

            return combinedList;
        }


        public void Zip(T test)
        {

        }

    }
}
