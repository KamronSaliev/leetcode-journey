namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/flood-fill/
    /// </summary>
    public class Easy733_FloodFill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            var initialColor = image[sr][sc];

            if (initialColor == color)
            {
                return image;
            }

            DFS(image, sr, sc, initialColor, color);
            return image;
        }

        private void DFS(int[][] image, int sr, int sc, int initialColor, int color)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length ||
                image[sr][sc] == color || image[sr][sc] != initialColor)
            {
                return;
            }

            image[sr][sc] = color;
            DFS(image, sr - 1, sc, initialColor, color);
            DFS(image, sr + 1, sc, initialColor, color);
            DFS(image, sr, sc - 1, initialColor, color);
            DFS(image, sr, sc + 1, initialColor, color);
        }
    }
}