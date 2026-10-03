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

namespace LeetCode.Algorithms.FindXValueOfArray1;

/// <summary>
///     https://leetcode.com/problems/find-x-value-of-array-i/description/
/// </summary>
public interface IFindXValueOfArray1
{
    /// <summary>
    ///     Counts nonempty subarrays by the remainder of their product when divided by k.
    /// </summary>
    /// <param name="nums">The array of positive integers.</param>
    /// <param name="k">The divisor, between one and five.</param>
    /// <returns>An array whose entry at each remainder is the number of subarrays with that product remainder.</returns>
    long[] ResultArray(int[] nums, int k);
}