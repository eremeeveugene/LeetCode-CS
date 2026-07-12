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

namespace LeetCode.Algorithms.LexicographicallySmallestEquivalentString;

/// <summary>
///     https://leetcode.com/problems/lexicographically-smallest-equivalent-string/description/
/// </summary>
public interface ILexicographicallySmallestEquivalentString
{
    /// <summary>
    ///     Using the character equivalences defined by corresponding positions in <paramref name="s1" /> and <paramref name="s2" />, transforms <paramref name="baseStr" /> by replacing each character with the lexicographically smallest character in its equivalence group.
    /// </summary>
    /// <param name="s1">The first string defining character equivalences.</param>
    /// <param name="s2">The second string defining character equivalences, paired position-wise with <paramref name="s1" />.</param>
    /// <param name="baseStr">The string to transform using the derived equivalences.</param>
    /// <returns>The lexicographically smallest equivalent string of <paramref name="baseStr" />.</returns>
    string SmallestEquivalentString(string s1, string s2, string baseStr);
}