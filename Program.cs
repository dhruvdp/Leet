using System;
using System.Collections;
using System.Collections.Generic;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {
            int[] nums = new int[] {2,7,11,15,16};
            int target = 18;
            int [] yo = findPair(nums, target);
            Console.WriteLine(nums[yo[0]] + "," + nums[yo[1]]);
        }

        static int[] findPair(int[] list, int target) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < list.Length; i++) {
                int complement = target - list[i];
                if (map.ContainsKey(complement)) {
                    return new int[] { map[complement], i };
                }
                map.Add(list[i], i);
            }
            return new int[] {0,0};
        }
    }
}