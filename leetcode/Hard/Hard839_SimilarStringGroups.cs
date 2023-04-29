namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/similar-string-groups/
    /// </summary>
    public class Hard839_SimilarStringGroups
    {
        public int NumSimilarGroups(string[] strs)
        {
            var visited = new bool[strs.Length];
            var res = 0;

            for (var i = 0; i < strs.Length; i++)
            {
                if (!visited[i])
                {
                    res++;
                    DFS(strs, visited, i);
                }
            }

            return res;
        }

        private void DFS(string[] strs, bool[] visited, int index)
        {
            visited[index] = true;
            var curr = strs[index];

            for (var i = 0; i < strs.Length; i++)
            {
                if (!visited[i] && isSimilar(curr, strs[i]))
                {
                    DFS(strs, visited, i);
                }
            }
        }


        private bool isSimilar(string s1, string s2)
        {
            var diff = 0;
            
            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    diff++;
                }
            }

            return diff == 2 || diff == 0;
        }
    }
}