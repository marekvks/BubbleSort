using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 5, 3, 4, 6, 7, 1};
            int storeNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if (nums[j] < nums[k])
                        {
                            storeNum = nums[j];    // store number in array "nums" at index "j"
                            nums[j] = nums[k];  // swap numbers
                            nums[k] = storeNum;    // swap numbers
                            break;
                        }
                    }
                }
            }

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
