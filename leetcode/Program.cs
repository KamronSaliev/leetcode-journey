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
            var p = new Medium443_StringCompression();
            var result = p.Compress(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            
            Console.WriteLine($"result: {result}");
        }
    }
}