using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_counting_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myTempArray = new int [] { 32, 144, 23, 1, 11 };

            int[] sortedArray = CountingSort(myTempArray);

            int[] sortedArray2 = RadixSortAux(myTempArray,1);

            Console.ReadLine();
        }
        public static int[] CountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];//array B

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {              
                counts[array[i] - minVal]++;
                Debug.WriteLine("satir 40 icounts i = " + counts[i]);
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
        }


        static int[] RadixSortAux(int[] array, int digit)
        {
            bool Empty = true;
            KVEntry[] digits = new KVEntry[array.Length];//array that holds the digits;
            int[] SortedArray = new int[array.Length];//Hold the sorted array
            for (int i = 0; i < array.Length; i++)
            {
                digits[i] = new KVEntry();
                digits[i].Key = i;
                digits[i].Value = (array[i] / digit) % 10;
                if (array[i] / digit != 0)
                    Empty = false;
            }

            if (Empty)
                return array;

            KVEntry[] SortedDigits = CountingSort(digits);
            for (int i = 0; i < SortedArray.Length; i++)
                SortedArray[i] = array[SortedDigits[i].Key];
            return RadixSortAux(SortedArray, digit * 10);
        }

        struct KVEntry
        {
            int key;
            int value;

            public int Key
            {
                get
                {
                    return key;
                }
                set
                {
                    if (key >= 0)
                        key = value;
                    else
                        throw new Exception("Invalid key value");
                }
            }

            public int Value
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                }
            }
        }

        static KVEntry[] CountingSort(KVEntry[] ArrayA)
        {
            int[] ArrayB = new int[MaxValue(ArrayA) + 1];
            KVEntry[] ArrayC = new KVEntry[ArrayA.Length];

            for (int i = 0; i < ArrayB.Length; i++)
                ArrayB[i] = 0;

            for (int i = 0; i < ArrayA.Length; i++)
                ArrayB[ArrayA[i].Value]++;

            for (int i = 1; i < ArrayB.Length; i++)
                ArrayB[i] += ArrayB[i - 1];

            for (int i = ArrayA.Length - 1; i >= 0; i--)
            {
                int value = ArrayA[i].Value;
                int index = ArrayB[value];
                ArrayB[value]--;
                ArrayC[index - 1] = new KVEntry();
                ArrayC[index - 1].Key = i;
                ArrayC[index - 1].Value = value;
            }
            return ArrayC;
        }

        static int MaxValue(KVEntry[] arr)
        {
            int Max = arr[0].Value;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].Value > Max)
                    Max = arr[i].Value;
            return Max;
        }
    }
}
