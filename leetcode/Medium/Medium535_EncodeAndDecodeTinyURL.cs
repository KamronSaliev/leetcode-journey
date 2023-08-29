using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/encode-and-decode-tinyurl/
    /// </summary>
    public class Medium535_EncodeAndDecodeTinyURL
    {
        public class Codec
        {
            private readonly Dictionary<int, string> _map = new();

            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                var hashCode = longUrl.GetHashCode();
                _map.Add(hashCode, longUrl);
                return $"http://tinyurl.com/{hashCode}";
            }

            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                var urlContent = shortUrl.Split('/');
                var hashCode = int.Parse(urlContent[^1]);
                return _map[hashCode];
            }
        }
    }
}