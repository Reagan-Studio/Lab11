using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class MyTriple<T1, T2, T3> : MyPair<T1, T2>
    {
        private T3 thirdObj;

        //public MyTriple() { }
        public MyTriple(T1 firstObject, T2 secondObject, T3 thirdObject) : base(firstObject, secondObject)
        {
            thirdObj = thirdObject;
        }

        public T3 ThirdObj
        {
            get { return thirdObj; }
            set { thirdObj = value; }
        }


        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return FirstObj;
                else if (index == 1)
                    return SecondObj;
                else if (index == 2)
                    return ThirdObj;
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index == 0)
                    FirstObj = (T1)value;
                else if (index == 1)
                    SecondObj = (T2)value;
                else if (index == 2)
                    ThirdObj = (T3)value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

       
    }

}
