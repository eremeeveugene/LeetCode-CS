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

namespace LeetCode.Algorithms.CountConsistentSubarrays1;

/// <summary>
///     https://leetcode.com/problems/count-consistent-subarrays-i/description/
/// </summary>
public interface ICountConsistentSubarrays1
{
    /// <summary>
    ///     Counts the subarrays of <paramref name="nums" /> whose bitwise AND of all elements is equal to the minimum
    ///     value of the subarray.
    /// </summary>
    /// <param name="nums">The array of non-negative integers.</param>
    /// <returns>The number of consistent subarrays.</returns>
    int CountConsistent(int[] nums);
}