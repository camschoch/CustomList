using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomListClass<T>
    { 
        public int Count;
        private T[] list;
        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public void Add(T item)
        {
            list = new T[Count];
            T[] tempList = new T[Count+1];

            for (int j = 0; j < Count; j++)
            {
                tempList[j] = list[j];
            }

            tempList[Count] = item;
            Count++;

            list = tempList;

            
        }

        public void Remove(T item)
        {
            list = new T[Count];
            T[] tempList = new T[Count];

            for (int j = 0; j < Count; j++)
            {
                tempList[j] = list[j];
            }

            tempList[Count] = item;

            list = tempList;
        }

        public override string ToString()
        {
            T item;
            return base.ToString();
        }


    }
}
