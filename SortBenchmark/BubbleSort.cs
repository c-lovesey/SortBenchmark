using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBenchmark
{
    [MemoryDiagnoser]
    public class BubbleSort
    {
        [Benchmark]
        public void Sort()
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
                    int n = array1.Length;
                    for (int i = 0; i < n - 1; i++)
                        for (int j = 0; j < n - i - 1; j++)
                            if (array1[j] > array1[j + 1])
                            {
                                // swap temp and arr[i]
                                int temp = array1[j];
                                array1[j] = array1[j + 1];
                                array1[j + 1] = temp;
                            }
                }
                else
                {
                    int n = array2.Length;
                    for (int i = 0; i < n - 1; i++)
                        for (int j = 0; j < n - i - 1; j++)
                            if (array2[j] > array2[j + 1])
                            {
                                // swap temp and arr[i]
                                int temp = array2[j];
                                array2[j] = array2[j + 1];
                                array2[j + 1] = temp;
                            }

                }
            }
        }
    }
}