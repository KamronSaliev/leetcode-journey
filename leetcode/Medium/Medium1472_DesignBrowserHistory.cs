using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-browser-history/
    /// </summary>
    public class Medium1472_DesignBrowserHistory
    {
        /**
         * Your BrowserHistory object will be instantiated and called as such:
         * BrowserHistory obj = new BrowserHistory(homepage);
         * obj.Visit(url);
         * string param_2 = obj.Back(steps);
         * string param_3 = obj.Forward(steps);
         */
        public class BrowserHistory
        {
            private readonly List<string> _urls;
            private int _currentPage;

            public BrowserHistory(string homepage)
            {
                _urls = new List<string> { homepage };
                _currentPage = 0;
            }

            public void Visit(string url)
            {
                if (_currentPage == _urls.Count - 1)
                {
                    _urls.Add(url);
                    _currentPage++;
                    return;
                }

                _urls.RemoveRange(_currentPage + 1, _urls.Count - 1 - _currentPage);
                _urls.Add(url);
                _currentPage++;
            }

            public string Back(int steps)
            {
                _currentPage -= steps;
                _currentPage = Math.Max(_currentPage, 0);
                return _urls[_currentPage];
            }

            public string Forward(int steps)
            {
                _currentPage += steps;
                _currentPage = Math.Min(_currentPage, _urls.Count - 1);
                return _urls[_currentPage];
            }
        }
    }
}