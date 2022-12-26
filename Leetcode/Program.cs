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
            var p = new Easy566_ReshapeTheMatrix();

            int[][] matrix = { new[]{ 1, 2 }, new[] { 3, 4 }, new[]{ 5, 6 }, new[]{ 7, 8 } };
            Console.WriteLine(p.MatrixReshape(matrix, 4, 2));
        }
    }
}