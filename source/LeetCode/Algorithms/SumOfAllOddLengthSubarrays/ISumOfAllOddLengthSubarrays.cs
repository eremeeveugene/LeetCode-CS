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

namespace LeetCode.Algorithms.SumOfAllOddLengthSubarrays;

/// <summary>
///     https://leetcode.com/problems/sum-of-all-odd-length-subarrays/description/
/// </summary>
public interface ISumOfAllOddLengthSubarrays
{
    /// <summary>
    ///     Computes the sum of all elements across every contiguous subarray of <paramref name="arr" /> that
    ///     has an odd length.
    /// </summary>
    /// <param name="arr">The array of positive integers to process.</param>
    /// <returns>The sum of all elements in every odd-length subarray of <paramref name="arr" />.</returns>
    int SumOddLengthSubarrays(int[] arr);
}