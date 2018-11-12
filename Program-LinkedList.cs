using System;
using System.Collections;
using System.Collections.Generic;
namespace dhruv
{
    class ProgramLinkedList
    {
        // static void Main() 
        // {
        //     // pratice();
        //     // fun(10);
        //     // var IsSubsequence = isSubSequence("DhruvIo", "DhruvIsSoftDev", 6, 14);
        //     // Console.WriteLine(IsSubsequence);
        //     // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        //     // var fibo = fibonacciSeriesByRecursion(12);
        //     // Console.WriteLine(fibo);
        //     // var fiboByDp = fibonacciSeriesByRecursion(4);
        //     // Console.WriteLine(fiboByDp);
        //     // int[] a = {1, 2, 3, 4};
        //     // int[] b = {4, 5, 6, 7, 8, 9};
        //     // int c = 4;
        //     // int d = 6;
        //     // UnionOfTwoArrays(a, b, c ,d);
        //     // 1 11 21 1211 111221 312211
        //     // var lAS = LookAndSay(5);
        //     // Console.WriteLine(lAS);
        //     // int[] SSA = {4, 3, 8, 1, 2, 5};
        //     // int[] result = SelectionSort(SSA);
        //     // foreach(int temp in result) {
        //     //     Console.WriteLine(temp);
        //     // }
        //     // int[] BSA = {4, 13, 28, 41, 62, 95};
        //     // Console.WriteLine(BinarySearch(BSA, 62));
        //     // Console.WriteLine(ReverseString("Iammaster"));
        //     PracticeHastTable();
        // }

        static void PracticeHastTable() {
            Hashtable ht = new Hashtable();
            ht.Add("aish", "1");
            ht.Add("dhruv", "2");
            Console.WriteLine(ht.ContainsKey("aish"));
            Console.WriteLine(ht.ContainsValue("2"));
        }

        static String ReverseString(string str) {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            string temp = array.ToString();
            return temp;
        }

        static Boolean BinarySearch(int[] array, int x) {
            int left = 0;
            int right = array.Length - 1;
            return BinarySearch(array, x, left, right);
        }

        static Boolean BinarySearch(int[] array, int x, int left, int right) {

            if (left > right) {
                return false;
            }

            int mid = left + ((right - left) / 2);
            Console.WriteLine(mid);

            if (x > array[mid]) {
                return BinarySearch(array, x, mid + 1, right);
            } else if (x < array[mid]) {
                return BinarySearch(array, x, left, mid - 1);
            } else if (x == array[mid]) {
                return true;
            }
            return false;
        }

        static int[] SelectionSort(int[] inputArray) {
            if (inputArray.Length == 0) {
                return null;
            }
            for (var i = 0; i < inputArray.Length - 1; i++) {
                var temp = i;
                for (var j = i + 1; j < inputArray.Length; j++) {
                    if (inputArray[j] < inputArray[temp]) {
                        temp = j;
                    }
                }
                var temp2 = inputArray[i];
                inputArray[i] = inputArray[temp];
                inputArray[temp] = temp2;
            }
            return inputArray;
        }

        static string LookAndSay(int n) {
            string ret = "11";
            if (n == 1) {
                return "1";
            }
            if (n == 2) {
                return "11";
            }
            for (int i = 3; i <= n; i++) {
                ret = ret + "$";
                int len = ret.Length;
                int count = 1;
                string temp = "";
                char[] ch = ret.ToCharArray();
                for (int j = 1; j < len; j++) {
                    if (ch[j] != ch[j-1]) {
                        temp = temp + count;
                        temp = temp + ch[j-1];
                        count = 1;
                    } else {
                        count = count + 1;
                    }
                }
                ret = temp;
            }
            return ret;
        }

        static void UnionOfTwoArrays(int[] A, int[] B, int ALength, int BLength) {
            int i = 0;
            int j = 0;

            while(i < ALength && j < BLength) {
                if (A[i] < B[j]) {
                    Console.WriteLine(" " + A[i] + " ");
                    i++;
                } else if (A[i] > B[j]) {
                    Console.WriteLine(" " + B[j] + " ");
                    j++;
                } else {
                    Console.WriteLine(" " + B[j] + " ");
                    j++;
                }
            }
            while(i < ALength) {
                Console.WriteLine(" " + A[i] + "");
            }
            while(j < BLength) {
                Console.WriteLine(" " + B[j] + " ");
                j++;
            }
        }

        static int fibonacciSeriesByRecursion(int number) {
            if (number <= 1) {
                return number;
            } else {
                return fibonacciSeriesByRecursion(number - 1) + fibonacciSeriesByRecursion(number - 2);
            }
        }

        static int fibonacciSeriesByDP(int number) {
            int[] temp = new int[number + 2];
            int i;
            temp[0] = 0;
            temp[1] = 1;

            for(i = 2; i <= number; i++) {
                temp[i]= temp[i-1] + temp[i-2];
            }

            return temp[number];
        }

        static bool isSubSequence(string smallString, string largeString, int smallStringLength, int largeStringLength) {
            if (smallStringLength == 0) {
                return true;
            }
            if (largeStringLength == 0) {
                return false;
            }
            if (smallString[smallStringLength - 1] == largeString[largeStringLength - 1]) {
                return isSubSequence(smallString, largeString, smallStringLength - 1, largeStringLength - 1);
            }
            return isSubSequence(smallString, largeString, smallStringLength, largeStringLength - 1);
        }

        static void pratice() {
            LinkedList<int> CarYear = new LinkedList<int>();
            CarYear.AddFirst(1);
            CarYear.AddLast(2);
            CarYear.AddFirst(3);
            LinkedListNode<int> oneNode = CarYear.Find(1);
            CarYear.AddAfter(oneNode, 5);
            CarYear.AddBefore(oneNode, 6);
            if (CarYear.Contains(6)) {
                foreach (var num in CarYear) {
                    Console.WriteLine(num);
                }
                Console.WriteLine(CarYear.First.Next.Value);
                Console.WriteLine(CarYear.Last.Value);
            }
        }

        static void fun(int test) {
            if (test > 1) {
                Console.WriteLine(test);
                test--;
                fun(test);
            }
        }

    }
}