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

namespace LeetCode.Algorithms.CountHillsAndValleysInAnArray;

/// <summary>
///     https://leetcode.com/problems/count-hills-and-valleys-in-an-array/description/
/// </summary>
public interface ICountHillsAndValleysInAnArray
{
    /// <summary>
    ///     Counts the hills and valleys in <paramref name="nums" />, where a hill is an index whose closest non-equal
    ///     neighbors on both sides are smaller and a valley is an index whose closest non-equal neighbors on both sides are
    ///     larger.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The total number of hills and valleys in the array.</returns>
    int CountHillValley(int[] nums);
}