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
            for (int index = 0; index < Count; index++)
            {
                yield return list[index];
            }
        }

        public void Remove(T item)
        {
            CustomListClass<T> tempList = new CustomListClass<T>();
            int tempCount = Count;
            bool foundItem = false;
            for (int i = 0; i < tempCount; i++)
            {
                if (list[i].Equals(item) && foundItem == false)
                {
                    Count--;
                    foundItem = true;           
                }
                else
                {
                    tempList.Add(list[i]);
                }
            }
            T[] tempArr = new T[tempList.Count];
            for (int i = 0; i < tempList.Count; i++)
            {
                tempArr[i] = tempList[i];
            }
            list = tempArr;
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
            CustomListClass<T> combinedListPlus = new CustomListClass<T>();
            for (int i = 0; i < b.Count; i++)
            {
                combinedListPlus.Add(b[i]);
            }
            for (int i = 0; i < c.Count; i++)
            {                
                combinedListPlus.Add(c[i]);
            }
            return combinedListPlus;
        }

        public static CustomListClass<T> operator - (CustomListClass<T> b, CustomListClass<T> c)
        {
            CustomListClass<T> combinedListMinus = new CustomListClass<T>();
            combinedListMinus = b;
            foreach (T item in c)
            {
                combinedListMinus.Remove(item);
            }
            return combinedListMinus;
        }
            
        public CustomListClass<T> Zip(CustomListClass<T> listTwo)
        {
            CustomListClass<T> tempList = new CustomListClass<T>();
            if (Count == listTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    tempList.Add(list[i]);
                    tempList.Add(listTwo[i]);
                }
                return tempList;
            }

            else if (Count > listTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                   
                    tempList.Add(list[i]);
                    if (listTwo.Count > i)
                    {
                        tempList.Add(listTwo[i]);

                    }
                }
                return tempList;
            }

            else if (Count < listTwo.Count)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    if (Count > i)
                    {
                        tempList.Add(list[i]);
                    }
                    tempList.Add(listTwo[i]);
                    
                }
                return tempList;
            }
            return tempList;
        }
    }
}
