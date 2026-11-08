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

namespace LeetCode.Algorithms.MinimumAbsoluteDifferenceBetweenTwoValues;

/// <summary>
///     https://leetcode.com/problems/minimum-absolute-difference-between-two-values/description/
/// </summary>
public interface IMinimumAbsoluteDifferenceBetweenTwoValues
{
    /// <summary>
    ///     Finds the minimum absolute difference between indices i and j such that nums[i] is 1 and nums[j] is 2.
    /// </summary>
    /// <param name="nums">The array consisting only of 0, 1 and 2.</param>
    /// <returns>The minimum absolute index difference among all valid pairs, or -1 if no valid pair exists.</returns>
    int MinAbsoluteDifference(int[] nums);
}