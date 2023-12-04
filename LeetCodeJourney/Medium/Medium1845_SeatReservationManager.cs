using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/seat-reservation-manager/
    /// </summary>
    public class Medium1845_SeatReservationManager
    {
        /**
         * Your SeatManager object will be instantiated and called as such:
         * SeatManager obj = new SeatManager(n);
         * int param_1 = obj.Reserve();
         * obj.Unreserve(seatNumber);
         */
        public class SeatManager
        {
            private readonly PriorityQueue<int, int> _seats;

            public SeatManager(int n)
            {
                _seats = new PriorityQueue<int, int>();

                for (var i = 1; i <= n; i++)
                {
                    _seats.Enqueue(i, i);
                }
            }

            public int Reserve()
            {
                return _seats.Dequeue();
            }

            public void Unreserve(int seatNumber)
            {
                _seats.Enqueue(seatNumber, seatNumber);
            }
        }
    }
}