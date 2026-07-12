// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

namespace LeetCode.Algorithms.DesignFoodRatingSystem;

/// <inheritdoc />
public sealed class DesignFoodRatingSystemDictionaryWithPriorityQueue : IDesignFoodRatingSystem
{
    private readonly Dictionary<string, PriorityQueue<FoodRating, FoodRating>> _cuisineToFoodRatingsDictionary = [];
    private readonly Dictionary<string, string> _foodToCuisineDictionary = [];
    private readonly Dictionary<string, int> _foodToRatingDictionary = [];

    /// <summary>
    ///     Time complexity - O(n log n), where n is the total number of foods
    ///     Space complexity - O(n), where n is the total number of foods
    /// </summary>
    /// <param name="foods"></param>
    /// <param name="cuisines"></param>
    /// <param name="ratings"></param>
    public DesignFoodRatingSystemDictionaryWithPriorityQueue(string[] foods, string[] cuisines, int[] ratings)
    {
        var n = foods.Length;

        for (var i = 0; i < n; i++)
        {
            var food = foods[i];
            var cuisine = cuisines[i];
            var rating = ratings[i];

            _foodToCuisineDictionary[food] = cuisine;
            _foodToRatingDictionary[food] = rating;

            if (!_cuisineToFoodRatingsDictionary.TryGetValue(cuisine, out var queue))
            {
                queue = new PriorityQueue<FoodRating, FoodRating>();

                _cuisineToFoodRatingsDictionary[cuisine] = queue;
            }

            var foodRating = new FoodRating(food, rating);

            queue.Enqueue(foodRating, foodRating);
        }
    }

    /// <inheritdoc />
    /// <remarks>
    ///     Time complexity - O(log k), where k is the number of foods in the cuisine
    ///     Space complexity - O(n + m), where n is the initial number of foods and m is the number of rating changes
    /// </remarks>
    public void ChangeRating(string food, int newRating)
    {
        _foodToRatingDictionary[food] = newRating;

        var cuisine = _foodToCuisineDictionary[food];

        var foodRating = new FoodRating(food, newRating);

        _cuisineToFoodRatingsDictionary[cuisine].Enqueue(foodRating, foodRating);
    }

    /// <summary>
    ///     Time complexity - O(m log k), where m si the number of stale items dequeued and k is the number of foods in the
    ///     cuisine
    ///     Space complexity - O(1)
    /// </summary>
    /// <param name="cuisine"></param>
    /// <returns></returns>
    public string HighestRated(string cuisine)
    {
        var queue = _cuisineToFoodRatingsDictionary[cuisine];

        while (queue.Count > 0)
        {
            var foodRating = queue.Peek();

            var actualRating = _foodToRatingDictionary[foodRating.Food];

            if (foodRating.Rating == actualRating)
            {
                return foodRating.Food;
            }

            queue.Dequeue();
        }

        return string.Empty;
    }

    private readonly struct FoodRating : IComparable<FoodRating>
    {
        public string Food { get; }

        public int Rating { get; }

        public FoodRating(string food, int rating)
        {
            Food = food;
            Rating = rating;
        }

        public int CompareTo(FoodRating foodRating)
        {
            var ratingCompare = CompareToRating(foodRating.Rating);

            if (ratingCompare == 0)
            {
                return CompareToFood(foodRating.Food);
            }

            return ratingCompare;
        }

        private int CompareToRating(int rating)
        {
            return rating.CompareTo(Rating);
        }

        private int CompareToFood(string food)
        {
            return string.Compare(Food, food, StringComparison.OrdinalIgnoreCase);
        }
    }
}