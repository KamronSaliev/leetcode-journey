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
            var p = new Medium8_StringToInteger();
            var result = p.MyAtoi("words and 987");
            
            Console.WriteLine($"result: {result}");
        }
    }
}