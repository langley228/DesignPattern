using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharp.Strategys.Oop.SortSample
{

    public class IntComparator : IComparatorStrategy<int>
    {
        public int Execute(int a, int b)
        {
            return a > b ? 1 : (b > a) ? -1 : 0;
        }
    }
}
