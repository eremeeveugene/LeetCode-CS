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

namespace LeetCode.Algorithms.CheckIfArrayPairsAreDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/check-if-array-pairs-are-divisible-by-k/
/// </summary>
public interface ICheckIfArrayPairsAreDivisibleByK
{
    /// <summary>
    ///     Determines whether <paramref name="arr" /> can be divided into pairs such that the sum of each pair is divisible
    ///     by <paramref name="k" />.
    /// </summary>
    /// <param name="arr">The array of integers with an even length.</param>
    /// <param name="k">The divisor for each pair sum.</param>
    /// <returns><c>true</c> if <paramref name="arr" /> can be arranged into such pairs; otherwise, <c>false</c>.</returns>
    bool CanArrange(int[] arr, int k);
}