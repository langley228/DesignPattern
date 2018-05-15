using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.SortSample
{
    public interface IComparatorStrategy<T>
    {
        int Execute(T a, T b);
    }
}
