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

namespace LeetCode.Algorithms.LargestPositiveIntegerThatExistsWithItsNegative;

/// <summary>
///     https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/
/// </summary>
public interface ILargestPositiveIntegerThatExistsWithItsNegative
{
    /// <summary>
    ///     Finds the largest positive integer k such that both k and -k exist in <paramref name="nums" />.
    /// </summary>
    /// <param name="nums">The array of integers that does not contain zeros.</param>
    /// <returns>The largest positive integer that exists along with its negative, or -1 if there is no such integer.</returns>
    int FindMaxK(int[] nums);
}