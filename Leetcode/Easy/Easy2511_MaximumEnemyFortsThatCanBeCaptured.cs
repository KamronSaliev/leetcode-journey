using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-enemy-forts-that-can-be-captured/
    /// </summary>
    public class Easy2511_MaximumEnemyFortsThatCanBeCaptured
    {
        private List<int> _noFortPositions = new();

        private readonly List<int> _distances = new();

        public int CaptureForts(int[] forts)
        {
            _noFortPositions = GetNoFortPositions(forts);

            for (var i = 0; i < _noFortPositions.Count; i++)
            {
                var directionValue = 1;
                CheckDirection(forts, i, directionValue);

                directionValue = -1;
                CheckDirection(forts, i, directionValue);
            }

            _distances.Sort();

            return _distances.LastOrDefault();
        }

        private List<int> GetNoFortPositions(int[] forts)
        {
            var noFortPositions = new List<int>();

            for (var i = 0; i < forts.Length; i++)
            {
                if (forts[i] == -1)
                {
                    noFortPositions.Add(i);
                }
            }

            return noFortPositions;
        }

        private void CheckDirection(int[] forts, int i, int directionValue)
        {
            var index = _noFortPositions[i] + directionValue;
            var counter = 0;

            while (directionValue == 1 ? index < forts.Length : index >= 0)
            {
                if (forts[index] == 0)
                {
                    counter++;
                    index += directionValue;
                }
                else if (forts[index] == 1)
                {
                    _distances.Add(counter);
                    break;
                }
                else if (forts[index] == -1)
                {
                    break;
                }
            }
        }
    }
}