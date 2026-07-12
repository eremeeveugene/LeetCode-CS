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

namespace LeetCode.Algorithms.NumberOfSubArraysWithOddSum;

/// <summary>
///     https://leetcode.com/problems/number-of-sub-arrays-with-odd-sum/description/
/// </summary>
public interface INumberOfSubArraysWithOddSum
{
    /// <summary>
    ///     Counts the number of subarrays of <paramref name="arr" /> whose elements sum to an odd number.
    /// </summary>
    /// <param name="arr">The array of integers to search for subarrays with an odd sum.</param>
    /// <returns>The number of subarrays with an odd sum, modulo 10^9 + 7.</returns>
    int NumOfSubarrays(int[] arr);
}