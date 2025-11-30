
namespace QuestionsOnStrings
{
    public class Sorting_Algorithms
    {
        public static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort (int low, int high)
            {
                if(high <= low)                
                    return;

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1]) 
                    return;

                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);
                for(int k =low; k<= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
            }
            
        }

        public static void ShellSort(int[] array)
        {
            int Gap = 1;
            while (Gap < array.Length / 3)
            {
                Gap = 3 * Gap + 1;
            }
            while (Gap >= 1)
            {
                for (int i = Gap; i < array.Length; i++) // 1
                { 
                    for( int j = i; j>= Gap && array[j] < array[j-Gap]; j -= Gap)
                    {
                        Swap (array, j, j - Gap);
                    }
                }

                Gap /= 3;
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int currentUnsorted = array[partIndex];
                int i = 0;
                for(i=partIndex; i>0 && array[i-1] > currentUnsorted; i--)
                {
                    array[i] = array[i-1];
                }
                array[i] = currentUnsorted;
            }
        }

        public static void SelectionSort(int[] array)
        {
           
            for(int partIndex = array.Length-1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if(array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array,largestAt, partIndex);
            }
        }

        public static void BubbleSort(int[] array)
        {
            for(int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] >  array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }

        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp;

            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
