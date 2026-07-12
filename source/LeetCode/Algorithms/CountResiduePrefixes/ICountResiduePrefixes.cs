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

namespace LeetCode.Algorithms.CountResiduePrefixes;

/// <summary>
///     https://leetcode.com/problems/count-residue-prefixes/description/
/// </summary>
public interface ICountResiduePrefixes
{
    /// <summary>
    ///     Counts the prefixes of <paramref name="s" /> that qualify as residue prefixes.
    /// </summary>
    /// <param name="s">The string whose prefixes are examined.</param>
    /// <returns>The number of residue prefixes of <paramref name="s" />.</returns>
    int ResiduePrefixes(string s);
}