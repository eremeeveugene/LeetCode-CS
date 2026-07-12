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

namespace LeetCode.Algorithms.NumberOfZeroFilledSubarrays;

/// <summary>
///     https://leetcode.com/problems/number-of-zero-filled-subarrays/description/
/// </summary>
public interface INumberOfZeroFilledSubarrays
{
    /// <summary>
    ///     Counts the number of subarrays of <paramref name="nums" /> that consist entirely of zeroes.
    /// </summary>
    /// <param name="nums">The array of integers to search for zero-filled subarrays.</param>
    /// <returns>The total number of subarrays that contain only zeroes.</returns>
    long ZeroFilledSubarray(int[] nums);
}