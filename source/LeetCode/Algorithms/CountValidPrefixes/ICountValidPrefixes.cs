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

namespace LeetCode.Algorithms.CountValidPrefixes;

/// <summary>
///     https://leetcode.com/problems/count-valid-prefixes/description/
/// </summary>
public interface ICountValidPrefixes
{
    /// <summary>
    ///     Counts the prefixes of <paramref name="s" /> whose characters can be rearranged into an alternating string.
    /// </summary>
    /// <param name="s">The binary string whose prefixes are evaluated.</param>
    /// <returns>The number of valid prefixes.</returns>
    int CountValidPrefixes(string s);
}