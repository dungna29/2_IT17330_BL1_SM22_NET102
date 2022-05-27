using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_1_CLASS_GENERIC
{
    internal class ArrayGeneric<A>
    {
        private A[] arr;

        public ArrayGeneric()
        {
            
        }

        public ArrayGeneric(int size)
        {
            arr = new A[size];
        }

        public A[] Arr
        {
            get => arr;
            set => arr = value;
        }

        public void addValueByIndex(int index,A Value)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }

            arr[index] = Value;
        }

        public A getValueByIndex(int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return arr[index];
        }
    }
}
