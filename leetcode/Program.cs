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
            var p = new Easy2582_PassThePillow();
            
            for (var i = 1; i <= 20; i++)
            {
                Console.WriteLine(p.PassThePillow(5, i));
            }
        }
    }
}