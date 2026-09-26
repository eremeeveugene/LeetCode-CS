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

namespace LeetCode.Algorithms.EvaluateTheBracketPairsOfString;

/// <summary>
///     https://leetcode.com/problems/evaluate-the-bracket-pairs-of-a-string/description/
/// </summary>
public interface IEvaluateTheBracketPairsOfString
{
    /// <summary>
    ///     Replaces each bracketed key with its known value, or a question mark if the key is unknown.
    /// </summary>
    /// <param name="s">The string containing non-nested bracket pairs and lowercase letters.</param>
    /// <param name="knowledge">The unique keys and their corresponding values.</param>
    /// <returns>The string after evaluating all bracket pairs.</returns>
    string Evaluate(string s, IList<IList<string>> knowledge);
}