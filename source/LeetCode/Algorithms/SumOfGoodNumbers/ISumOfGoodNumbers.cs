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

namespace LeetCode.Algorithms.SumOfGoodNumbers;

/// <summary>
///     https://leetcode.com/problems/sum-of-good-numbers/description/
/// </summary>
public interface ISumOfGoodNumbers
{
    /// <summary>
    ///     Sums every "good" element of <paramref name="nums" /> — an element that is strictly greater than the
    ///     elements exactly <paramref name="k" /> positions before and after it in the array.
    /// </summary>
    /// <param name="nums">The array of integers to inspect.</param>
    /// <param name="k">The offset used to identify the neighbors that must be smaller than a good number.</param>
    /// <returns>The sum of all good numbers in <paramref name="nums" />.</returns>
    int SumOfGoodNumbers(int[] nums, int k);
}