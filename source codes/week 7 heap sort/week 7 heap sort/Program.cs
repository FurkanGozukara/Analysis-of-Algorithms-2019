using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_7_heap_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 64, 7, 52, 32, 18, 2, 48 };

            var tempArray = arr.ToArray();//this composes a new array thus original list is not sorted

            var temparray2 = arr;//this assign reference thus original list get sorted

            HeapSort hs = new HeapSort();

            hs.PerformHeapSort(tempArray);

         //   hs.PerformHeapSort(temparray2);//this sorts original array too

            Console.ReadLine();
        }
    }
}
