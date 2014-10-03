using System;
using System.Linq;
using System.Reflection;

namespace GenericList
{
    [Attributes("2.11")]
    public class GenericList<T>
    {
        private const int CAPACITY = 16;

        private int elementsCount = 0;

        private int inputCapacity;


        public T[] Elements { get; private set; }

        public GenericList(int capacity = CAPACITY)
        {
            this.Elements = new T[capacity];

            this.inputCapacity = capacity;
        }

        public void Add(T element)
        {
            this.TryToMultiplyElementsCount();

            this.Elements[this.elementsCount] = element;

            this.elementsCount++;
        }

        public T Get(int index)
        {
            return this.Elements[index];
        }

        public void Remove(int index)
        {
            var list = this.Elements.ToList();

            list.RemoveAt(index);

            this.Elements = list.ToArray();

            this.elementsCount--;
        }

        public void InsertInPosition(int pos, T element)
        {
            this.TryToMultiplyElementsCount(pos);

            var newElements = new T[this.Elements.Length+1];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                var index = i < pos ? i : i + 1;

                newElements[index] = this.Elements[i];
            }

            newElements[pos] = element;

            this.Elements = newElements;

            this.elementsCount++;
        }

        public void Clear()
        {
            this.Elements = new T[this.Elements.Length];
        }

        public int FindAtIndex(T value)
        {
            for (var i = 0; i < this.Elements.Length; i++)
            {
                if (this.Elements[i].Equals(value))
                {
                    return i;
                }
            }

            throw new Exception("Element not found");
        }

        public bool Contains(T value)
        {
            return this.Elements.Contains(value);
        }

        public dynamic Max()
        {
            var maxElement = this.Elements.Max();
            return maxElement;
        }

        public dynamic Min()
        {
            var minEleent = this.Elements.Min();
            return minEleent;
        }

        public override string ToString()
        {
            String output = "";

            foreach (var el in this.Elements)
                output += el + "\n";

            return output;
        }

        private void TryToMultiplyElementsCount(int pos = 0)
        {
            if (pos >= this.Elements.Length - 1)
            {
                var newElements = new T[pos * 2];

                this.MultiplyElementsCount(newElements);
            }
            else if (this.elementsCount == this.Elements.Length - 1)
            {
                var newElements = new T[this.Elements.Length * 2];

                this.MultiplyElementsCount(newElements);
            }
        }

        private void MultiplyElementsCount(T[] newElements)
        {
            for (var i = 0; i < this.Elements.Length; i++)
            {
                newElements[i] = this.Elements[i];
            }

            this.Elements = newElements;
        }
}
}
