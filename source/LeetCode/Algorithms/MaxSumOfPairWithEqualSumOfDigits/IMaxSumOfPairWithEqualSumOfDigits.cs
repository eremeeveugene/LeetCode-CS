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

namespace LeetCode.Algorithms.MaxSumOfPairWithEqualSumOfDigits;

/// <summary>
///     https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits/description/
/// </summary>
public interface IMaxSumOfPairWithEqualSumOfDigits
{
    /// <summary>
    ///     Finds the maximum sum of a pair of elements from <paramref name="nums" /> whose digit sums are equal.
    /// </summary>
    /// <param name="nums">The array of integers to pair up.</param>
    /// <returns>The maximum sum of a qualifying pair, or -1 if no such pair exists.</returns>
    int MaximumSum(int[] nums);
}