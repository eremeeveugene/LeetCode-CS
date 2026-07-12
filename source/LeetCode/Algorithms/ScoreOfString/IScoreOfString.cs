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

namespace LeetCode.Algorithms.ScoreOfString;

/// <summary>
///     https://leetcode.com/problems/score-of-a-string/
/// </summary>
public interface IScoreOfString
{
    /// <summary>
    ///     Computes the sum of the absolute differences between the ASCII values of adjacent characters in
    ///     <paramref name="s" />.
    /// </summary>
    /// <param name="s">The string whose score is to be computed.</param>
    /// <returns>The score of <paramref name="s" />.</returns>
    int ScoreOfString(string s);
}