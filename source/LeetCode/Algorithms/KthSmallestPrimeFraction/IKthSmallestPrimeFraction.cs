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

namespace LeetCode.Algorithms.KthSmallestPrimeFraction;

/// <summary>
///     https://leetcode.com/problems/k-th-smallest-prime-fraction/description/
/// </summary>
public interface IKthSmallestPrimeFraction
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th smallest fraction formed by dividing pairs of elements of
    ///     <paramref name="arr" />.
    /// </summary>
    /// <param name="arr">The sorted array of 1 and prime numbers.</param>
    /// <param name="k">The 1-based rank of the fraction to find.</param>
    /// <returns>An array of two integers where the first element is the numerator and the second is the denominator of the <paramref name="k" />-th smallest fraction.</returns>
    int[] KthSmallestPrimeFraction(int[] arr, int k);
}