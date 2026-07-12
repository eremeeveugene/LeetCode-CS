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

namespace LeetCode.Algorithms.MinimumDifferenceBetweenHighestAndLowestOfKScores;

/// <summary>
///     https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/description/
/// </summary>
public interface IMinimumDifferenceBetweenHighestAndLowestOfKScores
{
    /// <summary>
    ///     Selects exactly <paramref name="k" /> scores from <paramref name="nums" /> to minimize the difference
    ///     between the highest and lowest selected score.
    /// </summary>
    /// <param name="nums">The array of student scores.</param>
    /// <param name="k">The number of scores that must be selected.</param>
    /// <returns>The minimum possible difference between the highest and lowest of the selected scores.</returns>
    int MinimumDifference(int[] nums, int k);
}