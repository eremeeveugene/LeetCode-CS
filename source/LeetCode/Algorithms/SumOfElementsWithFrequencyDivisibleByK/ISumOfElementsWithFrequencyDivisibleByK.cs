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

namespace LeetCode.Algorithms.SumOfElementsWithFrequencyDivisibleByK;

/// <summary>
///     https://leetcode.com/problems/sum-of-elements-with-frequency-divisible-by-k/description/
/// </summary>
public interface ISumOfElementsWithFrequencyDivisibleByK
{
    /// <summary>
    ///     Sums every element of <paramref name="nums" /> whose frequency in the array is divisible by
    ///     <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers to inspect.</param>
    /// <param name="k">The divisor that a value's frequency must be divisible by for it to be included.</param>
    /// <returns>The sum of all elements whose frequency is divisible by <paramref name="k" />.</returns>
    int SumDivisibleByK(int[] nums, int k);
}