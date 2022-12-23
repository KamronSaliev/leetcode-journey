using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Easy;
using Leetcode.Medium;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = 1; // by default
            // t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                Solve();
            }
        }
        
        private static void Solve()
        {
            var n = int.Parse(Console.ReadLine()!);
 
            var ans = 0;
            var sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                var nums = Array.ConvertAll(Console.ReadLine()!.Trim().Split(' '), Convert.ToInt32);
 
                sum = 0;
                
                for (int j = 0; j < nums.Length; j++)
                {
                    sum += nums[j];
                }
 
                if (sum >= 2)
                {
                    ans++;
                }
            }
 
            Console.WriteLine(ans);
        }
    }
}