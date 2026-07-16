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

namespace LeetCode.Algorithms.SumOfGcdOfFormedPairs;

/// <summary>
///     https://leetcode.com/problems/sum-of-gcd-of-formed-pairs/description/
/// </summary>
public interface ISumOfGcdOfFormedPairs
{
    /// <summary>
    ///     Computes the sum of GCD values of pairs formed from the prefix GCD array, where prefixGcd[i] is the GCD of
    ///     nums[i] and the maximum of the first i + 1 elements, and pairs are formed by repeatedly taking the smallest
    ///     and largest unpaired elements of the sorted prefix GCD array, ignoring the middle element when the length
    ///     is odd.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns>The sum of the GCD values of all formed pairs.</returns>
    long GcdSum(int[] nums);
}