using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Binary Search";
            var numbers = new[] { 0, 1, 2, 3, 4, 10, 40  };

            int target = 4; 

            int result = BinarySearch(numbers, target);

            if (result != -1)
            {
                Console.WriteLine("Number {target} found at index {result}.");
            }
            else
            {
                Console.WriteLine("Number {target} not found in the array.");
            }

            Console.ReadKey();
        }
        
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
       
    }
}
