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

namespace LeetCode.Algorithms.MaximumDifferenceBetweenIncreasingElements;

/// <summary>
///     https://leetcode.com/problems/maximum-difference-between-increasing-elements/description/
/// </summary>
public interface IMaximumDifferenceBetweenIncreasingElements
{
    /// <summary>
    ///     Finds the maximum difference nums[j] - nums[i] for indices i &lt; j in <paramref name="nums" /> such that
    ///     nums[i] &lt; nums[j].
    /// </summary>
    /// <param name="nums">The array of integers to search for an increasing pair with maximum difference.</param>
    /// <returns>The maximum difference between two increasing elements, or -1 if no such pair exists.</returns>
    int MaximumDifference(int[] nums);
}