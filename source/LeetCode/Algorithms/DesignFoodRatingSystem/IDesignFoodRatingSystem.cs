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

/// <summary>
///     https://leetcode.com/problems/design-a-food-rating-system/description/
/// </summary>
public interface IDesignFoodRatingSystem
{
    /// <summary>
    ///     Changes the rating of the food item <paramref name="food" /> to <paramref name="newRating" />.
    /// </summary>
    /// <param name="food">The name of the food item.</param>
    /// <param name="newRating">The new rating of the food item.</param>
    void ChangeRating(string food, int newRating);

    /// <summary>
    ///     Returns the name of the highest-rated food item for <paramref name="cuisine" />, breaking ties by the
    ///     lexicographically smaller name.
    /// </summary>
    /// <param name="cuisine">The type of cuisine.</param>
    /// <returns>The name of the highest-rated food item for the given cuisine.</returns>
    string HighestRated(string cuisine);
}