using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBenchmark
{
    [MemoryDiagnoser]
    public class BucketSort
    {
        [Benchmark]
        public void bucketSort()
        {
            int[] array1 = new int[100];
            int[] array2 = new int[10000];

            Random randNum = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randNum.Next(1, 10000);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = randNum.Next(1, 10000);
            }
            for (int ii = 0; ii < 2; ii++)
            {
                if (ii == 0)
                {
                    int minValue = array1.Min();
                    int maxValue = array1.Max();
                    int bucketCount = 10;
                    int bucketSize = (maxValue - minValue) / bucketCount + 1; // +1 to handle the case where max and min values are same




                    // Create an array of buckets
                    List<int>[] buckets = new List<int>[bucketCount];
                    for (int i = 0; i < bucketCount; i++)
                    {
                        buckets[i] = new List<int>();
                    }

                    // Distribute the elements of the array into the buckets
                    for (int i = 0; i < array1.Length; i++)
                    {
                        int bucketIndex = (array1[i] - minValue) / bucketSize;
                        buckets[bucketIndex].Add(array1[i]);
                    }

                    // Sort the elements within each bucket
                    for (int i = 0; i < bucketCount; i++)
                    {
                        buckets[i].Sort();
                    }

                    // Concatenate the sorted buckets to create the final sorted array
                    int index = 0;
                    for (int i = 0; i < bucketCount; i++)
                    {
                        for (int j = 0; j < buckets[i].Count; j++)
                        {
                            array1[index++] = buckets[i][j];
                        }
                    }
                }
                else
                {
                    int minValue = array2.Min();
                    int maxValue = array2.Max();
                    int bucketCount = 10;
                    int bucketSize = (maxValue - minValue) / bucketCount + 1; // +1 to handle the case where max and min values are same




                    // Create an array of buckets
                    List<int>[] buckets = new List<int>[bucketCount];
                    for (int i = 0; i < bucketCount; i++)
                    {
                        buckets[i] = new List<int>();
                    }

                    // Distribute the elements of the array into the buckets
                    for (int i = 0; i < array2.Length; i++)
                    {
                        int bucketIndex = (array2[i] - minValue) / bucketSize;
                        buckets[bucketIndex].Add(array1[i]);
                    }

                    // Sort the elements within each bucket
                    for (int i = 0; i < bucketCount; i++)
                    {
                        buckets[i].Sort();
                    }

                    // Concatenate the sorted buckets to create the final sorted array
                    int index = 0;
                    for (int i = 0; i < bucketCount; i++)
                    {
                        for (int j = 0; j < buckets[i].Count; j++)
                        {
                            array2[index++] = buckets[i][j];
                        }
                    }
                }
            }
        }
    }
}
