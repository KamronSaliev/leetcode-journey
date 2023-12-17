using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/design-a-food-rating-system/
    /// </summary>
    public class Medium2353_DesignAFoodRatingSystem
    {
        public class FoodRatings
        {
            private readonly Dictionary<string, SortedSet<(int Rating, string Food)>> _map;
            private readonly Dictionary<string, string> _foodCuisines;
            private readonly Dictionary<string, int> _foodRatings;

            public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
            {
                _map = new Dictionary<string, SortedSet<(int Rating, string Food)>>();
                _foodCuisines = new Dictionary<string, string>();
                _foodRatings = new Dictionary<string, int>();

                for (var i = 0; i < foods.Length; i++)
                {
                    var food = foods[i];
                    var rating = ratings[i];
                    var cuisine = cuisines[i];

                    if (!_map.ContainsKey(cuisine))
                    {
                        _map.Add(cuisine, new SortedSet<(int Rating, string Food)>());
                    }

                    _map[cuisine].Add((-rating, food));
                    _foodCuisines.Add(food, cuisine);
                    _foodRatings.Add(food, rating);
                }
            }

            public void ChangeRating(string food, int newRating)
            {
                var cuisine = _foodCuisines[food];
                var obj = _map[cuisine];
                var rating = _foodRatings[food];
                _foodRatings[food] = newRating;
                obj.Remove((-rating, food));
                obj.Add((-newRating, food));
            }

            public string HighestRated(string cuisine)
            {
                return _map[cuisine].Min.Food;
            }
        }
    }
}