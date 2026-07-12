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

namespace LeetCode.Algorithms.SumOfAllSubsetXORTotals;

/// <summary>
///     https://leetcode.com/problems/sum-of-all-subset-xor-totals/description/
/// </summary>
public interface ISumOfAllSubsetXORTotals
{
    /// <summary>
    ///     Computes the sum, over every possible subset of <paramref name="nums" />, of the bitwise XOR of all
    ///     elements in that subset.
    /// </summary>
    /// <param name="nums">The array of integers to generate subsets from.</param>
    /// <returns>The sum of the XOR totals of all subsets of <paramref name="nums" />.</returns>
    int SubsetXORSum(int[] nums);
}