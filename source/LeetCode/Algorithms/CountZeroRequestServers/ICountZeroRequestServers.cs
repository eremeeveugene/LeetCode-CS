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

namespace LeetCode.Algorithms.CountZeroRequestServers;

/// <summary>
///     https://leetcode.com/problems/count-zero-request-servers/description/
/// </summary>
public interface ICountZeroRequestServers
{
    /// <summary>
    ///     Counts, for each query, the servers that received no requests during the inclusive time interval
    ///     from the query time minus <paramref name="x" /> to the query time.
    /// </summary>
    /// <param name="n">The total number of servers, identified from 1 to <paramref name="n" />.</param>
    /// <param name="logs">The requests, where each entry holds the server identifier and the request time.</param>
    /// <param name="x">The length of the time interval that ends at each query time.</param>
    /// <param name="queries">The query times.</param>
    /// <returns>The number of servers without requests for each query, in the order of <paramref name="queries" />.</returns>
    int[] CountServers(int n, int[][] logs, int x, int[] queries);
}