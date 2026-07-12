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

namespace LeetCode.Algorithms.SumOfVariableLengthSubarrays;

/// <summary>
///     https://leetcode.com/problems/sum-of-variable-length-subarrays/description/
/// </summary>
public interface ISumOfVariableLengthSubarrays
{
    /// <summary>
    ///     Sums the elements of every variable-length subarray of <paramref name="nums" />, where each subarray
    ///     ending at index <c>i</c> starts at <c>max(0, i - nums[i])</c>.
    /// </summary>
    /// <param name="nums">The array of integers defining the subarray boundaries and values.</param>
    /// <returns>The total sum across all the variable-length subarrays.</returns>
    int SubarraySum(int[] nums);
}