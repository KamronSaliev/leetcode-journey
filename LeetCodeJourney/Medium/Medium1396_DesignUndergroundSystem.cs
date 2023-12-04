using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-underground-system/
    /// </summary>
    public class Medium1396_DesignUndergroundSystem
    {
        /**
         * Your UndergroundSystem object will be instantiated and called as such:
         * UndergroundSystem obj = new UndergroundSystem();
         * obj.CheckIn(id,stationName,t);
         * obj.CheckOut(id,stationName,t);
         * double param_3 = obj.GetAverageTime(startStation,endStation);
         */
        public class UndergroundSystem
        {
            private readonly Dictionary<int, (string StartStation, int StartTime)> _currentTrips = new();

            private readonly Dictionary<(string StartStation, string EndStation), (int TripsNumber, double AverageTime)>
                _averageTimes = new();

            public void CheckIn(int id, string stationName, int t)
            {
                _currentTrips.Add(id, (stationName, t));
            }

            public void CheckOut(int id, string stationName, int t)
            {
                var (startStationName, startTime) = _currentTrips[id];

                if (!_averageTimes.ContainsKey((startStationName, stationName)))
                {
                    _averageTimes.Add((startStationName, stationName), (1, t - startTime));
                }
                else
                {
                    var (tripsNumber, averageTime) = _averageTimes[(startStationName, stationName)];
                    var totalTime = averageTime * tripsNumber + t - startTime;
                    tripsNumber += 1;
                    averageTime = totalTime / tripsNumber;
                    _averageTimes[(startStationName, stationName)] = (tripsNumber, averageTime);
                }

                _currentTrips.Remove(id);
            }

            public double GetAverageTime(string startStation, string endStation)
            {
                return _averageTimes[(startStation, endStation)].AverageTime;
            }
        }
    }
}