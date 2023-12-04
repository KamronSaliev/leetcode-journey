namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/find-in-mountain-array/
    /// </summary>
    public class Hard1095_FindInMountainArray
    {
        // This is MountainArray's API interface.
        // To be implemented on LeetCode platform
        public class MountainArray
        {
            public int Get(int index)
            {
                return 0;
            }

            public int Length()
            {
                return 0;
            }
        }

        public int FindInMountainArray(int target, MountainArray mountainArr)
        {
            var peakIndex = FindPeakIndex(mountainArr);
            var leftIndex = BinarySearch(mountainArr, target, 0, peakIndex, true);

            if (leftIndex != -1)
            {
                return leftIndex;
            }

            var rightIndex = BinarySearch(mountainArr, target, peakIndex + 1, mountainArr.Length() - 1, false);
            return rightIndex;
        }

        private int FindPeakIndex(MountainArray mountainArr)
        {
            var left = 0;
            var right = mountainArr.Length() - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }

        private int BinarySearch(MountainArray mountainArr, int target, int left, int right, bool ascending)
        {
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var midValue = mountainArr.Get(mid);

                if (midValue == target)
                {
                    return mid;
                }

                if (ascending)
                {
                    if (midValue < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (midValue > target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}