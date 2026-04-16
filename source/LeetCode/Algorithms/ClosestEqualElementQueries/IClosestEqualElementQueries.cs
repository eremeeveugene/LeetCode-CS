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

namespace LeetCode.Algorithms.ClosestEqualElementQueries;

/// <summary>
///     https://leetcode.com/problems/closest-equal-element-queries/description/
/// </summary>
public interface IClosestEqualElementQueries
{
    /// <summary>
    ///     For each index in <paramref name="queries" />, returns the shortest circular
    ///     distance to another occurrence of the same value in <paramref name="nums" />,
    ///     or <c>-1</c> if no such occurrence exists.
    /// </summary>
    /// <param name="nums">The circular source array of integers.</param>
    /// <param name="queries">Indices into <paramref name="nums" /> to query.</param>
    /// <returns>
    ///     A list of the same length as <paramref name="queries" /> where each element
    ///     is the minimum circular distance to an equal element, or <c>-1</c>.
    /// </returns>
    IList<int> SolveQueries(int[] nums, int[] queries);
}