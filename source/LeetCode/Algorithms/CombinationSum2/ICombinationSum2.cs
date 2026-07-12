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

namespace LeetCode.Algorithms.CombinationSum2;

/// <summary>
///     https://leetcode.com/problems/combination-sum-ii/description/
/// </summary>
public interface ICombinationSum2
{
    /// <summary>
    ///     Finds all unique combinations of <paramref name="candidates" /> where the candidate numbers sum to
    ///     <paramref name="target" />, using each candidate at most once per combination.
    /// </summary>
    /// <param name="candidates">The collection of candidate numbers.</param>
    /// <param name="target">The target sum.</param>
    /// <returns>A list of all unique combinations whose elements sum to <paramref name="target" />.</returns>
    IList<IList<int>> CombinationSum2(int[] candidates, int target);
}