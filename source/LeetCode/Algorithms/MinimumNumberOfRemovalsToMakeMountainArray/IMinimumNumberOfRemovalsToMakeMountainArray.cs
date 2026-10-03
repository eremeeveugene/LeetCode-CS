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

namespace LeetCode.Algorithms.MinimumNumberOfRemovalsToMakeMountainArray;

/// <summary>
///     https://leetcode.com/problems/minimum-number-of-removals-to-make-mountain-array/description/
/// </summary>
public interface IMinimumNumberOfRemovalsToMakeMountainArray
{
    /// <summary>
    ///     Finds the minimum removals needed to leave a strictly increasing then strictly decreasing mountain array.
    /// </summary>
    /// <param name="nums">The positive integers from which a valid mountain can be formed.</param>
    /// <returns>The minimum number of elements to remove.</returns>
    int MinimumMountainRemovals(int[] nums);
}