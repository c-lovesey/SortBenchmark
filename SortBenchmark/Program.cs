
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SortBenchmark
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            var result = BenchmarkRunner.Run<InsertionSort>();
            ////Selection Sort
            //int[] selectionSortArray100 = (int[])array1.Clone();
            //var result = BenchmarkRunner.Run<BucketSort>();
            //SelectionSort(selectionSortArray100);
            //int[] selectionSortArray10000 = (int[])array2.Clone();
            //SelectionSort(selectionSortArray10000);
            ////Bubble Sort
            //int[] BubbleSortArray100 = (int[])array1.Clone();
            //bubbleSort(BubbleSortArray100);
            //int[] BubbleSortArray10000 = (int[])array2.Clone();
            //bubbleSort(BubbleSortArray10000);
            ////Quick Sort
            //int[] QuickSortArray100 = (int[])array1.Clone();
            //quickSort(QuickSortArray100, 0, QuickSortArray100.Length - 1);
            //int[] QuickSortArray10000 = (int[])array2.Clone();
            //quickSort(QuickSortArray10000, 0, QuickSortArray10000.Length - 1);

            ////Insertion Sort
            //int[] insertionSortArray100 = (int[])array1.Clone();
            //insertionSort(insertionSortArray100);
            //int[] insertionSortArray10000 = (int[])array1.Clone();
            //insertionSort(insertionSortArray10000);

            ////Bucket Sort
            //bucketSort(array1);


            //for (int i = 0; i < array1.Length; ++i)
            //    Console.Write(array1[i] + " ");


        }
        

    }
}
        