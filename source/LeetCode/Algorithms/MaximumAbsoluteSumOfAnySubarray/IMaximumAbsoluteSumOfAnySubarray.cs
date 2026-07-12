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

namespace LeetCode.Algorithms.MaximumAbsoluteSumOfAnySubarray;

/// <summary>
///     https://leetcode.com/problems/maximum-absolute-sum-of-any-subarray/description/
/// </summary>
public interface IMaximumAbsoluteSumOfAnySubarray
{
    /// <summary>
    ///     Finds the maximum absolute value of the sum of any (possibly empty) subarray of <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers to search for a subarray with maximum absolute sum.</param>
    /// <returns>The maximum absolute sum achievable by any subarray of <paramref name="nums" />.</returns>
    int MaxAbsoluteSum(int[] nums);
}