using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp.Strategys.Oop.SortSample
{

    public static class SortExtensions
    {
        public static void BSort<T>(this T[] arr,
                                         IComparatorStrategy<T> test)
                                         where T : struct
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (test.Execute(arr[j], arr[j + 1]) > 0)
                    {
                        T tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
