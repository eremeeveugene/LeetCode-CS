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

namespace LeetCode.Algorithms.EqualScoreSubstrings;

/// <summary>
///     https://leetcode.com/problems/equal-score-substrings/description/
/// </summary>
public interface IEqualScoreSubstrings
{
    /// <summary>
    ///     Determines whether <paramref name="s" /> can be split into two non-empty substrings whose character value
    ///     sums (a=1, b=2, ..., z=26) are equal.
    /// </summary>
    /// <param name="s">The string of lowercase letters to split.</param>
    /// <returns>
    ///     <see langword="true" /> if such a split exists; otherwise, <see langword="false" />.
    /// </returns>
    bool ScoreBalance(string s);
}