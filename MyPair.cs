using Lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class MyPair<T1, T2>
    {
        private T1 firstObj;
        private T2 secondObj;

        //public MyPair() { }
        public MyPair(T1 firstObject, T2 secondObject)
        {
            firstObj = firstObject;
            secondObj = secondObject;
        }

        public T1 FirstObj
        {
            get { return firstObj; }
            set { firstObj = value; }
        }

        public T2 SecondObj
        {
            get { return secondObj; }
            set { secondObj = value; }
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return firstObj;
                }
                else if (index == 1)
                {
                    return secondObj;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index == 0)
                {
                    firstObj = (T1?)value;
                }
                else if (index == 1)
                {
                    secondObj = (T2?)value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }


    }
}




