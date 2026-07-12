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

namespace LeetCode.Algorithms.CountServersThatCommunicate;

/// <summary>
///     https://leetcode.com/problems/count-servers-that-communicate/description/
/// </summary>
public interface ICountServersThatCommunicate
{
    /// <summary>
    ///     Counts the servers in <paramref name="grid" /> that communicate with at least one other server on the same
    ///     row or column.
    /// </summary>
    /// <param name="grid">The matrix where a value of one marks a cell containing a server.</param>
    /// <returns>The number of servers that communicate with at least one other server.</returns>
    int CountServers(int[][] grid);
}