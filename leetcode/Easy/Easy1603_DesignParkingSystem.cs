namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/design-parking-system/
    /// </summary>
    public class Easy1603_DesignParkingSystem
    {
        /**
         * Your ParkingSystem object will be instantiated and called as such:
         * ParkingSystem obj = new ParkingSystem(big, medium, small);
         * bool param_1 = obj.AddCar(carType);
         */
        
        public class ParkingSystem
        {
            private int _currentBigSize;
            private int _currentMediumSize;
            private int _currentSmallSize;

            public ParkingSystem(int big, int medium, int small)
            {
                _currentBigSize = big;
                _currentMediumSize = medium;
                _currentSmallSize = small;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case 1:
                        return _currentBigSize-- > 0;
                    case 2:
                        return _currentMediumSize-- > 0;
                    case 3:
                        return _currentSmallSize-- > 0;
                }

                return false;
            }
        }
    }
}