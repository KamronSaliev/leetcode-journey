namespace LeetCode.Utilities
{
    public static class CommonUtilities
    {
        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
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