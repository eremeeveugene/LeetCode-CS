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

namespace LeetCode.Algorithms.SumOfIntegersWithMaximumDigitRange;

/// <summary>
///     https://leetcode.com/problems/sum-of-integers-with-maximum-digit-range/description/
/// </summary>
public interface ISumOfIntegersWithMaximumDigitRange
{
    /// <summary>
    ///     Computes the sum of all integers in <paramref name="nums" /> whose digit range, the difference between an
    ///     integer's largest and smallest digit, equals the maximum digit range among all integers in the array.
    /// </summary>
    /// <param name="nums">The array of integers to evaluate.</param>
    /// <returns>The sum of the integers sharing the maximum digit range.</returns>
    int MaxDigitRange(int[] nums);
}