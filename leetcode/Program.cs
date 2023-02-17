using System;
using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = 1; // by default
            // t = int.Parse(Console.ReadLine()!);
            
            for (var i = 0; i < t; i++)
            {
                Solve();
            }
        }
        
        private static void Solve()
        {
            var p = new Easy989_AddToArrayFormOfInteger();
            var ans = p.AddToArrayForm(new[] { 1, 2, 3 }, 35);
            
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}