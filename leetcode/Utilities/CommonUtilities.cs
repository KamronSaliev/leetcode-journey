namespace Leetcode.Utilities
{
    public static class CommonUtilities
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var temp = a % b;
                a = b;
                b = temp;
            }
 
            return a;
        }
    
        public static double PowOptimized(double x, long n)
        {
            return x switch
            {
                0 => 0,
                1 => 1,
                _ => n switch 
                {
                    0 => 1,
                    < 0 => 1 / PowOptimized(x, -n),
                    _ => n % 2 == 0 ? PowOptimized(x * x, n / 2) : x * PowOptimized(x, n - 1)
                }
            };
        }
        
        public static long GetBinomialCoefficientOptimized(int n, int k)
        {
            var val = 1;

            if (n - k < k)
            {
                k = n - k;
            }
            
            for (int i = 0; i < k; i++)
            {
                val *= n - i;
                val /= i + 1;
            }

            return val;
        }
    }
}