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

namespace LeetCode.Algorithms.MaximumXORForEachQuery;

/// <summary>
///     https://leetcode.com/problems/maximum-xor-for-each-query/description/
/// </summary>
public interface IMaximumXORForEachQuery
{
    /// <summary>
    ///     For each query, removes the last element of the remaining prefix of <paramref name="nums" /> and finds
    ///     the value <c>k</c> in <c>[0, 2^maximumBit - 1]</c> that maximizes the XOR of <c>k</c> with all remaining
    ///     elements.
    /// </summary>
    /// <param name="nums">The array of integers to process.</param>
    /// <param name="maximumBit">The number of bits that bound the value of each answer.</param>
    /// <returns>An array containing the answer to each query, in order.</returns>
    int[] GetMaximumXor(int[] nums, int maximumBit);
}