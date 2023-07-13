using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/course-schedule/
    /// </summary>
    public class Medium207_CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var adjacencyList = new List<List<int>>();
            var visited = new bool[numCourses];
            var recursionStack = new bool[numCourses];

            for (var i = 0; i < numCourses; i++)
            {
                adjacencyList.Add(new List<int>());
            }

            foreach (var prerequisite in prerequisites)
            {
                var course = prerequisite[0];
                var prerequisiteCourse = prerequisite[1];
                adjacencyList[course].Add(prerequisiteCourse);
            }

            for (var course = 0; course < numCourses; course++)
            {
                if (HasCycle(course, adjacencyList, visited, recursionStack))
                {
                    return false;
                }
            }

            return true;
        }

        private bool HasCycle(int course, List<List<int>> adjacencyList, bool[] visited, bool[] recursionStack)
        {
            visited[course] = true;
            recursionStack[course] = true;

            foreach (var prerequisiteCourse in adjacencyList[course])
            {
                if (recursionStack[prerequisiteCourse])
                {
                    return true;
                }

                if (!visited[prerequisiteCourse] &&
                    HasCycle(prerequisiteCourse, adjacencyList, visited, recursionStack))
                {
                    return true;
                }
            }

            recursionStack[course] = false;
            return false;
        }
    }
}