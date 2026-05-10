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

namespace LeetCode.Algorithms.MaximumNumberOfJumpsToReachTheLastIndex;

/// <summary>
///     https://leetcode.com/problems/maximum-number-of-jumps-to-reach-the-last-index/description/
/// </summary>
public interface IMaximumNumberOfJumpsToReachTheLastIndex
{
    /// <summary>
    ///     Returns the maximum number of valid jumps needed to reach the last index.
    /// </summary>
    /// <param name="nums">The integer array to jump through.</param>
    /// <param name="target">The maximum allowed absolute difference between two jumped values.</param>
    /// <returns>The maximum number of jumps to reach the last index, or -1 if it cannot be reached.</returns>
    int MaximumJumps(int[] nums, int target);
}