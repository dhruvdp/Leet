using System;
namespace myApp
{
    public class Sorting
    {

        static void quickSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            quickSort(array, left, right);
        }

        static void quickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = array[(right + left) / 2];
            int index = partition(array, left, right, pivot);
            quickSort(array, left, index -1);
            quickSort(array, index, right);
        }

        static int partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left <= right) {
                    array = swap(array, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }

        static int[] swap(int[] array, int left, int right) {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            return array;
        }
        
        static void DhruvMain()
        {
            int[] input = { 15, 3, 9, 8, 5, 2, 7, 1, 6, 56};
            Console.WriteLine("Hola");
            quickSort(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}