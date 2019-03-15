using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_bucket_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 0.37, 0.25, 0.86, 0.23, 0.09, 0.21, 0.17, 0.71 };
            double[] sortedArray = BucketSort(array);
        }

        public static double[] BucketSort(double[] array)
        {
            List<List<double>> buckets = new List<List<double>>();
            InitializeBuckets(buckets);

            Scatter(array, buckets);

            int i = 0;
            foreach (List<double> bucket in buckets)
            {
                double[] arr = bucket.ToArray();
                InsertionSort(arr);

                foreach (double d in arr)
                {
                    array[i++] = d;
                }
            }

            return array;
        }

        private static void Scatter(double[] array, List<List<double>> buckets)
        {
            foreach (double value in array)
            {
                int bucketNumber = GetBucketNumber(value);
                buckets[bucketNumber].Add(value);
            }
        }

        private static void InsertionSort(double[] array)
        {
            int j;
            double temp;

            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }

        private static int GetBucketNumber(double value)
        {
            double val = value * 10;
            int bucketNumber = (int)Math.Floor(val);
            return bucketNumber;
        }

        private static void InitializeBuckets(List<List<double>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                List<double> a = new List<double>();
                buckets.Add(a);
            }
        }

    }
}
