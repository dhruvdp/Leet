using System;
using System.Collections;
using System.Collections.Generic;
namespace myApp
{
    public class CoinChange
    {
        static long makeChange(int[] array, int money) {
            return makeChange(array, money, 0, new Dictionary<string, long>());
        }

        static long makeChange(int[] array, int money, int index, Dictionary<string, long> hashtable) {
            if (money == 0) {
                return 1;
            }
            if (index >= array.Length) {
                return 0;
            }
            string key = money + "-" + index;
            if (hashtable.ContainsKey(key)) {
                return hashtable[key];
            }
            int amountWithMoney = 0;
            long ways = 0;
            while(amountWithMoney <= money) {
                int remainningAmount = money - amountWithMoney;
                Console.WriteLine(remainningAmount);
                ways = ways + makeChange(array, remainningAmount, index + 1, hashtable);
                amountWithMoney = amountWithMoney + array[index];
            }
            Console.WriteLine(key);
            hashtable.Add(key, index);
            return ways;
        }

        static void Main() {
            // int[] listOfCoins = {50, 25, 10, 5, 1};
            // int money = 75;
            int[] listOfCoins = {50, 25};
            int money = 75;
            long dhruv = makeChange(listOfCoins, money);
            Console.WriteLine("Hi Y'all");
            Console.WriteLine(dhruv);
        }
    }
}