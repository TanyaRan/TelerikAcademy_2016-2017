using System;
using System.Text;

namespace GenericListTasks
{
    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 10;
        private int position;
        private T[] list;

        public GenericList()
            :this(DefaultCapacity)
        {
        }

        public GenericList(int inputCapacity)
        {
            this.list = new T[inputCapacity];
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        public void AddElement(T element)
        {
            if (this.position >= this.list.Length)
            {
                // autogrow
                T[] newList = new T[this.list.Length * 2];
                for (int i = 0; i < this.list.Length; i++)
                {
                    newList[i] = this.list[i];
                }

                this.position++;
                newList[this.list.Length] = element;
                this.list = newList;
            }
            else
            {
                this.list[this.position] = element;
                this.position++;
            }
        }

        public void RemoveElemAtIndex(int index)
        {
            if (index < this.list.Length)
            {
                T[] newList = new T[this.list.Length - 1];
                bool beforeRem = true;

                for (int i = 0; i < this.list.Length - 1; i++)
                {
                    if (i == index)
                    {
                        beforeRem = false;
                    }

                    if (beforeRem)
                    {
                        newList[i] = this.list[i];
                    }
                    else
                    {
                        newList[i] = this.list[i + 1];
                    }
                }

                this.list = newList;
            }
            else
            {
                Console.WriteLine("Outside the array");
            }
        }

        public void InsertElemAtIndex(int index, T element)
        {
            if (index < this.list.Length)
            {
                T[] newList = new T[this.list.Length + 1];
                bool beforeRem = true;

                for (int i = 0; i < this.list.Length + 1; i++)
                {
                    if (i == index)
                    {
                        beforeRem = false;
                        newList[i] = element;
                        continue;
                    }

                    if (beforeRem)
                    {
                        newList[i] = this.list[i];
                    }
                    else
                    {
                        newList[i] = this.list[i - 1];
                    }
                }

                this.list = newList;
            }
            else
            {
                Console.WriteLine("Outside the array");
            }
        }

        public int Length()
        {
            return this.list.Length;
        }

        public void ClearList()
        {
            this.list = new T[1];
        }

        public int FindElemByValue(T value)
        {
            int indexFound = -1;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i].Equals(value))
                {
                    indexFound = i;
                    break;
                }
            }

            return indexFound;
        }

        public T Max()
        {
            var temp = list;
            Array.Sort(temp);
            return temp[temp.Length - 1];
        }

        public T Min()
        {
            var temp = list;
            Array.Sort(temp);
            return temp[0];
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in this.list)
            {
                result.AppendFormat("{0} ", item);
            }

            return result.ToString().Trim();
        }
    }
}
