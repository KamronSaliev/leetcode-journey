namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/image-smoother/
    /// </summary>
    public class Easy661_ImageSmoother
    {
        public int[][] ImageSmoother(int[][] img)
        {
            var m = img.Length;
            var n = img[0].Length;
            var result = new int[m][];

            for (var i = 0; i < m; i++)
            {
                result[i] = new int[n];
            }

            (int X, int Y)[] directions =
                { (-1, -1), (-1, 0), (-1, 1), (0, -1), (0, 0), (0, 1), (1, -1), (1, 0), (1, 1) };

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var sum = 0;
                    var count = 0;

                    foreach (var direction in directions)
                    {
                        var newX = i + direction.X;
                        var newY = j + direction.Y;

                        if (newX < 0 || newX >= m || newY < 0 || newY >= n)
                        {
                            continue;
                        }

                        sum += img[newX][newY];
                        count++;
                    }

                    result[i][j] = sum / count;
                }
            }

            return result;
        }
    }
}