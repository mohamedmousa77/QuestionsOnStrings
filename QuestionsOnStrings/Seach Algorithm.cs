using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructure.Lib
{
    public class Seach_Algorithm
    {
        public static int BinarySearch(int[] array, int target)
        {
            int low = 0;
            int high = array.Length;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    low = mid + 1;
                else
                    high = mid;
            }

            return -1;
        }

        public static int RecursiveBinarySearch(int[] array, int value)
        {
           return InternalRecursiveBinarySearch(0, array.Length);
            int InternalRecursiveBinarySearch(int low, int high)
            {
                if (low >= high)
                    return -1;
                int mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                else if (array[mid] < value)
                    return InternalRecursiveBinarySearch(mid + 1, high);
                else
                    return InternalRecursiveBinarySearch(low, mid);
            }
        }
    } 
}

