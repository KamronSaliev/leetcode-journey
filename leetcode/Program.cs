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
            var p = new Medium93_RestoreIPAddresses();

            Console.WriteLine(string.Join(' ', p.RestoreIpAddresses("25525511135")));
        }
    }
}