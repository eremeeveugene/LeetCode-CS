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

namespace LeetCode.Algorithms.KthSmallestInLexicographicalOrder;

/// <summary>
///     https://leetcode.com/problems/k-th-smallest-in-lexicographical-order/
/// </summary>
public interface IKthSmallestInLexicographicalOrder
{
    /// <summary>
    ///     Finds the <paramref name="k" />-th smallest integer in lexicographical order in the range from 1 to
    ///     <paramref name="n" />.
    /// </summary>
    /// <param name="n">The upper bound of the range of integers.</param>
    /// <param name="k">The 1-based position in lexicographical order.</param>
    /// <returns>The <paramref name="k" />-th lexicographically smallest integer in the range [1, <paramref name="n" />].</returns>
    int FindKthNumber(int n, int k);
}