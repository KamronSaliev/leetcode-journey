using System;
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
            var p = new Medium54_SpiralMatrix();

            Console.WriteLine(string.Join(' ',
                p.SpiralOrder(new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } })));
        }
    }
}