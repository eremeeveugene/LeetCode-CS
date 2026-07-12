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

namespace LeetCode.Algorithms.DistributeCandiesAmongChildren2;

/// <summary>
///     https://leetcode.com/problems/distribute-candies-among-children-ii/description/
/// </summary>
public interface IDistributeCandiesAmongChildren2
{
    /// <summary>
    ///     Counts the ways to distribute <paramref name="n" /> candies among 3 children so that no child gets more than
    ///     <paramref name="limit" /> candies.
    /// </summary>
    /// <param name="n">The total number of candies to distribute.</param>
    /// <param name="limit">The maximum number of candies a single child can receive.</param>
    /// <returns>The total number of ways to distribute the candies.</returns>
    long DistributeCandies(int n, int limit);
}