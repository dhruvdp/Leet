using System;
using System.Collections;
using System.Collections.Generic;
namespace myApp
{
    public class IceCreamParlour
    {

        static int getIndex(List<int> array, int value, int excludethis) {
            for (int i = 0; i < array.Count; i++) {
                if (array[i] == value && i != excludethis) {
                    return i;
                }
            }
            return -1;
        }

        static int[] getIndices(List<int> array, int value1, int value2){
            int index1 = getIndex(array, value1, -1);
            int index2 = getIndex(array, value2, index1);
            int[] indices = {Math.Min(index1, index2), Math.Max(index1, index2)};
            return indices;
        }

        static int[] findChoices(List<int> array, int money) {
            var sortedArray = array;
            sortedArray.Sort();

            for (int i = 0; i < sortedArray.Count; i++) {
                int complement = money - sortedArray[i];
                int location = sortedArray.BinarySearch(complement);
                if (location > 0 && location < sortedArray.Count && sortedArray[location] == complement) {
                    return getIndices(array, sortedArray[i], complement);
                }
            }

            return null;   
        }
        static void Main1(){
            Console.WriteLine("Namaste");
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(1);
            list.Add(9);
            list.Add(13);
            list.Add(5);
            list.Add(4);
            list.Add(2);
            list.Add(8);
            list.Add(5);
            int money = 10;
            var answer = findChoices(list, money);
            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
            Console.WriteLine("One bug: The output is from sorted list instead of original list beacuse we didnt clone the sorted list.");
        }
    }
}