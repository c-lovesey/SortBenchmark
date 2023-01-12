using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBenchmark
{
    [MemoryDiagnoser]
    public class InsertionSort
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
                    for (int i = 1; i < n; ++i)
                    {
                        int key = array1[i];
                        int j = i - 1;
                        while (j >= 0 && array1[j] > key)
                        {
                            array1[j + 1] = array1[j];
                            j = j - 1;
                        }
                        array1[j + 1] = key;

                    }
                }
                else
                {
                    int n = array2.Length;
                    for (int i = 1; i < n; ++i)
                    {
                        int key = array2[i];
                        int j = i - 1;
                        while (j >= 0 && array2[j] > key)
                        {
                            array2[j + 1] = array2[j];
                            j = j - 1;
                        }
                        array2[j + 1] = key;

                    }
                }
            }
        }
    }
}