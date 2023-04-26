using Lab7_Person_Interface_Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return (x.FullAge()).CompareTo(y.FullAge());
        }
    }

}
