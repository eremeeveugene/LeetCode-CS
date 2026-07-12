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

namespace LeetCode.Algorithms.ReverseDegreeOfString;

/// <summary>
///     https://leetcode.com/problems/reverse-degree-of-a-string/description/
/// </summary>
public interface IReverseDegreeOfString
{
    /// <summary>
    ///     Computes the reverse degree of <paramref name="s" /> by summing, for each character, the product of its
    ///     1-indexed position and its value from 26 (for 'a') down to 1 (for 'z').
    /// </summary>
    /// <param name="s">The string of lowercase letters to evaluate.</param>
    /// <returns>The reverse degree of <paramref name="s" />.</returns>
    int ReverseDegree(string s);
}