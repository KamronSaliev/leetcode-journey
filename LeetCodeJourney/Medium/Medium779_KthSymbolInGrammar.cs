namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/k-th-symbol-in-grammar/
    /// </summary>
    public class Medium779_KthSymbolInGrammar
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1)
            {
                return 0;
            }

            var parent = KthGrammar(n - 1, (k + 1) / 2);

            if (k % 2 == 0)
            {
                return parent == 1 ? 0 : 1;
            }

            return parent;
        }
    }
}