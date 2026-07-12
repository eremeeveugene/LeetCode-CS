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

namespace LeetCode.Algorithms.CountEqualAndDivisiblePairsInAnArray;

/// <summary>
///     https://leetcode.com/problems/count-equal-and-divisible-pairs-in-an-array/description/
/// </summary>
public interface ICountEqualAndDivisiblePairsInAnArray
{
    /// <summary>
    ///     Counts the index pairs (i, j) with i &lt; j such that <paramref name="nums" />[i] equals
    ///     <paramref name="nums" />[j] and the product i * j is divisible by <paramref name="k" />.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <param name="k">The divisor for the product of the indices.</param>
    /// <returns>The number of pairs satisfying both conditions.</returns>
    int CountPairs(int[] nums, int k);
}