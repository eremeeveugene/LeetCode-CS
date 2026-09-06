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

namespace LeetCode.Algorithms.SmallestStableIndex2;

/// <summary>
///     https://leetcode.com/problems/smallest-stable-index-ii/description/
/// </summary>
public interface ISmallestStableIndex2
{
    /// <summary>
    ///     Finds the smallest index whose instability score does not exceed the threshold.
    /// </summary>
    /// <param name="nums">The array of non-negative integers.</param>
    /// <param name="k">The maximum allowed instability score.</param>
    /// <returns>
    ///     The smallest index i such that max(nums[0..i]) - min(nums[i..n - 1]) is at most k;
    ///     otherwise, -1 if no stable index exists.
    /// </returns>
    int FirstStableIndex(int[] nums, int k);
}