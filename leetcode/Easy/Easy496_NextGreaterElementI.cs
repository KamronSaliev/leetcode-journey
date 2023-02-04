namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/next-greater-element-i/
    /// </summary>
    public class Easy496_NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var indices = new int[nums1.Length];

            for (var i = 0; i < nums1.Length; i++)
            {
                for (var j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        indices[i] = j;
                    }
                }
            }

            var result = new int[nums1.Length];

            for (var i = 0; i < indices.Length; i++)
            {
                var current = nums2[indices[i]];
                var nextGreaterElement = -1;
                
                for (var j = indices[i] + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > current)
                    {
                        nextGreaterElement = nums2[j];
                        break;
                    }
                }

                result[i] = nextGreaterElement;
            }

            return result;
        }
    }
}