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

namespace LeetCode.Algorithms.ContinuousSubarraySum;

/// <summary>
///     https://leetcode.com/problems/continuous-subarray-sum/description/
/// </summary>
public interface IContinuousSubarraySum
{
    /// <summary>
    ///     Determines whether <paramref name="nums" /> contains a continuous subarray of length at least 2 whose sum is
    ///     a multiple of <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to examine.</param>
    /// <param name="k">The divisor that the subarray sum must be a multiple of.</param>
    /// <returns>
    ///     <see langword="true" /> if such a subarray exists; otherwise, <see langword="false" />.
    /// </returns>
    bool CheckSubarraySum(int[] nums, int k);
}