using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/restore-ip-addresses/
    /// </summary>
    public class Medium93_RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var ip = new List<string>();

            for (var i = 0; i <= 3; i++)
            {
                for (var j = 0; j <= 3; j++)
                {
                    for (var k = 0; k <= 3; k++)
                    {
                        for (var l = 0; l <= 3; l++)
                        {
                            if (i + j + k + l != s.Length)
                            {
                                continue;
                            }

                            var part1 = s.Substring(0, i);
                            var part2 = s.Substring(i, j);
                            var part3 = s.Substring(i + j, k);
                            var part4 = s.Substring(i + j + k, l);

                            if (IsPartValid(part1) && IsPartValid(part2) && IsPartValid(part3) && IsPartValid(part4))
                            {
                                ip.Add(part1 + "." + part2 + "." + part3 + "." + part4);
                            }
                        }
                    }
                }
            }

            return ip;
        }

        private bool IsPartValid(string part)
        {
            if (part == string.Empty || (part[0] == '0' && part.Length > 1))
            {
                return false;
            }

            var num = int.Parse(part);
            
            return num >= 0 && num <= 255;
        }
    }
}