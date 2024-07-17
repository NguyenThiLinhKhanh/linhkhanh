using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] array = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Mảng :");
            PrintArray(array);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Mảng khi sắp xếp :");
            PrintArray(array);
        }
        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                // Đệ quy sắp xếp các nửa
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }
        static int Partition(int[] array, int low, int high)
        {
            // Chọn phần tử cuối làm pivot
            int pivot = array[high];
            int i = (low - 1); // Chỉ số phần tử nhỏ hơn

            for (int j = low; j < high; j++)
            {
                // Nếu phần tử hiện tại nhỏ hơn hoặc bằng pivot
                if (array[j] <= pivot)
                {
                    i++;

                    // Đổi chỗ array[i] và array[j]
                    Swap(array, i, j);
                }
            }

            // Đổi chỗ pivot với phần tử tiếp theo của phần tử nhỏ hơn
            Swap(array, i + 1, high);

            return i + 1;
        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
