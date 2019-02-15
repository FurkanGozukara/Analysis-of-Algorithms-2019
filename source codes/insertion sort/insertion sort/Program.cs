using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstUnsorted = new List<int> { 32, 53, 11, 24, 67, 111, 66, 6, 5, 3 };
            int [] arUnsorted = new int [] { 32, 53, 11, 24, 67, 111, 66, 6, 5, 3 };

            int irStepCount = 0;

            //this doesnt sort seed list
            var vrSortedList1 = InsertionSort(lstUnsorted.ToArray(), out irStepCount);
            Console.WriteLine("seed: " + string.Join(",", lstUnsorted));

            //this doesnt sort seed list
            var vrSortedList3 = InsertionSort(arUnsorted.ToArray(), out irStepCount);
            Console.WriteLine("random sorted (avg) list sorting step count: "+ irStepCount);

            //this sort seed list
            var vrSortedList2 = InsertionSort(arUnsorted, out irStepCount);

            var vrSortedList4 = InsertionSort(arUnsorted, out irStepCount);
            Console.WriteLine("sorted list (best) sorting step count: " + irStepCount);

            var gg = vrSortedList1.Reverse();

            var vrSortedList5 = InsertionSort(gg.ToArray(), out irStepCount);
            Console.WriteLine("reverse sorted (worst) list sorting step count: " + irStepCount);

            Console.ReadKey();
        }

        static int[] InsertionSort(int[] inputArray, out int irHowManySteps)
        {
            irHowManySteps = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                irHowManySteps++;
                for (int j = i + 1; j > 0; j--)
                {
                    irHowManySteps++;
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        irHowManySteps = irHowManySteps + 3;
                    }
                }
            }
            return inputArray;
        }
    }
}
