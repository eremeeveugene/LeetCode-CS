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

namespace LeetCode.Algorithms.RangeProductQueriesOfPowers;

/// <summary>
///     https://leetcode.com/problems/range-product-queries-of-powers/description/
/// </summary>
public interface IRangeProductQueriesOfPowers
{
    /// <summary>
    ///     Computes, for each query in <paramref name="queries" />, the product of the powers of two in the minimal
    ///     representation of <paramref name="n" /> between the given index range, modulo 10^9 + 7.
    /// </summary>
    /// <param name="n">The integer whose minimal set of powers of two is used to answer the queries.</param>
    /// <param name="queries">The list of queries, each expressed as an inclusive index range into the powers array.</param>
    /// <returns>An array containing the answer to each query, modulo 10^9 + 7.</returns>
    int[] ProductQueries(int n, int[][] queries);
}