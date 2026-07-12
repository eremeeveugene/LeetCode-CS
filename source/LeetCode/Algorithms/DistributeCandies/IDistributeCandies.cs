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

namespace LeetCode.Algorithms.DistributeCandies;

/// <summary>
///     https://leetcode.com/problems/distribute-candies/description/
/// </summary>
public interface IDistributeCandies
{
    /// <summary>
    ///     Computes the maximum number of different candy types Alice can eat while eating only half of the candies.
    /// </summary>
    /// <param name="candyTypes">The array where each element is the type of a candy.</param>
    /// <returns>The maximum number of different candy types Alice can eat when eating half of the candies.</returns>
    int DistributeCandies(int[] candyTypes);
}