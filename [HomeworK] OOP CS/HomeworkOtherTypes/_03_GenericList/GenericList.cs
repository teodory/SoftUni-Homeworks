using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GenericList
{
    public class GenericList<T> where T : IComparable<T>
    {
        private T[] storage;
        private int nextIndex;
        private const int size = 16;
        private int capacity;

        public GenericList()
        {
            this.storage = new T[16];
            this.capacity = this.storage.Length;
        }

        public int Count
        {
            get { return this.nextIndex; }
        }

        public void Add(T element)
        {
            if (this.nextIndex >= this.capacity)
            {
                Extend();
            }
            this.storage[nextIndex] = element;
            nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException("Incorect index");
                }
                return this.storage[index];
            }
            set
            {
                if (index < 0 || index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException("Incorect index");
                }
                this.storage[index] = value;
            }

        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.nextIndex - 1)
            {
                throw new IndexOutOfRangeException("Incorect Index");
            }

            for (int i = index; i < this.nextIndex - 1; i++)
            {
                storage[i] = storage[i + 1];
            }
            storage[nextIndex - 1] = default(T);
            nextIndex--;
        }

        public void Insert(int index, T value)
        {
           if (index < 0 || index > this.nextIndex - 1)
            {
                throw new IndexOutOfRangeException("Incorect Index");
            }

            this.Add(this.storage[Count - 1]);

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.storage[i + 1] = this.storage[i];
            }

            this.storage[index] = value;
            
        }

        private void Extend()
        {
           T[] newList = new T[this.capacity + size];

           for (int i = 0; i < capacity; i++)
           {
               newList[i] = this.storage[i];
           }
           this.capacity += size;

           this.storage = newList;
        }

        private void Clear()
        {
            this.storage = new T[size];
            this.nextIndex = 0;
        }

        public int GetIndexByValue(T value)
        {
            int valueIndex = -1;

                for (int i = 0; i < this.Count; i++)
                {
                    if (this.storage[i].Equals(value))
                    {
                        return i;
                    }
                }            

            return valueIndex;
        }

        public bool IsEmpty()
        {
            return this.storage.Length == 0;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "";
            }

            var resultString = new StringBuilder("");

            for (int i = 0; i < this.Count - 1; i++)
            {
                resultString.Append(this.storage[i] + ", ");
            }

            resultString.Append(this.storage[this.Count - 1]);

            return resultString.ToString();
        }

        public T Max()
        {
            var max = this.storage[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (max.CompareTo(this.storage[i]) < 0)
                {
                    max = this.storage[i];
                }
            }

            return max;
        }

        public T Min()
        {
            var min = this.storage[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (min.CompareTo(this.storage[i]) > 0)
                {
                    min = this.storage[i];
                }
            }

            return min;
        }
    }
}
//o	adding an element 
//o	accessing element by index
//o	removing element by index
//o	inserting element at given position
//o	clearing the list
//o	finding element index by given value
//o	checking if the list contains a value
//o	printing the entire list (override ToString()). 
