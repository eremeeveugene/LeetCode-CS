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

namespace LeetCode.Algorithms.CountCompleteSubarraysInAnArray;

/// <summary>
///     https://leetcode.com/problems/count-complete-subarrays-in-an-array/description/
/// </summary>
public interface ICountCompleteSubarraysInAnArray
{
    /// <summary>
    ///     Counts the contiguous subarrays of <paramref name="nums" /> whose number of distinct elements equals the number
    ///     of distinct elements in the whole array.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <returns>The number of complete subarrays.</returns>
    int CountCompleteSubarrays(int[] nums);
}