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

namespace LeetCode.Algorithms.MinimumOperationsToSortAString;

/// <summary>
///     https://leetcode.com/problems/minimum-operations-to-sort-a-string/description/
/// </summary>
public interface IMinimumOperationsToSortAString
{
    /// <summary>
    ///     Computes the minimum number of operations needed to sort <paramref name="s" /> in non-descending order,
    ///     where each operation sorts any substring that is not the entire string.
    /// </summary>
    /// <param name="s">The string of lowercase English letters to sort.</param>
    /// <returns>
    ///     The minimum number of operations needed to sort <paramref name="s" />, or -1 if it is impossible.
    /// </returns>
    int MinOperations(string s);
}