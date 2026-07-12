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

namespace LeetCode.Algorithms.NumberOfSubsequencesThatSatisfyTheGivenSumCondition;

/// <summary>
///     https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/description/
/// </summary>
public interface INumberOfSubsequencesThatSatisfyTheGivenSumCondition
{
    /// <summary>
    ///     Counts the number of non-empty subsequences of <paramref name="nums" /> in which the sum of the minimum
    ///     and maximum elements is less than or equal to <paramref name="target" />.
    /// </summary>
    /// <param name="nums">The array of integers to search for qualifying subsequences.</param>
    /// <param name="target">The maximum allowed sum of the minimum and maximum elements of a subsequence.</param>
    /// <returns>The number of qualifying subsequences, modulo 10^9 + 7.</returns>
    int NumSubseq(int[] nums, int target);
}