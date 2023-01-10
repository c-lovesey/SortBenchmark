namespace SortBenchmark
{
    internal class Program
    {
        static void Main(string[] args)
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
            //Selection Sort
            int[] selectionSortArray100 = (int[])array1.Clone();
            SelectionSort(selectionSortArray100);
            int[] selectionSortArray10000 = (int[])array2.Clone();
            SelectionSort(selectionSortArray10000);
            //Bubble Sort
            int[] BubbleSortArray100 = (int[])array1.Clone();
            bubbleSort(BubbleSortArray100);
            int[] BubbleSortArray10000 = (int[])array2.Clone();
            bubbleSort(BubbleSortArray10000);
            //Quick Sort
            int[] QuickSortArray100 = (int[])array1.Clone();
            quickSort(QuickSortArray100, 0, QuickSortArray100.Length - 1);
            int[] QuickSortArray10000 = (int[])array2.Clone();
            quickSort(QuickSortArray10000, 0, QuickSortArray10000.Length - 1);

            //Insertion Sort
            int[] insertionSortArray100 = (int[])array1.Clone();
            insertionSort(insertionSortArray100);
            int[] insertionSortArray10000 = (int[])array1.Clone();
            insertionSort(insertionSortArray10000);

            //Bucket Sort
            bucketSort(array1);


            for (int i = 0; i < array1.Length; ++i)
                Console.Write(array1[i] + " ");


        }
        static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

            }
            return arr;
        }
        static int[] bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            return arr;
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /* This function takes last element as pivot, places
             the pivot element at its correct position in sorted
             array, and places all smaller (smaller than pivot)
             to left of pivot and all greater elements to right
             of pivot */
        static int partition(int[] arr, int low, int high)
        {

            // pivot
            int pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller
                // than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of
                    // smaller element
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        /* The main function that implements QuickSort
                    arr[] --> Array to be sorted,
                    low --> Starting index,
                    high --> Ending index
           */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }


        static void bucketSort(int[] arr)
        {
            int minValue = arr.Min();
            int maxValue = arr.Max();
            int bucketCount = 10;
            int bucketSize = (maxValue - minValue) / bucketCount + 1; // +1 to handle the case where max and min values are same

            // Create an array of buckets
            List<int>[] buckets = new List<int>[bucketCount];
            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
            }

            // Distribute the elements of the array into the buckets
            for (int i = 0; i < arr.Length; i++)
            {
                int bucketIndex = (arr[i] - minValue) / bucketSize;
                buckets[bucketIndex].Add(arr[i]);
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
                    arr[index++] = buckets[i][j];
                }
            }
        }
    }
}
        