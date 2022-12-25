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
            var p = new Easy2511_MaximumEnemyFortsThatCanBeCaptured();

            var forts = new int[] { 1, 0, 0, -1, 0, 0, 0, 0, 1 };
            Console.WriteLine(p.CaptureForts(forts));
        }
    }
}