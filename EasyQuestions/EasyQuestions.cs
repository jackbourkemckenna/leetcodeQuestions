using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace LeetCodeQuestions
{
    public class EasyQuestions: IEasyQuestions
    {
        /*
         Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.

         Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.
         */
        public string Multiply(string num1, string num2)
        {
            BigInteger result = BigInteger.Parse(num1) * BigInteger.Parse(num2);
            return result.ToString();
        }




        /*
         * 
         * 
          Find Smallest Letter Greater Than Target
         Given a characters array letters that is sorted in non-decreasing order and a character target, return the smallest character in the array that is larger than target.

            Note that the letters wrap around.

            For example, if target == 'z' and letters == ['a', 'b'], the answer is 'a'.


       add target to array

        then sort array 

        find target int array and get plus one postion




         * 
         */


        public char NextGreatestLetter(char[] letters, char target)
        {
            char? smallestLetter = letters.FirstOrDefault(l => l > target);
            return smallestLetter != default(char) ? (char)smallestLetter
                                                   : letters[0];
        }


        /*
        You are given an array prices where prices[i] is the price of a given stock on the ith day.

        You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

         * 
         */

        public int MaxProfit(int[] prices)
        {
            //sliding window implamentation

            var Lpointer = 0; //buy
            var Rpointer = 1; // sell 
            var maxProfit = 0; 

            // above you see Lpointer and Rpointer these are the postions where I want to start in the prices array so : index 0 and index 1
            

            while (Rpointer < prices.Length) {

                if (prices[Lpointer] < prices[Rpointer])
                {
                    var profit = prices[Rpointer] - prices[Lpointer];

                    maxProfit = Math.Max(maxProfit, profit);
                }
                else {

                    Lpointer = Rpointer;
                   
                }
                Rpointer = 1 + Rpointer;
            }
            return maxProfit; 
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int Value = target - nums[i];
                if (dict.ContainsKey(Value))
                    if (i != dict[Value])
                    {
                        {
                            arr[0] = dict[Value];
                            arr[1] = i;
                            return arr;
                        }
                    }
                dict.Add(nums[i],i);
             //dict[nums[i]] = i;
            }
            return arr;
        }



    }
}
