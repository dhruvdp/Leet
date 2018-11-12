using System;
namespace myApp
{
    public class Array
    {
        static void Yo() {
            Console.WriteLine("Hola");
            int[] temp = {4, 50, 3, 240};
            int highest = 0;
            for (int i =1; i<= temp.Length; i++) {
                int curr = temp[i];
                int prev = temp[i - 1];
                if (curr > prev && curr > highest) {
                    highest = curr;
                } else if (prev > highest) {
                    highest = prev;
                }
                i++;
            }
            Console.WriteLine("The highest number is " + highest);
        }
    }
}